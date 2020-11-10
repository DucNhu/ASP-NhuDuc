using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Models
{
    public class TodoContext : DbContext
    //Thua ke DbContext, giup truy cap db, fn + f1
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
