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
        public ProductionModel() {}
        public ProductionModel(
            int id, 
            string name, 
            DateTime premiere, 
            string author, 
            int director, 
            string description, 
            string posterFileName, 
            List<PersonModel> actors, 
            List<ProductionEventModel> dates, 
            short duration, 
            string directorName = "",
            bool active = true)
        {
            Id = id;
            Name = name;
            Premiere = premiere;
            Author = author;
            Director = director;
            Description = description;
            PosterFileName = posterFileName;
            Actors = actors;
            Dates = dates;
            Duration = duration;
            Active = active;
            DirectorName = directorName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Premiere { get; set; }
        public string Author { get; set; }
        public int Director { get; set; }
        public string DirectorName { get; set; }
        public string Description { get; set; }
        public string PosterFileName { get; set; }
        public string Scene { get; set; }
        public List<PersonModel> Actors { get; set; } = new List<PersonModel>();
        public List<ProductionEventModel> Dates { get; set; } = new List<ProductionEventModel>();
        public short Duration { get; set; }
        public bool Active { get; set; }
    }
}

