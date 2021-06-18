using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab2._1.Models
{
    public class Lab2CinemaContext : DbContext
    {
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }

        public Lab2CinemaContext(DbContextOptions<Lab2CinemaContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
