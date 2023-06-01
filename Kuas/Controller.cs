using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kuas
{
    
    class Controller
    {
      

        private static String connectionString = "Data Source=ADMINRG-ACM4MC7;Initial Catalog=Kuas;Integrated Security=True";
        public static Dictionary<string, Image> Images = new Dictionary<string, Image>();
        private static List<Player> players = new List<Player>();
        public static List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public static void GetEverythingReady()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM playerInfo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
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
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Images.Add("HarryKane", Properties.Resources.HarryKane);
            Images.Add("TottenhamLogo", Properties.Resources.Tottenham);
            Images.Add("Kulusevski", Properties.Resources.kuluveski);
            Images.Add("BryanMbeumo", Properties.Resources.B_Mubuemo);
            Images.Add("Brentford", Properties.Resources.brentford);
            Images.Add("RicoHenry", Properties.Resources.R_Henarry);
            Images.Add("Richarlison", Properties.Resources.richard);
            Images.Add("YvesBissouma", Properties.Resources.Y_bissouma);
            Images.Add("YoaneWissa", Properties.Resources.Y_Wissa);
            Images.Add("AaronHickey", Properties.Resources.A_Hickey);
            Images.Add("NickPope", Properties.Resources.nick_pope);
            Images.Add("KieranTrippier", Properties.Resources.K_Trippier);
            Images.Add("FabianSchar", Properties.Resources.F_Schar);
            Images.Add("SvenBotman", Properties.Resources.s_Botman);
            Images.Add("DanielBurn", Properties.Resources.D_Burn);
            Images.Add("SeanLongstaff", Properties.Resources.S_longstaff);
            Images.Add("BrunoGuimaraes", Properties.Resources.B_Guimaraes);
            Images.Add("ElliotAnnderson", Properties.Resources.E_Anderson);
            Images.Add("MiguelAlmiron", Properties.Resources.M_Almiron);
            Images.Add("CallumWilson", Properties.Resources.C_wilson);
            Images.Add("AlexanderIsak", Properties.Resources.A_Isak);
            Images.Add("Newcastle", Properties.Resources.newcastle_logo);
            Images.Add("Leicester", Properties.Resources.lesterCity_logo);
            Images.Add("DanielIversen", Properties.Resources.daniel_Iverson);
            Images.Add("Castgne", Properties.Resources.castagne);
            Images.Add("HarrySouttar", Properties.Resources.harry_souttar);
            Images.Add("JonnyEvans", Properties.Resources.johnatan_evan);
            Images.Add("WoutFaes", Properties.Resources.w_Faes);
            Images.Add("LukeThomas", Properties.Resources.luke_thomas);
            Images.Add("WilfredNidi", Properties.Resources.wiferedNdidi);
            Images.Add("YouriTielemans", Properties.Resources.youriTielemans);
            Images.Add("BoubakarySoumare", Properties.Resources.boubakary_soumare);
            Images.Add("KelechiIheanacho", Properties.Resources.kelechi_iheanaco);
            Images.Add("JamieVardy", Properties.Resources.j_vardy);
            Images.Add("GranitXhaka", Properties.Resources.G__Xhaka);
            Images.Add("GabrielJesus", Properties.Resources.gabriel_jesus);
            Images.Add("BukayoSaka", Properties.Resources.b_saka);
            Images.Add("LeandroTrossard", Properties.Resources.l_Trossary);
            Images.Add("JakubKiwior", Properties.Resources.j_kuewr);
            Images.Add("EmileSmithRowe", Properties.Resources.smith_rower);
            Images.Add("ThomasPartey", Properties.Resources.tomas);
            Images.Add("Arsenal", Properties.Resources.arsenal_logo);
            Images.Add("Wolves", Properties.Resources.wolves_logo);

        }

        public static void GotoPlayer(String pName)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].PlayerName.Trim().Equals(pName, StringComparison.OrdinalIgnoreCase))
                {
                    new PlayerInformation(players[i]).ShowDialog();

                }
            }
        }

        public static List<String> SearchPlayer(String playerName)
        {
            List<String> ps = new List<string>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM playerInfo WHERE playerName LIKE \'%" + playerName + "%\' ", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ps.Add(reader["playerName"].ToString().Trim());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return ps;
        }


        public static bool createAccount(UserAccount account)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO userAccount([First Name],[Last Name],[Email],[Password],[Gender]) VALUES('"+account.FirstName+"','"+account.LastName+"','"+account.Email+"','"+account.Password+"','"+account.Gender+"')", connection);
                int rowAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public static bool isThereAccout(String em, String ps)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM userAccount where Email = '"+em+"' And [Password] = '"+ps+"';", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Properties.Settings.Default.userName = reader["First Name"].ToString() + " " + reader["Last Name"].ToString();
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("The Email or Password is Incorrect", "Kuas");
                    return false;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    class UserAccount
    {
        public String FirstName;
        public String LastName;
        public String Email;
        public String Password;
        public String Gender;
        public UserAccount(String fn, String ln, String em, String ps, String gn)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Email = em;
            this.Password = ps;
            this.Gender = gn;
        }
    }
}
