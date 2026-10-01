namespace AppForSEII.API.Models
{
    public class Reposicion
    {
        //Constructor vacio
        public Reposicion()
        {
            
        }

        //Contructor con parametros
        public Reposicion(int id, DateTime fechaReposicion, decimal precioTotal, string comentario)
        {
            Id = id;
            FechaReposicion = fechaReposicion;
            PrecioTotal = precioTotal;
            Comentario = comentario;
        }

        //Propiedades
        public int Id { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de Reposición")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] //Establece el formato de fecha para la propiedad FechaReposicion
        public DateTime FechaReposicion { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [System.ComponentModel.DataAnnotations.Display(Name = "Precio Total")]
        [Precision(5, 2)] //Establece la precisión y escala de la propiedad PrecioTotal
        public decimal PrecioTotal { get; set; }

        [StringLength(100, MinimumLength = 20, ErrorMessage = "El comentario debe tener entre 20 y 100 caracteres.")] 
        public string? Comentario { get; set; } //Con '?' hacemos que la propiedad sea opcional, es decir, que pueda ser nula.

        //Relaciones
        public IList<ReposicionItem> ReposicionItems { get; set; } //Relación uno a muchos con la clase ReposicionItem

        public ApplicationUser Usuario { get; set; } //Relación muchos a uno con la clase ApplicationUser

        public IList<MetodoPago> MetodoPagos { get; set; } //Relación muchos a uno con la clase MetodoPago


    }
}