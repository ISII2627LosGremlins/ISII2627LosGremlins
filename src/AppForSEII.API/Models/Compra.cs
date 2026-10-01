namespace AppForSEII.API.Models;

public class Compra
{
    
    //Constructor vacio
    public Compra()
    {
        
    }

    //Constructor con atributos
    public Compra(int id, DateTime fechaCompra, decimal precioTotal, string codigoDescuento)
    {
        Id = id;
        FechaCompra = fechaCompra;
        PrecioTotal = precioTotal;
        CodigoDescuento = codigoDescuento;
    }

    //Clave primaria
    public int Id { get; set;}

    [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha Compra")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCompra {get; set;}

    [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Precio Total")]
    [Precision(5, 2)] //Establece la precisión y escala de la propiedad PrecioTotal
    public decimal PrecioTotal {get; set;}

    [StringLength(10, MinimumLength = 5, ErrorMessage = "El comentario debe tener entre 5 y 10.")] //El length viene dado en el pdf
    public string? CodigoDescuento {get; set;} //Este atributo es opcional, el cliente puede no usar un codigo de descuento a la hora de comprar

    //Relaciones
    public IList<CompraItem> CompraItems { get; set;}

    public ApplicationUser Usuario{ get; set;}

    
    //Metodos de la clase
}