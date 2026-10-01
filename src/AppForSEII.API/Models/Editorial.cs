namespace AppForSEII.API.Models
{
    public class Editorial
    {
        // Constructor vacío
        public Editorial()
        {
        }

        // Constructor con parámetros
        public Editorial(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // Propiedades
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        
        //Relaciones (BDD)
        public IList<Libro> Libros { get; set; }
    }   
}