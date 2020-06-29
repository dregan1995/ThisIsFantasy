using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatePlayers
{
    class MatchEvents
    {
        public class Card
        {
            public string time { get; set; }
            public string home_fault { get; set; }
            public string card { get; set; }
            public string away_fault { get; set; }
        }

        public class Home
        {
            public string time { get; set; }
            public string substitution { get; set; }
        }

        public class Away
        {
            public string time { get; set; }
            public string substitution { get; set; }
        }

        public class Substitutions
        {
            public List<Home> home { get; set; }
            public List<Away> away { get; set; }
        }

        public class StartingLineup
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Substitute
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Coach
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class MissingPlayer
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Home2
        {
            public List<StartingLineup> starting_lineups { get; set; }
            public List<Substitute> substitutes { get; set; }
            public List<Coach> coach { get; set; }
            public List<MissingPlayer> missing_players { get; set; }
        }

        public class StartingLineup2
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Substitute2
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Coach2
        {
            public string lineup_player { get; set; }
            public string lineup_number { get; set; }
            public string lineup_position { get; set; }
        }

        public class Away2
        {
            public List<StartingLineup2> starting_lineups { get; set; }
            public List<Substitute2> substitutes { get; set; }
            public List<Coach2> coach { get; set; }
            public List<object> missing_players { get; set; }
        }

        public class Lineup
        {
            public Home2 home { get; set; }
            public Away2 away { get; set; }
        }

        public class Statistic
        {
            public string type { get; set; }
            public string home { get; set; }
            public string away { get; set; }
        }

        public class goalscorer
        {
            public string time { get; set; }
            public string home_scorer { get; set; }
            public string score { get; set; }
            public string away_scorer { get; set; }

        }
        public class RootObject
        {
            public string match_id { get; set; }
            public string country_id { get; set; }
            public string country_name { get; set; }
            public string league_id { get; set; }
            public string league_name { get; set; }
            public string match_date { get; set; }
            public string match_status { get; set; }
            public string match_time { get; set; }
            public string match_hometeam_id { get; set; }
            public string match_hometeam_name { get; set; }
            public string match_hometeam_score { get; set; }
            public string match_awayteam_name { get; set; }
            public string match_awayteam_id { get; set; }
            public string match_awayteam_score { get; set; }
            public string match_hometeam_halftime_score { get; set; }
            public string match_awayteam_halftime_score { get; set; }
            public string match_hometeam_extra_score { get; set; }
            public string match_awayteam_extra_score { get; set; }
            public string match_hometeam_penalty_score { get; set; }
            public string match_awayteam_penalty_score { get; set; }
            public string match_hometeam_system { get; set; }
            public string match_awayteam_system { get; set; }
            public string match_live { get; set; }
            public List<object> goalscorer { get; set; }
            public List<Card> cards { get; set; }
            public Substitutions substitutions { get; set; }
            public Lineup lineup { get; set; }
            public List<Statistic> statistics { get; set; }
        }

        public class MatchEvent
        {
            public int Goals { get; set; }
            public int OwnGoals { get; set; }
            public bool Starter { get; set; }
        }
    }
}
