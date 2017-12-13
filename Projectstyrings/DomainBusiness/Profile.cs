using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    public class Profile
    {
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string tlf { get; set; }

        public Profile(string profileName, string profileAddress = null, string profileEmail = null, string profileTelephone = null)
        {
            name = profileName;
            //password = userPassword;
            email = profileEmail;
            tlf = profileTelephone;
        }
    }
}