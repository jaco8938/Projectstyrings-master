using ConnectToDB2017_C06;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectstyrings.Data_Access_Layer
{
    class Database_Access
    {
        SqlConnection con = new SqlConnection(DBController.connectionstring);
        List<Profile> GetProfiles()
        {
            List<Profile> resultat = new List<Profile>();
            
            {
                try
                {
                    con.Open();

                    SqlCommand command1 = new SqlCommand("GetProfiles", con);
                    command1.CommandType = CommandType.StoredProcedure;

                    SqlDataReader readerForCommand1 = command1.ExecuteReader();

                    if (readerForCommand1.HasRows)
                    {
                        while (readerForCommand1.Read())
                        {
                            string ProfileId = readerForCommand1["ProfileId"].ToString(); ;
                            string ProfileName = readerForCommand1["ProfileName"].ToString(); ;
                            string ProfilePhone = readerForCommand1["ProfilePhone"].ToString(); ;
                            string ProfileEmail = readerForCommand1["ProfileEmail"].ToString(); ;
                            string ProfileCompanyOrSchool = readerForCommand1["ProfileCompanyOrSchool"].ToString(); ;
                            //User constructorens navn skal ændres til profile. Det skal også rettes her forneden.
                            // Det der er i User skal være konsistens med det der er i constructoren. Både med navn og rækkefølge
                            Profile x = new Profile(ProfileName, ProfilePhone, ProfileEmail, ProfileCompanyOrSchool);
                            resultat.Add(x);
                        }
                    }
                }
                catch (SqlException error)
                {
                    Console.WriteLine("UPS" + error.Message);
                }
            }
            return resultat;
        }

        public List<Project> GetProjects()
        {
            try
            {
                con.Open();

                SqlCommand command2 = new SqlCommand("GetProjects", con);
                command2.CommandType = CommandType.StoredProcedure;

                SqlDataReader readerForCommand2 = command2.ExecuteReader();

                if (readerForCommand2.HasRows)
                {
                    while (readerForCommand2.Read())
                    {
                        string ProjectId = readerForCommand2["ProjectId"].ToString(); ;
                        string ProjectName = readerForCommand2["ProjectName"].ToString(); ;
                        string ProjectDescription = readerForCommand2["ProjectDescription"].ToString(); ;
                        Console.WriteLine(ProjectId + " " + ProjectName + " " + ProjectDescription);
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine("UPS" + error.Message);
            }

        }
    }
}
