using Kuas.Properties;
using System;
using System.Windows.Forms;

namespace Kuas
{
    public partial class PlayerInformation : Form
    {
        
        public PlayerInformation(Player p)
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInformation));
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
            attributeChart.Series["attribute"].Points[0].YValues.SetValue(p.Stamina,0);
            attributeChart.Series["attribute"].Points[1].YValues.SetValue(p.Shot, 0);
            attributeChart.Series["attribute"].Points[2].YValues.SetValue(p.Pass, 0);
            attributeChart.Series["attribute"].Points[3].YValues.SetValue(p.Dribbling, 0);
            attributeChart.Series["attribute"].Points[4].YValues.SetValue(p.Defender, 0);
            attributeChart.Series["attribute"].Points[5].YValues.SetValue(p.Pace, 0);
        }
      

        private void PlayerInformation_Load(object sender, EventArgs e)
        {
          


        }
    }
}
