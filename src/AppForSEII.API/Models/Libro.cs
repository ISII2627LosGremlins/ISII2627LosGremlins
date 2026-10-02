namespace AppForSEII.API.Models;

public class Libro
{
    //Constructor vacio 
    public Libro() 
    {
    }

    //Constructor de la clase con sus atributos
    public Libro(int id,string titulo,string tipoLibro,string autor, decimal calificacionMedia, DateTime fechaLanzamiento,decimal precioCompra,decimal precioReposicion,int stock)
    {
        Id = id;
        Titulo = titulo;
        TipoLibro = tipoLibro;
        Autor = autor;
        CalificacionMedia = calificacionMedia;
        FechaLanzamiento = fechaLanzamiento;
        PrecioCompra = precioCompra;
        PrecioReposicion = precioReposicion;
        Stock = stock;
    }

    // Clave primaria (ID)
    public int Id { get; set; }
    
    [Required(ErrorMessage = "El título es obligatorio.")]
    [System.ComponentModel.DataAnnotations.Display(Name = "Título")]
    [StringLength(50, ErrorMessage = "El título debe tener entre 1 y 50 caracteres.",MinimumLength = 1)] //Hacemos que sea obligatorio
    [RegularExpression(@"^[A-ZÁÉÍÓÚÜÑ]+[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ0-9\s'-]*$")] //Obligamos que la primera letra del título sea una mayúscula y que contega el abecedario español completo y numeros.
    public string Titulo { get; set; }

    [Required(ErrorMessage = "El autor es obligatorio.")]
    [System.ComponentModel.DataAnnotations.Display(Name = "Autor")] 
    [StringLength(50, ErrorMessage = "El autor debe tener entre 1 y 50 caracteres.",MinimumLength = 1)]  //Hacemos que sea obligatorio
    [RegularExpression(@"^[A-ZÁÉÍÓÚÜÑ]+[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ0-9\s'-]*$")] //Obligamos que la primera letra del autor sea una mayúscula y que contega el abecedario español completo y numeros.
    public string Autor { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Calificación media")]
    [Precision(3, 2)] //La calificación media puede ir de a 0.00 a 5.00, por lo que establecemos la precisión y escala de la propiedad CalificacionMedia
    public decimal CalificacionMedia { get; set; }

    [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de Lanzamiento")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaLanzamiento { get; set; }

    [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Precio Compra")]
    [Precision(5, 2)] //Establece la precisión y escala de la propiedad PrecioCompra
    public decimal PrecioCompra { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = " Stock")] 
    [Range(0, int.MaxValue, ErrorMessage = "No puede haber una cantidad negativa de un stock")] //Stock minimo 0 y maximo MaxValue
    public int Stock { get; set; }

    [Required(ErrorMessage = "El tipo de libro es obligatorio.")]
    [System.ComponentModel.DataAnnotations.Display(Name = "Tipo de Libro")]
    [StringLength(50, ErrorMessage = "El tipo de libro debe tener entre 1 y 50 caracteres.",MinimumLength = 1)]
    public string? TipoLibro { get; set; } //(p. ej., bolsillo, tapa dura)

    [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Precio Reposición")]
    [Precision(5, 2)] //Establece la precisión y escala de la propiedad PrecioReposicion
    public decimal PrecioReposicion { get; set; }

    //Relaciones
    public Genero Genero { get; set;} //Un libro tiene un unico genero 

    public Editorial Editorial {get; set;} //Un libro le pertenece a una unica editorial

    public IList<CompraItem> CompraItems {get; set;} //Muchos libro se realizan en una compra

    public IList<ReposicionItem> ReposicionItems { get; set; } //Muchos libros pueden estar en una reposición (relación uno a muchos con la clase ReposicionItem)

    public IList<ResenaItem> ResenaItems { get; set; } //Muchos libros pueden tener muchas reseñas (relación uno a muchos con la clase ResenaItem)


    //Métodos que tiene la clase Libro...
}