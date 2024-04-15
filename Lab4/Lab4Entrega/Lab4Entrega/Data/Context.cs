using Lab4Entrega.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Lab4Entrega.Data
{
    public class Context : DbContext
    {


        public Context(DbContextOptions<Context> options)
         : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
