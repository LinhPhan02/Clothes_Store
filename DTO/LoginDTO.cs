using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginDTO
    {
        public string Username { get; set; }

        public string Type { get; set; }
        public string Password { get; set; }
        public string id { get; set; }
        public LoginDTO(string username, string password, string type, string id)
        {
            Username = username;
            Password = password;
            Type = type;
            this.id = id;
        }
    }
}
