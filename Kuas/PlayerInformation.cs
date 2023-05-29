using Kuas.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kuas
{
    public partial class PlayerInformation : Form
    {
        
        public PlayerInformation(Player p)
        {
            InitializeComponent();
            playerName.Text = p.PlayerName.Trim();
            playerImage.Image = Controller.Images[p.PlayerImage.Trim()];
            playerRate.Text = p.PlayerRate.ToString().Trim();
            playerPrice.Text = p.PlayerPrice.Trim();
            playerAge.Text = p.PlayerAge.Trim();
            playerShirtNumber.Text = p.PlayerShirtNumber.ToString().Trim();
            playerRole.Text = p.PlayerRole.Trim();
            playerClubImage.Image = Controller.Images[p.PlayerClubImage.Trim()];
            playerClubName.Text = p.PlayerClub.Trim();
            playerLeague.Text = p.PlayerLeague.Trim();
            matchPlayed.Text = p.MatchPlayed.ToString().Trim();
            minutePlayed.Text = p.MinutePlayed.Trim();
            Goals.Text = p.Goals.ToString().Trim();
            assists.Text = p.Assists.ToString().Trim();
            yellowCard.Text = p.YellowCard.ToString().Trim();
            redCard.Text = p.RedCards.ToString().Trim();
            countryOfBirth.Text = p.CountryBirth.Trim();
            preferredFoot.Text = p.PreferredFoot.Trim();
            ContinentOfBirth.Text = p.ContinentOfBirth.Trim();
            regionOfBirth.Text = p.RegionOfBirth.Trim();
            weight.Text = p.Weight.Trim();
            height.Text = p.Height.Trim();
            status.Text = p.Status.Trim();
            currentClub.Text = p.CurrentClub.Trim();
            currentCompetition.Text = p.CurrentCompetition.Trim();
            previousClub.Text = p.PreviousClub.Trim();
            previousCompetition.Text = p.PreviousCompetition.Trim();
            mostCommonShirt.Text = p.MostCommonShirtNumber.ToString().Trim();
            otherShirtNumber.Text = p.OtherShirtNumbers.Trim();

            // Set Y value for the chart series

            attributeChart.Series["attribute"].Points[0].YValues.SetValue(p.Pace,0);
            attributeChart.Series["attribute"].Points[1].YValues.SetValue(p.Shot, 0);
            attributeChart.Series["attribute"].Points[2].YValues.SetValue(p.Pass, 0);
            attributeChart.Series["attribute"].Points[3].YValues.SetValue(p.Dribbling, 0);
            attributeChart.Series["attribute"].Points[4].YValues.SetValue(p.Defender, 0);
            attributeChart.Series["attribute"].Points[5].YValues.SetValue(p.Stamina, 0);
            if(playerRole.Text.Trim() == "MID")
            {
                playerRole.BackColor = Color.DodgerBlue;
            }
            else if (playerRole.Text.Trim() == "DEF")
            {
                playerRole.BackColor = Color.White;
                playerRole.ForeColor = Color.FromArgb(1, 9, 33, 41);
            }
            else if(playerRole.Text.Trim() == "ATT")
            {
                playerRole.BackColor = Color.Red;
            }
            else if (playerRole.Text.Trim() == "GOA")
            {
                playerRole.BackColor = Color.DarkGoldenrod;
                unbeaten_label.Text = "Matches unbeaten";
                goal_catch_label.Text = "Goal Save";
                unbeaten_picture.Image = Properties.Resources.unbeaten_imge;
                goal_catch.Image = Properties.Resources.goal_save;
                attributeChart.Series["attribute"].Points[0].Label = "Jump";
                attributeChart.Series["attribute"].Points[1].Label = "Dive";
                attributeChart.Series["attribute"].Points[2].Label = "Saves";
                attributeChart.Series["attribute"].Points[3].Label = "Throw-In";
                attributeChart.Series["attribute"].Points[4].Label = "Positioning";
                attributeChart.Series["attribute"].Points[5].Label = "Reflects";
            }
        }
      

        private void PlayerInformation_Resize(object sender, EventArgs e)
        {

        }

        private void PlayerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
