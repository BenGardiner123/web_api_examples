
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_practice1.Models
{
    public class Team
    {
       
        [JsonProperty("TeamName")]
        public string TeamName { get; set; }


        public Team()
        {
            this.TeamName = " ";
        }

        public Team(string teamName)
        {
            TeamName = teamName;
            var check = 0;

        }


        public Team checkTeam(Team t)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = nbaLocal; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM TEAM WHERE TeamName = @team";

            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@team", t.TeamName);
            Team found = null;

            try
            {
                con.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        found = new Team(reader[0].ToString());
                    }
                }
           
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return found;
        }

        public string addTeam(Team t)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = nbaLocal; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection(connectionString);

            string queryString = "insert into TEAM (TeamName) values (@team)";

            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@team", t.TeamName);
            con.Open();
            int result = command.ExecuteNonQuery();

            //here we check for errrors
            if (result < 0)
            {
                return "failed to add your Team";
            }
            else
            {
                return "Successfully added your Team";
            }

        }



    }
}
