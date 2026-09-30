namespace AppForSEII.API.Models
{
    [PrimaryKey(nameof(LibroId), nameof(ResenaId))]
    public class ResenaItem
    {
        //Constructor vacío
        public ResenaItem()
        {
        }

        //Constructor con parámetros
        public ResenaItem(string? descripcion, int calificacion,
                          int libroId, int resenaId)
        {
            Descripcion = descripcion;
            Calificacion = calificacion;
            LibroId = libroId;
            ResenaId = resenaId;
        }

        //Propiedades
        [StringLength(100, MinimumLength = 20,
            ErrorMessage = "La descripción debe tener entre 20 y 100 caracteres.")]
        public string? Descripcion { get; set; }

        [Range(1, 5, ErrorMessage = "La calificación debe estar entre 1 y 5.")]
        public int Calificacion { get; set; }

        public int LibroId { get; set; }

        public int ResenaId { get; set; }
    }
}