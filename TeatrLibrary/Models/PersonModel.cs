using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        //public byte[] Photo { get; set; }
        public string Photo { get; set; }
        public bool Active{ get; set; }
        public bool isActorAvailable (int actorId, DateTime start, short duration)
        {
            //check if role==actor
            return true;
        }
        public PersonModel() { }
        public PersonModel(string name, int position = 0, int id = 0, string phone="", string mail="", string photo = "default_actor.jpg", bool active=true)
        {
            /*if(name != "")
            {
                return;
            } 
            if(position != "")
            {
                return;
            }*/
            Name = name;
            Position = position;
            Id = id;
            Phone = phone;
            Mail = mail;
            Photo = photo;
            Active = active;
        }
    }
}
