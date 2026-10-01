using AppForSEII.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppForSEII.API.DTOs.ApplicationUserDTO;
using Microsoft.EntityFrameworkCore.Internal;

namespace AppForSEII.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);


    }


    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    //¿Añadir propiedad para la clase Reposicion?
    public DbSet<Reposicion> Reposiciones { get; set; }

    public DbSet<Resena> Resenas { get; set; }
    
    public DbSet<Libro> Libros { get; set; }

    public DbSet<Compra> Compras { get; set;}

    public DbSet<ResenaItem> ResenaItems { get; set; }

    public DbSet<ReposicionItem> ReposicionItems { get; set; }

    public DbSet<Editorial> Editoriales { get; set; }

    public DbSet<Genero> Genero { get; set;}

    public DbSet<CompraItem> CompraItem { get; set;}

    public DbSet<MetodoPago> MetodoPagos { get; set; }
}