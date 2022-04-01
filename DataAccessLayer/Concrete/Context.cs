using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\Firat;Database=MezunSistemiDb;Trusted_Connection=true;");
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardMap> CardMaps { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Grad> Grads { get; set; }
        public DbSet<GradMap> GradMaps { get; set; }
        public DbSet<GradProfile> GradProfiles { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
    }
}
