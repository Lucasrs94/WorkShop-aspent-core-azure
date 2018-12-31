
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace FilmesCRUDRazor.Models
{
       public class FilmeContxt : DbContext
    {
    
      public FilmeContxt(DbContextOptions<FilmeContxt> options)
      : base(options)
      {
    

    //Default
      }
      
       public DbSet<Filme> Filme { get; set; }
    }

}

