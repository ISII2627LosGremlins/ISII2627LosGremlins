namespace AppForSEII.API.Models
{
    public class Visa: MetodoPago
    {
        //Constructor vacio
        public Visa()
        {
            
        }

        //Contructor con parametros
        public Visa(string numeroTarjeta, DateTime fechaCaducidad)
        {
            NumeroTarjeta = numeroTarjeta;
            FechaCaducidad = fechaCaducidad;
        }

        //Propiedades
        [Required]
        [System.ComponentModel.DataAnnotations.Display(Name = "Número de Tarjeta")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "El número de tarjeta debe tener 16 caracteres.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "El número de tarjeta solo puede contener números.")]
        public string NumeroTarjeta { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de Caducidad")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)] //Establece el formato de fecha (mes/año) para la propiedad FechaCaducidad
        public DateTime FechaCaducidad { get; set; }
        
    }
}