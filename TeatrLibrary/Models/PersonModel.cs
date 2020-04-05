using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
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
        public PersonModel(string name, string position, string phone="", string mail="", string photo = null, bool active=true)
        {
            if(name != "")
            {
                Name = name;
                return;
            } 
            if(position != "")
            {
                Position = position;
                return;
            }
            Phone = phone;
            Mail = mail;
            Photo = photo;
            Active = active;
        }
    }
}
