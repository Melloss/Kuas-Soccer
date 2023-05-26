using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuas
{
    public partial class PlayerInformation : Form
    {
        public PlayerInformation(Player p)
        {
            InitializeComponent();
            playerName.Text = p.PlayerName.Trim();
            minutePlayed.Text = p.MinutePlayed.Trim();
            playerRate.Text = p.PlayerRate.ToString().Trim();
        }
      

        private void PlayerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
