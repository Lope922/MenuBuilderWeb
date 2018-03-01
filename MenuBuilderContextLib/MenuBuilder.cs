using System;
using Microsoft.EntityFrameworkCore;
using MenuBuilderEntitesLib;

namespace MenuBuilderContextLib
{
    public class MenuBuilder : DbContext
    {
        public DbSet<Recipe> Recipies { get; set; }
        //public DbSet<FavoritesList> Favs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}

        public MenuBuilder(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipe>()
                .Property(recipe => recipe.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Recipe>()
                .Property(recipe => recipe.Rating);

           
                


        }

    }
}
