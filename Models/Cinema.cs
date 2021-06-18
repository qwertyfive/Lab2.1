using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._1.Models
{
    public partial class Cinema
    {
        public Cinema()
        {
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
