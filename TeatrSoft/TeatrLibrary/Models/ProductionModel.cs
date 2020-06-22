using System;
using System.Collections.Generic;

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
            DirectorId = director;
            Description = description;
            Poster = posterFileName;
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
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public List<PersonModel> Actors { get; set; } = new List<PersonModel>();
        public List<ProductionEventModel> Dates { get; set; } = new List<ProductionEventModel>();
        public short Duration { get; set; }
        public bool Active { get; set; }
    }
}

