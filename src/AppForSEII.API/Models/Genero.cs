using System.Runtime.CompilerServices;

namespace AppForSEII.API.Models;


public class Genero
{
    
    //Constructor vacio
    public Genero()
    {
        
    }

    //Constructor con parametros
    public Genero(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    //Clave primaria

    public int Id {get; set;}

    [System.ComponentModel.DataAnnotations.Display(Name = "Genero")]
    [StringLength(50, ErrorMessage = "El genero no puede superar los 50 caracteres.",MinimumLength = 1)] //Hacemos que sea obligatorio
    public string Nombre {get; set;}

    //Relaciones (BDD)
    public IList<Libro> Libros { get; set; }
    
    //Metodos de la clase genero

}