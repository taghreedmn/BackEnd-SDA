using backend.src.Entity;
using Microsoft.EntityFrameworkCore;

namespace backend.src.Database
{

  public class DatabaseContxt : DbContext
  {
   // Order
   public DbSet<Order> Order { get; set; }
   
   public DatabaseContxt (DbContextOptions options) : base (options)
   {
    
   }
   

  }
}