using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._1.Models
{
    public partial class Film
    {
        public Film()
        {
            FilmActors = new HashSet<FilmActor>();
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Director { get; set; }
        public int Minutes { get; set; }
        public int Value { get; set; }
        public string StudioName { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<FilmActor> FilmActors { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
