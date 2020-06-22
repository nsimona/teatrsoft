using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string Mail { get; set; }
        public string Avatar { get; set; }
    }
}
