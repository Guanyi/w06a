using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}
