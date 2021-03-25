using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_practice1.Models
{
    public class NBAPlayer
    {
        public int Season { get; set; }
		public int PLAYER_ID { get; set; }
		public string PLAYER_NAME { get; set; }
		public string TEAM_ABBREVIATION { get; set; }
		public int AGE { get; set; }
		public int GP { get; set; }
		public int W { get; set; }
		public int L { get; set; }
		public decimal W_PCT { get; set; }
		public decimal MINS { get; set; }
		public decimal FGM { get; set; }
		public decimal FGA { get; set; }
		public decimal FG_PCT { get; set; }
		public decimal FG3M { get; set; }
		public decimal FG3A { get; set; }
		public decimal FG3_PCT { get; set; }
		public decimal FTM { get; set; }
		public decimal FTA { get; set; }
		public decimal FT_PCT { get; set; }
		public decimal OREB { get; set; }
		public decimal DREB { get; set; }
		public decimal REB { get; set; }
		public decimal AST { get; set; }
		public decimal TOV { get; set; }
		public decimal STL { get; set; }
		public decimal BLK { get; set; }
		public decimal BLKA { get; set; }
		public decimal PF { get; set; }
		public decimal PFD { get; set; }
		public decimal PTS { get; set; }
		public decimal PLUS_MINUS { get; set; }
		public decimal NBA_FANTASY_PTS { get; set; }

        public NBAPlayer()
		{

		}


	}

   
}
