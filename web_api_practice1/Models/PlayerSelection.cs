using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_practice1.Models
{
	public class PlayerSelection
	{
		public string TeamName { get; set; }
		public int Season { get; set; }
		public int PLAYER_ID { get; set; }
		public string TEAM_ABBREVIATION { get; set; }

		public PlayerSelection(string TeamName_, int Season_, int PLAYER_ID_, string TEAM_ABBREVIATION_)
		{
			this.TeamName = TeamName_;
			this.Season = Season_;
			this.PLAYER_ID = PLAYER_ID_;
			this.TEAM_ABBREVIATION = TEAM_ABBREVIATION_;
		}


	}
}
