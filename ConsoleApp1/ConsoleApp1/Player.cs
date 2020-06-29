using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PlayerArea
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class PlayerArea2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ActiveCompetition
    {
        public int id { get; set; }
        public PlayerArea2 area { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string plan { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class Squad
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string countryOfBirth { get; set; }
        public string nationality { get; set; }
        public int? shirtNumber { get; set; }
        public string role { get; set; }
    }

    public class JsonPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
        public int? ShirtNumber { get; set; }
        public string Role { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public class PlayerRootObject
    {
        public int id { get; set; }
        public PlayerArea area { get; set; }
        public List<ActiveCompetition> activeCompetitions { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crestUrl { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public object email { get; set; }
        public int founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
        public List<Squad> squad { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}