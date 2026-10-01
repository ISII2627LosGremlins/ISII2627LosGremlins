namespace AppForSEII.API.Models
{
    public class PayPal: MetodoPago
    {
        //Constructor vacio
        public PayPal()
        {
            
        }

        //Contructor con parametros
        public PayPal(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        //Propiedades
        [Required]
        [System.ComponentModel.DataAnnotations.Display(Name = "Número de teléfono")]
	    [Phone] //Comprueba que tenga un formato de teléfono válido.
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El teléfono debe tener 9 numeros.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El número de teléfono solo puede contener números.")]
        public string NumeroTelefono { get; set; }
        
    }
}