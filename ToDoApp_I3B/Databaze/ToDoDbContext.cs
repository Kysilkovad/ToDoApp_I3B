using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_I3B.Model;

namespace ToDoApp_I3B.Databaze
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ToDoDb.db");
        }
    }
}
