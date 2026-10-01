namespace AppForSEII.API.Models;

    [PrimaryKey(nameof(LibroId), nameof(CompraId))]

public class CompraItem
{
    
    //Constructor vacio
    public CompraItem()
    {
        
    }

    //Constructor con parametros
    public CompraItem(int cantidad, int libroId, int compraId)
    {
        Cantidad = cantidad;
        LibroId = libroId;
        CompraId = compraId;
    }

    [System.ComponentModel.DataAnnotations.Range(2, int.MaxValue, ErrorMessage = "La cantidad de compra debe ser mayor que 1.")] //Valor obligatoriamente mayor que 1
    [System.ComponentModel.DataAnnotations.Display(Name = "Cantidad comprada")]
    public int Cantidad { get; set;}

    [System.ComponentModel.DataAnnotations.Display(Name = "ID del Libro")]
    public int LibroId { get; set; } //FK al atributo Id de la clase Libro


    [System.ComponentModel.DataAnnotations.Display(Name = "ID de la Compra")]
     public int CompraId { get; set; } //FK al atributo Id de la clase Compra

}

    


    










