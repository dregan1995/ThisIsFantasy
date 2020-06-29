using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UpdatePlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            //UpdateScorer("Richarlison");

            GetMatchEventsRequest("https://apiv2.apifootball.com/?action=get_events&from=2019-10-25&to=2019-10-28&league_id=148&APIkey=73afe1b09f092eae6a96698972db7284d3f224daff1ea418883028c9f442d11c");
            Console.ReadKey();
        }

        async static void GetMatchEventsRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        //Console.WriteLine(myContent);
                        var obj = JsonConvert.DeserializeObject<List<MatchEvents.RootObject>>(myContent);
                        //string jsonString = JsonConvert.SerializeObject(obj);
                        foreach (MatchEvents.RootObject i in obj)
                        {
                            Console.WriteLine(i.match_hometeam_name);
                            Console.WriteLine(i.match_awayteam_name);
                            string lineup = JsonConvert.SerializeObject(i.lineup);
                            var lineupObj = JsonConvert.DeserializeObject<MatchEvents.Lineup>(lineup);
                            List<string> allAwayPlayers = new List<string>();
                            List<string> allHomePlayers = new List<string>();
                            foreach (var player in lineupObj.away.starting_lineups)
                            {
                                allAwayPlayers.Add(player.lineup_player);
                               //if (player.lineup_player.Contains("(C)"))
                                    //player.lineup_player.Substring(0, player.lineup_player.Length - 4);

                                Console.WriteLine(player.lineup_player);
                                var matchEvent = new MatchEvents.MatchEvent
                                {
                                    Starter = true
                                };
                                var json = JsonConvert.SerializeObject(matchEvent);
                                var httpContent = new StringContent(json, Encoding.UTF8,
                                    "application/json");
                                UpdateScorer(player.lineup_player, httpContent);
                                Thread.Sleep(5000);

                            }

                            foreach (var player in lineupObj.away.substitutes)
                            { 
                                allAwayPlayers.Add(player.lineup_player);
                                
                            }

                            foreach (var player in lineupObj.home.starting_lineups)
                            {
                                allHomePlayers.Add(player.lineup_player);
                                var matchEvent = new MatchEvents.MatchEvent

                                {
                                    Starter = true
                                };
                                var json = JsonConvert.SerializeObject(matchEvent);
                                var httpContent = new StringContent(json, Encoding.UTF8,
                                    "application/json");
                                UpdateScorer(player.lineup_player, httpContent);
                                Thread.Sleep(5000);

                            }

                            foreach (var player in lineupObj.home.substitutes)
                            {
                                allHomePlayers.Add(player.lineup_player);
                            }

                            string goalsResult = JsonConvert.SerializeObject(i.goalscorer);
                            var goalObj = JsonConvert.DeserializeObject<List<MatchEvents.goalscorer>>(goalsResult);


                            foreach (var scorer in goalObj)
                            {

                                if (scorer.home_scorer != "")
                                {
                                    string dugLuizId = "238";
                                    string davidLuizId = "208";
                                    string herbieKaneId = "370";
                                    string harryKaneId = "519";
                                    if (scorer.home_scorer == "Kane H. (C)" || scorer.home_scorer == "Kane H." &&
                                        i.match_hometeam_name == "Tottenham")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(harryKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.home_scorer == "Kane H. (C)" || scorer.home_scorer == "Kane H." &&
                                        i.match_awayteam_name != "Tottenham")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(harryKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    

                                    else if (scorer.home_scorer == "Luiz D. (C)" || scorer.home_scorer == "Luiz D." &&
                                        i.match_hometeam_name == "Arsenal")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(davidLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.home_scorer == "Luiz D. (C)" || scorer.home_scorer == "Luiz D." &&
                                       i.match_awayteam_name != "Arsenal")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(davidLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                   

                                    else if (scorer.home_scorer == "Luiz D. (C)" || scorer.home_scorer == "Luiz D." &&
                                             i.match_hometeam_name == "Aston Villa")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(scorer.home_scorer, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.home_scorer == "Luiz D. (C)" || scorer.home_scorer == "Luiz D." &&
                                       i.match_awayteam_name != "Aston Villa")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(dugLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }


                                    else if (scorer.home_scorer == "Kane H. (C)" || scorer.home_scorer == "Kane H." &&
                                        i.match_hometeam_name == "Liverpool")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(herbieKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.home_scorer == "Kane H. (C)" || scorer.home_scorer == "Kane H." &&
                                        i.match_awayteam_name != "Liverpool")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(herbieKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (allHomePlayers.Contains(scorer.home_scorer) || allHomePlayers.Contains(scorer.home_scorer + " (C)"))
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(scorer.home_scorer, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else
                                    {
                                        Console.WriteLine(scorer.home_scorer + "OG");
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(scorer.home_scorer, httpContent);
                                        Thread.Sleep(5000);
                                    }
                                }
                                else if (scorer.away_scorer != "")
                                {
                                    string dugLuizId = "238";
                                    string davidLuizId = "208";
                                    string herbieKaneId = "370";
                                    string harryKaneId = "519";

                                    if (scorer.away_scorer == "Kane H. (C)" || scorer.away_scorer == "Kane H." &&
                                             i.match_awayteam_name == "Tottenham")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(harryKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Kane H. (C)" || scorer.away_scorer == "Kane H." &&
                                        i.match_hometeam_name != "Tottenham")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(harryKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Luiz D. (C)" || scorer.away_scorer == "Luiz D." &&
                                       i.match_awayteam_name == "Arsenal")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(davidLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Luiz D. (C)" || scorer.away_scorer == "Luiz D." &&
                                        i.match_hometeam_name != "Arsenal")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(davidLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Luiz D. (C)" || scorer.away_scorer == "Luiz D." &&
                                        i.match_awayteam_name == "Aston Villa")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(dugLuizId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Luiz D. (C)" || scorer.away_scorer == "Luiz D." &&
                                             i.match_hometeam_name != "Aston Villa")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(dugLuizId, httpContent);
                                        Thread.Sleep(6000);
                                    }

                                    else if (scorer.away_scorer == "Kane H. (C)" || scorer.away_scorer == "Kane H." &&
                                        i.match_awayteam_name == "Liverpool")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(herbieKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (scorer.away_scorer == "Kane H. (C)" || scorer.away_scorer == "Kane H." &&
                                        i.match_hometeam_name != "Liverpool")
                                    {
                                        Console.WriteLine(scorer.home_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(herbieKaneId, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else if (allAwayPlayers.Contains(scorer.away_scorer) || allAwayPlayers.Contains(scorer.away_scorer + " (C)"))
                                    {
                                        Console.WriteLine(scorer.away_scorer);
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 1,
                                            OwnGoals = 0
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(scorer.away_scorer, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                    else
                                    {
                                        Console.WriteLine(scorer.away_scorer + "OG");
                                        var matchEvent = new MatchEvents.MatchEvent

                                        {
                                            Goals = 0,
                                            OwnGoals = 1
                                        };
                                        var json = JsonConvert.SerializeObject(matchEvent);
                                        var httpContent = new StringContent(json, Encoding.UTF8,
                                            "application/json");
                                        UpdateScorer(scorer.away_scorer, httpContent);
                                        Thread.Sleep(5000);
                                    }

                                }
                            }

                        }
                    }
                }
            }
        }

        //else if (allHomePlayers.Contains(scorer.away_scorer))
                        //            {
                        //                Console.WriteLine(scorer.away_scorer + "OG");
                        //                var matchEvent = new MatchEvents.MatchEvent
                        //                {
                        //                    Goals = 0,
                        //                    OwnGoals = 1
                        //                };
                        //                var json = JsonConvert.SerializeObject(matchEvent);
                        //                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                        //                UpdateScorer(scorer.away_scorer, httpContent);
                        //            }
                        //       }
                        //    }

                        //        else if (scorer.home_scorer != null)
                        //        {
                        //            if (allHomePlayers.Contains(scorer.home_scorer))
                        //            {
                        //                Console.WriteLine(scorer.home_scorer);
                        //                var matchEvent = new MatchEvents.MatchEvent
                        //                {
                        //                    Goals = 1,
                        //                    OwnGoals = 0
                        //                };
                        //                var json = JsonConvert.SerializeObject(matchEvent);
                        //                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                        //                UpdateScorer(scorer.home_scorer, httpContent);
                        //            }

                        //            else if (allAwayPlayers.Contains(scorer.home_scorer))
                        //            {
                        //                Console.WriteLine(scorer.home_scorer+ "OG");
                        //                var matchEvent = new MatchEvents.MatchEvent
                        //                {
                        //                    Goals = 0,
                        //                    OwnGoals = 1
                        //                };
                        //                var json = JsonConvert.SerializeObject(matchEvent);
                        //                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                        //                UpdateScorer(scorer.home_scorer, httpContent);
                        //            }

        //                        }
        //                    }

        //                }
        //            }
        //        }
        //    }
        //}

        async static void UpdateScorer(string scorer, HttpContent content)
        {
            //WebRequest request = WebRequest.Create("https://localhost:44324/api/playerstats/?apiName=" + scorer);
            //request.Method = "PUT";
            //request.ContentLength = 0;
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44324/api/playerstats/?apiName=";
                string urlId = url + scorer;
                using (HttpResponseMessage response = await client.PutAsync(urlId, content))
                {
                    Console.WriteLine(content);
                }
            }
        }
    }
}
