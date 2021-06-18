using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._1.Models
{
    public partial class Session
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public int FilmId { get; set; }
        public int HallNumber { get; set; }
        public int FreeSeat { get; set; }
        public DateTime Sdate { get; set; }
        public decimal Price { get; set; }

        public virtual Cinema Cinema { get; set; }
        public virtual Film Film { get; set; }
    }
}
