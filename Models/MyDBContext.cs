using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToDoEmptyMVC.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=ToDoEmptyMVCContext")
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}