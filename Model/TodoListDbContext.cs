using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListEFCore.Model
{
    class TodoListDbContext : DbContext
    {
        //public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        //{ }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server =localhost\\SQLEXPRESS01; DataBase = TodoListDb; Integrated Security = True; TrustServerCertificate = True; ");
              
        }
    }
}
