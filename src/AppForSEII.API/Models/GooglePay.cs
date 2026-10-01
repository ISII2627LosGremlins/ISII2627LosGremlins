namespace AppForSEII.API.Models
{
    public class GooglePay: MetodoPago
    {
        //Constructor vacio
        public GooglePay()
        {
            
        }

        //Contructor con parametros
        public GooglePay(string email)
        {
            Email = email;
        }

        //Propiedades
        [Required]
	    [EmailAddress] //Comprueba que tenga un formato de correo electrónico válido.
        [StringLength(254, ErrorMessage = "El email debe tener un máximo de 254 caracteres.")]
        public string Email { get; set; }
        
    }
}