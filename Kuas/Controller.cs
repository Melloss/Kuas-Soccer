using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kuas
{
    class Controller
    {
        private static List<Player> players = new List<Player>();
        public static  List<Player> Players
        {
            get { return players;}
            set { players = value; }
        }

        public static void GetEverythingReady()
        {
            String connectionString = "Data Source=ADMINRG-ACM4MC7;Initial Catalog=Kuas;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                    SqlCommand command = new SqlCommand("SELECT * FROM playerInfo", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int i = 1;
                    while (reader.Read())
                    {
                        try
                        {
                            Player p = new Player();
                            p.PlayerName = reader["playerName"].ToString();
                            p.PlayerImage = reader["playerImage"].ToString();
                            p.PlayerRate = Convert.ToInt32(reader["playerRate"]);
                            p.PlayerPrice = reader["playerPrice"].ToString();
                            p.PlayerAge = reader["playerAge"].ToString();
                            p.PlayerShirtNumber = Convert.ToInt32(reader["playerShirtNumber"]);
                            p.PlayerRole = reader["playerRole"].ToString();
                            p.PlayerClubImage = reader["playerClubImage"].ToString();
                            p.PlayerClub = reader["playerClubName"].ToString();
                            p.PlayerLeague = reader["playerLeague"].ToString();
                            p.MatchPlayed = Convert.ToInt32(reader["matchPlayed"]);
                            p.MinutePlayed = reader["minutePlayed"].ToString();
                            p.Goals = Convert.ToInt32(reader["goals"]);
                            p.Assists = Convert.ToInt32(reader["assists"]);
                            p.YellowCard = Convert.ToInt32(reader["yellowCard"]);
                            p.RedCards = Convert.ToInt32(reader["redCard"]);
                            p.CountryBirth = reader["countryBirth"].ToString();
                            p.PreferredFoot = reader["preferredFoot"].ToString();
                            p.ContinentOfBirth = reader["continentOfBirth"].ToString();
                            p.RegionOfBirth = reader["regionOfBirth"].ToString();
                            p.Weight = reader["weight"].ToString();
                            p.Height = reader["height"].ToString();
                            p.Status = reader["status"].ToString();
                            p.CurrentClub = reader["currentClub"].ToString();
                            p.CurrentCompetition = reader["currentCompetition"].ToString();
                            p.PreviousClub = reader["previousClub"].ToString();
                            p.PreviousCompetition = reader["previousCompetition"].ToString();
                            p.MostCommonShirtNumber = Convert.ToInt32(reader["mostCommonShirtNumber"]);
                            p.OtherShirtNumbers = reader["otherShirtNumber"].ToString();
                            p.Pace = Convert.ToInt32(reader["pace"]);
                            p.Shot = Convert.ToInt32(reader["shot"]);
                            p.Pass = Convert.ToInt32(reader["pass"]);
                            p.Dribbling = Convert.ToInt32(reader["dribbling"]);
                            p.Defender = Convert.ToInt32(reader["defender"]);
                            p.Stamina = Convert.ToInt32(reader["stamina"]);

                            // Adding to the List of playes
                            players.Add(p);
                            MessageBox.Show(i + " times");
                            i++;
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show("There is an erro!  " + e);
                        }
                        
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        public static void Goto(String pName)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].PlayerName.Trim().Equals(pName,StringComparison.OrdinalIgnoreCase))
                {
                    new PlayerInformation(players[i]).ShowDialog();

                }
                else MessageBox.Show("Clicked");
            }
           
         

        }
    }
}
