using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MoviesUI.Data;
using MoviesUI.Controllers;
using MoviesUI.Models;

namespace MoviesUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MoviesUI.Data.Movie> Movie { get; set; }
        public DbSet<MoviesUI.Data.Actor> Actor { get; set; }
        public DbSet<MoviesUI.Controllers.actors> actors { get; set; }
        public DbSet<MoviesUI.Models.Rating> Rating { get; set; }
    }
}
