namespace AppForSEII.API.Data {
    public class SeedData {
        public static void Initialize(ApplicationDbContext dbContext, IServiceProvider serviceProvider, ILogger logger) {
            List<string> rolesNames = new List<string> { "Administrator", "Employee", "Customer" };

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            try {
                SeedRoles(roleManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the roles in the Database.");
            }

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            try {
                SeedUsers(userManager, rolesNames);
            }
            catch (Exception ex) {
                logger.LogError(ex, "An error occurred seeding the Users in the Database.");
            }

            try
            {
                SeedLibros(dbContext);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error al cargar los libros iniciales.");
            }
 

        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager, List<string> roles) {

            foreach (string roleName in roles) {
                //it checks such role does not exist in the database 
                if (!roleManager.RoleExistsAsync(roleName).Result) {
                    IdentityRole role = new IdentityRole();
                    role.Name = roleName;
                    role.NormalizedName = roleName;
                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                }
            }

        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager, List<string> roles) {
            //first, it checks the user does not already exist in the DB
            if (userManager.FindByNameAsync("elena@uclm.es").Result == null) {
                ApplicationUser user = new ApplicationUser("1", "Elena", "Navarro Martínez", "calle la concepcion 2","667676767");
                user.UserName = "elena@uclm.es";
                user.Email = "elena@uclm.es";
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "Password1234%");
                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //administrator role
                    userManager.AddToRoleAsync(user, roles[0]).Wait();
                }
            }


            if (userManager.FindByNameAsync("peter@uclm.es").Result == null) {
                //A customer class has been defined because it has different attributes (purchase, rental, etc.)
                ApplicationUser user = new ApplicationUser("3", "Peter", "Jackson", "avenida moncloa 5","634289120");
                user.UserName = "peter@uclm.es";
                user.Email = "peter@uclm.es";
                user.EmailConfirmed = true;

                var result = userManager.CreateAsync(user, "OtherPass12$");

                result.Wait();

                if (result.IsCompletedSuccessfully) {
                    //customer role
                    userManager.AddToRoleAsync(user, roles[2]).Wait();

                }
            }

        }

        public static void SeedLibros(ApplicationDbContext dbContext) {
            if (dbContext.Libros.Any())
            {
                return;
            }
            
            //Editoriales
            var editorialPenguin = new Editorial { Nombre = "Penguin" };
            var editorialEspasa = new Editorial { Nombre = "Espasa" };
            var editorialPlaneta = new Editorial{ Nombre = "Planeta" };
            var editorialSalamandra = new Editorial{ Nombre = "Salamandra" };

            //Géneros
            var generoEconomia = new Genero { Nombre = "Economía" };
            var generoPsicología = new Genero { Nombre = "Psicología" };
            var generoSuspense = new Genero { Nombre = "Suspense" };
            var generoFantasia = new Genero { Nombre = "Fantasia" };


            var libro1 = new Libro
            {
                Titulo = "Padre Rico, Padre Pobre",
                Autor = "Robert Kiyosaki",
                TipoLibro = "Tapa blanda",
                FechaLanzamiento = new DateTime(1997, 4, 8), //(año,  mes, día)
                PrecioCompra = 15,
                PrecioReposicion = 9,
                Stock = 10,
                CalificacionMedia = 0,
                Editorial = editorialPenguin,
                Genero = generoEconomia
            };

            var libro2 = new Libro
            {
                Titulo = "La psicología del dinero",
                Autor = "Morgan Housel",
                TipoLibro = "Tapa blanda",
                FechaLanzamiento = new DateTime(2021, 9, 1),
                PrecioCompra = 20,
                PrecioReposicion = 12,
                Stock = 5,
                CalificacionMedia = 0,
                Editorial = editorialPlaneta,
                Genero = generoEconomia
            };

            var libro3 = new Libro
            {
                Titulo = "Recupera tu mente, reconquista tu vida",
                Autor = "Marian Rojas Estapé",
                TipoLibro = "Tapa blanda",
                FechaLanzamiento = new DateTime(2024, 4, 3),
                PrecioCompra = 30,
                PrecioReposicion = 18,
                Stock = 3,
                CalificacionMedia = 0,
                Editorial = editorialEspasa,
                Genero = generoPsicología
            };

            var libro4 = new Libro
            {
                Titulo = "Cómo hacer que te pasen cosas buenas",
                Autor = "Marian Rojas Estapé",
                TipoLibro = "Tapa blanda",
                FechaLanzamiento = new DateTime(2018, 10, 9),
                PrecioCompra = 35,
                PrecioReposicion = 21,
                Stock = 3,
                CalificacionMedia = 0,
                Editorial = editorialEspasa,
                Genero = generoPsicología
            };

            var libro5 = new Libro
            {
                Titulo = "Harry Potter y la piedra filosofal",
                Autor = "Joanne Rowling",
                TipoLibro = "Tapa dura",
                FechaLanzamiento = new DateTime(1997, 6, 26),
                PrecioCompra = 25,
                PrecioReposicion = 18,
                Stock = 8,
                CalificacionMedia = 0,
                Editorial = editorialSalamandra,
                Genero = generoFantasia
            };

            var libro6 = new Libro
            {
                Titulo = "Ángeles y demonios",
                Autor = "Dan Brown",
                TipoLibro = "Tapa blanda",
                FechaLanzamiento = new DateTime(2000, 5, 1),
                PrecioCompra = 20,
                PrecioReposicion = 12,
                Stock = 0,
                CalificacionMedia = 0,
                Editorial = editorialPlaneta,
                Genero = generoSuspense
            };


            dbContext.Libros.Add(libro1);
            dbContext.Libros.Add(libro2);
            dbContext.Libros.Add(libro3);
            dbContext.Libros.Add(libro4);
            dbContext.Libros.Add(libro5);
            dbContext.Libros.Add(libro6);

            dbContext.SaveChanges();
        }


    }
}