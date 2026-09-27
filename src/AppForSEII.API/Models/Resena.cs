namespace AppForSEII.API.Models
{
    public class Resena
    {
        // Constructor vacío
        public Resena()
        {
        }

        // Constructor con parámetros
        public Resena(int id, DateTime fechaResena, string titulo)
        {
            Id = id;
            FechaResena = fechaResena;
            Titulo = titulo;
        }

        // Propiedades
        [Key]
        public int Id { get; set; }
    

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de la reseña")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] //Establece el formato de fecha para la propiedad FechaResena
        public DateTime FechaResena { get; set; }


        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo { get; set; }
    }
}