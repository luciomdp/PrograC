using Microsoft.EntityFrameworkCore;
using PizzaStore.Model;

namespace PizzaStore.Model
/*
La clase Pizza anterior es un objeto simple que representa una pizza. 
Este código es el modelo de datos. 
Más adelante, usará Entity Framework (EF) Core para asignar este modelo 
de datos a una tabla de base de datos.
*/
{
    public class Pizza
    {
          public int Id { get; set; }
          public string? Name { get; set; }
          public string? Description { get; set; }
    }
}
class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}
