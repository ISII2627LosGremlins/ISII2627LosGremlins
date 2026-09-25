namespace AppForSEII.API.Models;

public class Libro
{
    //Constructor vacio 
    public Libro() 
    {
    }

    //Constructor de la clase con sus atributos
    public Libro(int id,string titulo,string autor,DateTime fechaLanzamiento,decimal precioCompra,int stock)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        FechaLanzamiento = fechaLanzamiento;
        PrecioCompra = precioCompra;
        Stock = stock;
    }

        // Clave primaria (ID)
        public int Id { get; set; }
        
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public DateTime FechaLanzamiento { get; set; }

        public decimal PrecioCompra { get; set; }

        public int Stock { get; set; }

        //Hay que añadir las lineas para la BD y los Display??

        //Métodos que tiene la clase Libro...
}