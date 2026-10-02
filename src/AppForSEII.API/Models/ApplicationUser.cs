using Microsoft.AspNetCore.Identity;

namespace AppForSEII.API.Models;

public class ApplicationUser 
{
    public ApplicationUser()
    {
    }
    public ApplicationUser(int id, string name, string surname, string direccion, string telefono)
    {
       Id = id;
       Name = name;
       Surname = surname;
       Direccion = direccion;
       Telefono = telefono;

    }

    //Propiedades
    [Key]
    public int Id { get; set; }

    [Required]
    [System.ComponentModel.DataAnnotations.Display(Name = "Nombre")]
    [StringLength(30, ErrorMessage = "El nombre no puede superar los 50 caracteres.",MinimumLength = 1)] //Hacemos que sea obligatorio
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //Obligamos que la primera letra del título sea una mayúscula
    public string Name{ get; set;}

    [Required]
    [System.ComponentModel.DataAnnotations.Display(Name = "Apellidos")]
    [StringLength(40, ErrorMessage = "Los apellidos no pueden superar los 50 caracteres.",MinimumLength = 1)] //Hacemos que sea obligatorio
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")] //Obligamos que la primera letra del título sea una mayúscula
    public string Surname { get; set;}

    [Required]
    [System.ComponentModel.DataAnnotations.Display(Name = "Direccion")]
    [StringLength(60, ErrorMessage = "La dirección no puede superar los 50 caracteres.",MinimumLength = 1)] //Hacemos que sea obligatorio
    public string Direccion {get; set;}

    [Required]
    [System.ComponentModel.DataAnnotations.Display(Name = "Telefono")]
    [Phone] //Comprueba que tenga un formato de teléfono válido.
    [StringLength(9, MinimumLength = 9, ErrorMessage = "El teléfono debe tener 9 numeros.")]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "El número de teléfono solo puede contener números.")]
    public string Telefono { get; set;}

    //Relaciones (BDD)
    public IList<Resena> Resenas { get; set; }

    public IList<Compra> Compras {get; set;}
    
    public IList<Reposicion> Reposiciones { get; set; }

}
