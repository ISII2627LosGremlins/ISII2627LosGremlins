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

        //Relaciones
        public IList<Reposicion> Reposiciones { get; set; } //Relación uno a muchos con la clase Reposicion

        public IList<Compra> Compras { get; set;} //Relación uno a muchos con la clase Compra

    }
}