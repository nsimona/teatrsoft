using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Photo { get; set; }
        public bool Active { get; set; }
        public PersonModel() {}
        public PersonModel(
            string name, 
            int position = 0, 
            int id = 0, 
            string phone = "", 
            string mail = "", 
            string photo = "default_actor.jpg", 
            bool active = true)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Mail = mail;
            PositionId = position;
            Photo = photo;
            Active = active;
        }
    }
}
