namespace AppForSEII.API.Models
{
    public class ReposicionItem
    {
        //Constructor vacio
        public ReposicionItem()
        {
            
        }

        //Contructor con parametros
        public ReposicionItem(int cantidadReposicion, int libroId, int reposicionId)
        {
            CantidadReposicion = cantidadReposicion;
            LibroId = libroId;
            ReposicionId = reposicionId;
        }

        //Propiedades

        [System.ComponentModel.DataAnnotations.Range(2, int.MaxValue, ErrorMessage = "La cantidad de reposición debe ser mayor que 1.")] //Valor obligatoriamente mayor que 1
        [System.ComponentModel.DataAnnotations.Display(Name = "Cantidad de Reposición")]
        public int CantidadReposicion { get; set; }

        
        [System.ComponentModel.DataAnnotations.Display(Name = "ID del Libro")]
        public int LibroId { get; set; } //FK al atributo Id de la clase Libro


        [System.ComponentModel.DataAnnotations.Display(Name = "ID de la Reposición")]
        public int ReposicionId { get; set; } //FK al atributo Id de la clase Reposicion

    }
}