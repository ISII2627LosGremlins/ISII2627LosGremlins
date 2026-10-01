namespace AppForSEII.API.Models
{
    public abstract class MetodoPago
    {
        //Constructor vacio
        public MetodoPago()
        {
            
        }

        //Contructor con parametros
        public MetodoPago(int id)
        {
            Id = id;
        }

        //Propiedades
        [Key]
        public int Id { get; set; }
    }
}