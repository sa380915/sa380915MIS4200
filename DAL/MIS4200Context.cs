using sa380915MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace sa380915MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, sa380915MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            
        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }


        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.Student> Student { get; set; }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.Course> Course { get; set; }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.Grade> Grade { get; set; }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.customer> Customer { get; set; }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.Orders> Order { get; set; }

        public System.Data.Entity.DbSet<sa380915MIS4200.Models.Product> Product { get; set; }
        public System.Data.Entity.DbSet<sa380915MIS4200.Models.OrderDetail> OrderDetail { get; set; }


    }
}