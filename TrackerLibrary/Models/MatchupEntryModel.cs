using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel



    {
        /// <summary>
        /// Represents one team in the mactchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent Score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents matchup from this came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
