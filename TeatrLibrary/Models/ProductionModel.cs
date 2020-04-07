using System;
using System.Collections.Generic;
using System.Text;

public struct Plays
{
    public DateTime Date { get; set; }
    public TeatrLibrary.Models.TicketModel Ticket { get; set; }
}

namespace TeatrLibrary.Models
{
    public class ProductionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Premiere { get; set; }
        public string Author { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string PosterFileName { get; set; }
        public string Scene { get; set; }
        public List<PersonModel> Actors { get; set; } = new List<PersonModel>();
        public List<Plays> Dates { get; set; } = new List<Plays>();
        public short Duration { get; set; }
        public bool Active { get; set; }

    }
}

