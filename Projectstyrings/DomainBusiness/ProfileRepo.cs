using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings
{
    class UserRepo
    {
        private List<Profile> profiles = new List<Profile>();

        //public void RegisterPlayer(Profile user)
        //{
        //    players.Add(user);
        //}

        //public void RegisterPlayer(string name, string password = null, string email = null, string telephone = null)
        //{
        //    Profile newProfile = new Profile(name, password, email, telephone);
        //    RegisterProfile(newProfile);
        //}

        public Profile GetProfile(string name)
        {
            Profile foundProfile = null;
            int idx = 0;
            while ((foundProfile == null) && (idx < profiles.Count))
            {
                if (profiles[idx].name.Equals(name))
                {
                    foundProfile = profiles[idx];
                }
                idx++;
            }
            return foundProfile;
        }
    }
}
