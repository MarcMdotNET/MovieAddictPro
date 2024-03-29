﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieAddictPro.Models.Database;

namespace MovieAddictPro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Collection> Collection { get; set; } = default!;
        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<MovieCollection> MovieCollection { get; set; } = default!;
    }
}