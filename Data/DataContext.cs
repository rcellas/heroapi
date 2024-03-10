using HeroApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroApi.Data;

public class DataContext: DbContext
{
    // DbSet es una colección de datos que vamos a tener en nuestra base de datos
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    // SuperHeroes es el nombre de la tabla que vamos a tener en nuestra base de datos
    // conecta a nuestra base de datos con la entidad SuperHero
    public DbSet<SuperHero> SuperHeroes {get; set;}
}