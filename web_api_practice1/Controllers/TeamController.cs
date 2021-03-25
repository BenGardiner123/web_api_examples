using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_practice1.Models;

namespace web_api_practice1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TeamController : ControllerBase
    {

        public Team Team { get; set; }
        public List<Team> Teams;

        public TeamController()
        {
            this.Team = new Team();
            this.Teams = new List<Team>();
        }

        [HttpPost("CheckTeam")]
        public IHttpActionResult teamCheck([FromBody] Team team)
        {
            if(this.ModelState.IsValid)
            {
                if (this.Team.checkTeam(team) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return this.BadRequest(this.ModelState);
            }
               
             
        }

        [HttpPost("AddTeam")]
        public string addTeam([FromBody] Team team)
        {
            string message = this.Team.addTeam(team);
            return message;
        }

        [HttpGet("GetTeams")]
        public List<Team> GetTeams()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = nbaLocal; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM TEAM";

            SqlCommand command = new SqlCommand(queryString, con);
            
            con.Open();
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Teams.Add(new Team(reader[0].ToString()));
                }
            }

            return Teams;
        }
    }

}
