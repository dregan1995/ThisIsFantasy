using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string apiKey = "";
            //UpdateOther("http://api.football-data.org/v2/teams/", apiKey);
            //UpdateSheffieldPlayers("http://api.football-data.org/v2/teams/", apiKey);
            //UpdatePlayers("http://api.football-data.org/v2/teams/");
            UpdateTeam("https://api.football-data.org/v2/competitions/2021/teams/");
            //GetRequest("https://api.football-data.org/v2/competitions/2021/teams/");
            //GetPlayers("https://api.football-data.org/v2/competitions/2021/teams/");
            //Serialize();
            //PostPayers("http://api.football-data.org/v2/teams/");
            //PostSheffieldPayers("http://api.football-data.org/v2/teams/");
            //PostOtherPayers("http://api.football-data.org/v2/teams/");
            Console.ReadKey();
        }


        async static void UpdateTeam(string url)
        {
            string apiKey = "";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(myContent);
                        foreach (Team i in obj.teams)
                        {
                            CultureInfo enUs = new CultureInfo("en-Us");
                            string dateString, format;
                            dateString = "23/10/2018 13:40:54";
                            format = "dd/MM/yyyy HH:mm:ss";
                            DateTime dateResult;
                            dateResult = DateTime.ParseExact(dateString, format, enUs);
                            if (i.lastUpdated > dateResult)
                            {
                                Console.WriteLine("Last updated more than current date");
                                Console.WriteLine(i.name);
                                string now = DateTime.Now.ToString();
                                var jsonTeam = new JsonTeam
                                {
                                    Id = i.id,
                                    Name = i.name,
                                    Venue = i.venue,
                                    ClubColors = i.clubColors,
                                    LastUpdated = DateTime.ParseExact(now, format, enUs)
                                };
                                var json = JsonConvert.SerializeObject(jsonTeam);
                                Console.WriteLine(json);
                                string result = "";
                                using (var client1 = new WebClient())
                                {
                                    url = "https://localhost:44324/api/teams/";
                                    string urlId = url + i.id;
                                    Console.WriteLine(urlId);
                                    client1.Headers[HttpRequestHeader.ContentType] = "application/json";
                                    result = client1.UploadString(urlId, "PUT", json);
                                }
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Last updated less than current date");
                            }
                        }
                    }
                }
            }
        }

        async static void GetRequest(string url)
        {
            string apiKey = "";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(myContent);
                        
                        CultureInfo enUs = new CultureInfo("en-Us");
                        string format = "dd/MM/yyyy HH:mm:ss";
                        foreach (Team i in obj.teams)
                        {
                            Console.WriteLine(i.name);
                            string now = DateTime.Now.ToString();
                            var jsonTeam = new JsonTeam
                            {
                                Id = i.id,
                                Name = i.name,
                                Venue = i.venue,
                                ClubColors = i.clubColors,
                                LastUpdated = DateTime.ParseExact(now, format, enUs)
                            };
                            var json = JsonConvert.SerializeObject(jsonTeam);
                            Console.WriteLine(json);
                            string result = "";
                            using (var client1 = new WebClient())
                            {
                                url = "https://localhost:44324/api/teams";
                                client1.Headers[HttpRequestHeader.ContentType] = "application/json";
                                result = client1.UploadString(url, "POST", json);
                            }
                            Console.WriteLine(result);
                        }
                    }
                }
            }
        }



        //async static void PostPayers(string url)
        //{
        //    int[] ids = new int[16];
        //    ids[0] = 57;
        //    ids[1] = 58;
        //    ids[2] = 61;
        //    ids[3] = 62;
        //    ids[4] = 64;
        //    ids[5] = 65;
        //    ids[6] = 66;
        //    ids[7] = 67;
        //    ids[8] = 68;
        //    ids[9] = 73;
        //    ids[10] = 328;
        //    ids[11] = 338;
        //    ids[12] = 340;
        //    ids[13] = 346;
        //    ids[14] = 354;
        //    ids[15] = 563;
        //    foreach (var i in ids)
        //    {
        //        if (i == 64 || i == 68 || i == 340)
        //        {
        //            Thread.Sleep(60000);
        //        }
        //        using (HttpClient playerClient = new HttpClient())
        //        {
        //            playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
        //                "3e52cb846b084e36936563b2c697d593");
        //            string newurl = String.Format(url + i.ToString());
        //            Console.WriteLine(newurl);
        //            using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
        //            {
        //                using (HttpContent playerContent = playerResponse.Content)
        //                {
        //                    string myPlayerContent = await playerContent.ReadAsStringAsync();
        //                    PlayerRootObject obj1 = JsonConvert.DeserializeObject<PlayerRootObject>(myPlayerContent);

        //                    CultureInfo enUs = new CultureInfo("en-Us");
        //                    string format = "dd/MM/yyyy HH:mm:ss";
        //                    foreach (Squad s in obj1.squad)
        //                    {
        //                        string now = DateTime.Now.ToString();
        //                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44324/api/players");
        //                        httpWebRequest.ContentType = "application/json; charset=utf-8";
        //                        httpWebRequest.Method = "POST";

        //                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //                        {
        //                            var jsonPlayer = new JsonPlayer
        //                            {
        //                                Id = s.id,
        //                                Name = s.name,
        //                                TeamId = i
        //                                //Position = s.position,
        //                                //DateOfBirth = s.dateOfBirth,
        //                                //CountryOfBirth = s.countryOfBirth,
        //                                //Nationality = s.nationality,
        //                                //ShirtNumber = s.shirtNumber,
        //                                //Role = s.role,
        //                                //playerApiId = s.id,
        //                                //LastUpdate = DateTime.ParseExact(now, format, enUs)
        //                            };
        //                            string json = JsonConvert.SerializeObject(jsonPlayer);
        //                            Console.WriteLine(json);
        //                            Debug.Write(json);
        //                            streamWriter.Write(json);
        //                            streamWriter.Flush();
        //                            streamWriter.Close();
        //                        }
        //                        try
        //                        {
        //                            using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
        //                            {
        //                                if (httpWebRequest.HaveResponse && response != null)
        //                                {
        //                                    using (var reader = new StreamReader(response.GetResponseStream()))
        //                                    {
        //                                        string result = reader.ReadToEnd();
        //                                        Console.WriteLine(result);
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        catch (WebException e)
        //                        {
        //                            if (e.Response != null)
        //                            {
        //                                using (var errorResponse = (HttpWebResponse)e.Response)
        //                                {
        //                                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
        //                                    {
        //                                        string error = reader.ReadToEnd();
        //                                        string result = error;
        //                                    }
        //                                }

        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //async static void PostSheffieldPayers(string url)
        //{
        //    int[] bids = new int[1];
        //    bids[0] = 356; //Sheffield does not work
        //    foreach (var i in bids)
        //    {
        //        using (HttpClient playerClient = new HttpClient())
        //        {
        //            playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
        //                "3e52cb846b084e36936563b2c697d593");
        //            string newurl = String.Format(url + i.ToString());
        //            Console.WriteLine(newurl);
        //            using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
        //            {
        //                using (HttpContent playerContent = playerResponse.Content)
        //                {
        //                    string myPlayerContent = await playerContent.ReadAsStringAsync();
        //                    SheffieldUnited.RootObject obj1 = JsonConvert.DeserializeObject<SheffieldUnited.RootObject>(myPlayerContent);
        //                    foreach (SheffieldUnited.Squad s in obj1.squad)
        //                    {
        //                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44324/api/players");
        //                        httpWebRequest.ContentType = "application/json; charset=utf-8";
        //                        httpWebRequest.Method = "POST";

        //                        CultureInfo enUs = new CultureInfo("en-Us");
        //                        string format = "dd/MM/yyyy HH:mm:ss";
        //                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //                        {
        //                            string now = DateTime.Now.ToString();
        //                            var jsonPlayer = new JsonPlayer
        //                            {

        //                                Id = s.id,
        //                                Name = s.name,
        //                                TeamId = i,
        //                                //Position = s.position,
        //                                //DateOfBirth = s.dateOfBirth,
        //                                //CountryOfBirth = s.countryOfBirth,
        //                                //Nationality = s.nationality,
        //                                //ShirtNumber = s.shirtNumber,
        //                                //Role = s.role,
        //                                //playerApiId = s.id,
        //                                //LastUpdate = DateTime.ParseExact(now, format, enUs)
        //                            };
        //                            string json = JsonConvert.SerializeObject(jsonPlayer);
        //                            Console.WriteLine(json);
        //                            Debug.Write(json);
        //                            streamWriter.Write(json);
        //                            streamWriter.Flush();
        //                            streamWriter.Close();
        //                        }
        //                        try
        //                        {
        //                            using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
        //                            {
        //                                if (httpWebRequest.HaveResponse && response != null)
        //                                {
        //                                    using (var reader = new StreamReader(response.GetResponseStream()))
        //                                    {
        //                                        string result = reader.ReadToEnd();
        //                                        Console.WriteLine(result);
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        catch (WebException e)
        //                        {
        //                            if (e.Response != null)
        //                            {
        //                                using (var errorResponse = (HttpWebResponse)e.Response)
        //                                {
        //                                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
        //                                    {
        //                                        string error = reader.ReadToEnd();
        //                                        string result = error;
        //                                    }
        //                                }

        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }


        //    }
        //}

        async static void PostOtherPayers(string url)
        {
            string apiKey = "";
            int[] bids = new int[3];
            bids[0] = 1044; //Bournemouth does not work
            bids[1] = 68; //Norwich does not work
            bids[2] = 397; //Brighton does not work
            foreach (var i in bids)
            {
                using (HttpClient playerClient = new HttpClient())
                {
                    playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
                        apiKey);
                    string newurl = String.Format(url + i.ToString());
                    Console.WriteLine(newurl);
                    using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
                    {
                        using (HttpContent playerContent = playerResponse.Content)
                        {
                            string myPlayerContent = await playerContent.ReadAsStringAsync();
                            OtherPlayers.RootObject obj1 = JsonConvert.DeserializeObject<OtherPlayers.RootObject>(myPlayerContent);
                            foreach (OtherPlayers.Squad s in obj1.squad)
                            {
                                CultureInfo enUs = new CultureInfo("en-Us");
                                string format = "dd/MM/yyyy HH:mm:ss";
                                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44324/api/players");
                                httpWebRequest.ContentType = "application/json; charset=utf-8";
                                httpWebRequest.Method = "POST";
                                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                                {
                                    string now = DateTime.Now.ToString();
                                    var jsonPlayer = new OtherPlayers.JsonPlayer
                                    {
                                        Id = s.id,
                                        Name = s.name,
                                        TeamId = i
                                        //Position = s.position,
                                        //DateOfBirth = s.dateOfBirth,
                                        //CountryOfBirth = s.countryOfBirth,
                                        //Nationality = s.nationality,
                                        //ShirtNumber = s.shirtNumber,
                                        //Role = s.role,
                                        //playerApiId = s.id,
                                        //LastUpdate = DateTime.ParseExact(now, format, enUs)
                                    };
                                    string json = JsonConvert.SerializeObject(jsonPlayer);
                                    Console.WriteLine(json);
                                    Debug.Write(json);
                                    streamWriter.Write(json);
                                    streamWriter.Flush();
                                    streamWriter.Close();
                                }
                                try
                                {
                                    using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
                                    {
                                        if (httpWebRequest.HaveResponse && response != null)
                                        {
                                            using (var reader = new StreamReader(response.GetResponseStream()))
                                            {
                                                string result = reader.ReadToEnd();
                                                Console.WriteLine(result);
                                            }
                                        }
                                    }
                                }
                                catch (WebException e)
                                {
                                    if (e.Response != null)
                                    {
                                        using (var errorResponse = (HttpWebResponse)e.Response)
                                        {
                                            using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                                            {
                                                string error = reader.ReadToEnd();
                                                string result = error;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }


            }
        }

        async static void UpdatePlayers(string url)
        {
            string apiKey = "";
            int[] ids = new int[16];
            ids[0] = 57;
            ids[1] = 58;
            ids[2] = 61;
            ids[3] = 62;
            ids[4] = 64;
            ids[5] = 65;
            ids[6] = 66;
            ids[7] = 67;
            ids[8] = 68;
            ids[9] = 73;
            ids[10] = 328;
            ids[11] = 338;
            ids[12] = 340;
            ids[13] = 346;
            ids[14] = 354;
            ids[15] = 563;
            foreach (var i in ids)
            {
                if (i == 64 || i == 68 || i == 340)
                    Thread.Sleep(60000);


                using (HttpClient playerClient = new HttpClient())
                {
                    playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
                        apiKey);
                    string newurl = String.Format(url + i.ToString());
                    Console.WriteLine(newurl);
                    using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
                    {
                        using (HttpContent playerContent = playerResponse.Content)
                        {
                            string myPlayerContent = await playerContent.ReadAsStringAsync();
                            PlayerRootObject obj1 = JsonConvert.DeserializeObject<PlayerRootObject>(myPlayerContent);
                            CultureInfo enUs = new CultureInfo("en-Us");
                            string dateString, format;
                            dateString = "24/10/2019 14:12:46";
                            format = "dd/MM/yyyy HH:mm:ss";
                            DateTime dateResult = DateTime.ParseExact(dateString, format, enUs);
                            if (obj1.lastUpdated > dateResult)
                            {
                                foreach (Squad s in obj1.squad)
                                {
                                    {

                                        HttpWebRequest httpWebRequest =
                                            (HttpWebRequest)WebRequest.Create("https://localhost:44324/api/players/" + s.id);
                                        Console.WriteLine(httpWebRequest);
                                        httpWebRequest.ContentType = "application/json; charset=utf-8";
                                        httpWebRequest.Method = "PUT";

                                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                                        {
                                            string now = DateTime.Now.ToString();
                                            var jsonPlayer = new JsonPlayer
                                            {
                                                Id = s.id,
                                                Name = s.name,
                                                Position = s.position,
                                                DateOfBirth = s.dateOfBirth,
                                                CountryOfBirth = s.countryOfBirth,
                                                Nationality = s.nationality,
                                                ShirtNumber = s.shirtNumber,
                                                Role = s.role,
                                                TeamId = i,
                                                LastUpdated = DateTime.ParseExact(now, format, enUs)
                                            };
                                            string json = JsonConvert.SerializeObject(jsonPlayer);
                                            Console.WriteLine(json);
                                            Debug.Write(json);
                                            streamWriter.Write(json);
                                            streamWriter.Flush();
                                            streamWriter.Close();
                                        }

                                        try
                                        {
                                            using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
                                            {
                                                if (httpWebRequest.HaveResponse && response != null)
                                                {
                                                    using (var reader = new StreamReader(response.GetResponseStream()))
                                                    {
                                                        string result = reader.ReadToEnd();
                                                        Console.WriteLine(result);
                                                    }
                                                }
                                            }
                                        }
                                        catch (WebException e)
                                        {
                                            if (e.Response != null)
                                            {
                                                using (var errorResponse = (HttpWebResponse)e.Response)
                                                {
                                                    using (var reader =
                                                        new StreamReader(errorResponse.GetResponseStream()))
                                                    {
                                                        string error = reader.ReadToEnd();
                                                        string result = error;
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Last updated less than current date");
                            }
                        }
                    }
                }
            }
        }

        async static void UpdateSheffieldPlayers(string url, string apiKey)
        {
            int[] ids = new int[1];
            ids[0] = 356;
            foreach (var i in ids)


                using (HttpClient playerClient = new HttpClient())
                {
                    playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
                        apiKey);
                    string newurl = String.Format(url + i.ToString());
                    Console.WriteLine(newurl);
                    using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
                    {
                        using (HttpContent playerContent = playerResponse.Content)
                        {
                            string myPlayerContent = await playerContent.ReadAsStringAsync();
                            SheffieldUnited.RootObject obj1 = JsonConvert.DeserializeObject<SheffieldUnited.RootObject>(myPlayerContent);
                            CultureInfo enUs = new CultureInfo("en-Us");
                            string dateString, format;
                            dateString = "24/10/2019 14:12:46";
                            format = "dd/MM/yyyy HH:mm:ss";
                            DateTime dateResult = DateTime.ParseExact(dateString, format, enUs);
                            if (obj1.lastUpdated > dateResult)
                            {
                                foreach (SheffieldUnited.Squad s in obj1.squad)
                                {
                                    {

                                        HttpWebRequest httpWebRequest =
                                            (HttpWebRequest)WebRequest.Create("https://localhost:44324/api/players/" + s.id);
                                        Console.WriteLine(httpWebRequest);
                                        httpWebRequest.ContentType = "application/json; charset=utf-8";
                                        httpWebRequest.Method = "PUT";

                                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                                        {
                                            string now = DateTime.Now.ToString();
                                            var jsonPlayer = new JsonPlayer
                                            {
                                                Id = s.id,
                                                Name = s.name,
                                                Position = s.position,
                                                DateOfBirth = s.dateOfBirth,
                                                CountryOfBirth = s.countryOfBirth,
                                                Nationality = s.nationality,
                                                ShirtNumber = s.shirtNumber,
                                                Role = s.role,
                                                TeamId = i,
                                                LastUpdated = DateTime.ParseExact(now, format, enUs)
                                            };
                                            string json = JsonConvert.SerializeObject(jsonPlayer);
                                            Console.WriteLine(json);
                                            Debug.Write(json);
                                            streamWriter.Write(json);
                                            streamWriter.Flush();
                                            streamWriter.Close();
                                        }

                                        try
                                        {
                                            using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
                                            {
                                                if (httpWebRequest.HaveResponse && response != null)
                                                {
                                                    using (var reader = new StreamReader(response.GetResponseStream()))
                                                    {
                                                        string result = reader.ReadToEnd();
                                                        Console.WriteLine(result);
                                                    }
                                                }
                                            }
                                        }
                                        catch (WebException e)
                                        {
                                            if (e.Response != null)
                                            {
                                                using (var errorResponse = (HttpWebResponse)e.Response)
                                                {
                                                    using (var reader =
                                                        new StreamReader(errorResponse.GetResponseStream()))
                                                    {
                                                        string error = reader.ReadToEnd();
                                                        string result = error;
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Last updated less than current date");
                            }
                        }
                    }
                }
        }

        async static void UpdateOther(string url, string apiKey)
        {
            int[] ids = new int[3];
            ids[0] = 1044; //Bournemouth does not work
            ids[1] = 68; //Norwich does not work
            ids[2] = 397; //Brighton does not work
            foreach (var i in ids)
            {
                using (HttpClient playerClient = new HttpClient())
                {
                    playerClient.DefaultRequestHeaders.Add("X-Auth-Token",
                        apiKey);
                    string newurl = String.Format(url + i.ToString());
                    Console.WriteLine(newurl);
                    using (HttpResponseMessage playerResponse = await playerClient.GetAsync(newurl))
                    {
                        using (HttpContent playerContent = playerResponse.Content)
                        {
                            string myPlayerContent = await playerContent.ReadAsStringAsync();
                            OtherPlayers.RootObject obj1 =
                                JsonConvert.DeserializeObject<OtherPlayers.RootObject>(myPlayerContent);
                            CultureInfo enUs = new CultureInfo("en-Us");
                            string dateString, format;
                            dateString = "23/10/2018 16:16:00";
                            format = "dd/MM/yyyy HH:mm:ss";
                            DateTime dateResult = DateTime.ParseExact(dateString, format, enUs);
                            if (obj1.lastUpdated > dateResult)
                            {
                                foreach (OtherPlayers.Squad s in obj1.squad)
                                {
                                    {

                                        HttpWebRequest httpWebRequest =
                                            (HttpWebRequest)WebRequest.Create(
                                                "https://localhost:44324/api/players/" + s.id);
                                        Console.WriteLine(httpWebRequest);
                                        httpWebRequest.ContentType = "application/json; charset=utf-8";
                                        httpWebRequest.Method = "PUT";

                                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                                        {
                                            string now = DateTime.Now.ToString();
                                            var jsonPlayer = new OtherPlayers.JsonPlayer
                                            {
                                                Id = s.id,
                                                Name = s.name,
                                                Position = s.position,
                                                DateOfBirth = s.dateOfBirth,
                                                CountryOfBirth = s.countryOfBirth,
                                                Nationality = s.nationality,
                                                ShirtNumber = s.shirtNumber,
                                                Role = s.role,
                                                TeamId = i,
                                                LastUpdated = DateTime.ParseExact(now, format, enUs)
                                            };
                                            string json = JsonConvert.SerializeObject(jsonPlayer);
                                            Console.WriteLine(json);
                                            Debug.Write(json);
                                            streamWriter.Write(json);
                                            streamWriter.Flush();
                                            streamWriter.Close();
                                        }

                                        try
                                        {
                                            using (var response = httpWebRequest.GetResponse() as HttpWebResponse)
                                            {
                                                if (httpWebRequest.HaveResponse && response != null)
                                                {
                                                    using (var reader = new StreamReader(response.GetResponseStream()))
                                                    {
                                                        string result = reader.ReadToEnd();
                                                        Console.WriteLine(result);
                                                    }
                                                }
                                            }
                                        }
                                        catch (WebException e)
                                        {
                                            if (e.Response != null)
                                            {
                                                using (var errorResponse = (HttpWebResponse)e.Response)
                                                {
                                                    using (var reader =
                                                        new StreamReader(errorResponse.GetResponseStream()))
                                                    {
                                                        string error = reader.ReadToEnd();
                                                        string result = error;
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Last updated less than current date");
                            }
                        }
                    }
                }
            }
        }
    }
}
