using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Menu.Models.Tables;

namespace Menu.Models.Tables
{
    public class MenuContext : DbContext
    {

        public DbSet<TbSubMenu> TbSubMenus { get; set; }
        public DbSet<TbProduct> TbMenus { get; set; }
        public MenuContext() : base("DbConectionString")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbSubMenu>().HasMany(c => c.TbProducts)
                .WithMany(s => s.TbSubMenus)
                .Map(t => t.MapLeftKey("")
                .MapRightKey("")
                .ToTable(""));
        }
        
            //modelBuilder.Entity<Course>().HasMany(c => c.Students)
            //    .WithMany(s => s.Courses)
            //    .Map(t => t.MapLeftKey("CourseId")
            //    .MapRightKey("StudentId")
            //    .ToTable("CourseStudent"));
        
    }
}