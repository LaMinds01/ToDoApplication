using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Data.Models;

namespace ToDoApplication.Data.Context
{
    

    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options)
        {
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}
