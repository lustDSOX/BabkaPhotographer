using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1.DataBaseClasses
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Contrpartner> Contrpartners { get; set; } = null!;
        public DbSet<Role> Roles{ get; set; } = null!;
        public DbSet<Service> Services{ get; set; } = null!;
        public DbSet<User> Users{ get; set; } = null!;
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ngknn.ru;Database=BabkaPhotographer;User Id=33П;Password=12357;");
        }
    }
}
