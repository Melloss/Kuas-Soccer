using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kuas
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            userName.Text = Properties.Settings.Default.userName;
        }

      

        private void round37Group_MouseHover(object sender, EventArgs e)
        {
            newcasteleText.ForeColor = Color.Green;
            time.ForeColor = Color.Green;
            leicesterText.ForeColor = Color.Green;
        }

        private void newcasteleText_MouseLeave(object sender, EventArgs e)
        {
            newcasteleText.ForeColor = Color.FromArgb(0,64,64);
            time.ForeColor = Color.FromArgb(0, 64, 64);
            leicesterText.ForeColor = Color.FromArgb(0, 64, 64);
        }

      

        private void round37Group_MouseCaptureChanged_1(object sender, EventArgs e)
        {
            Newcastle_Leicester_Play ncp = new Newcastle_Leicester_Play();
            ncp.ShowDialog();
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            tottenhamText.ForeColor = Color.Green;
            score1.ForeColor = Color.Green;
            brentfordText.ForeColor = Color.Green;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            tottenhamText.ForeColor = Color.FromArgb(0, 64, 64);
            score1.ForeColor = Color.FromArgb(0, 64, 64);
            brentfordText.ForeColor = Color.FromArgb(0, 64, 64);
        }

      

        private void panel6_Click(object sender, EventArgs e)
        {
            Tottenham_Brentford_Play cp = new Tottenham_Brentford_Play();
            cp.ShowDialog();
        }

         private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            List<String> searchedPlayers = new List<String>();
            searchListBoard.Visible = true;
           
            if (searchBox.Text.Length == 0)
            {
                searchListBoard.Visible = false;
                searchListBoard.Clear();
                
            }
            
            else if(searchBox.Text.Length > 1)
            {
                
                searchedPlayers = Controller.SearchPlayer(searchBox.Text);
                searchListBoard.Clear();
           
                for(int i = 0; i< searchedPlayers.Count(); i++)
                {
                    searchListBoard.Items.Add(searchedPlayers[i]);
                }
               
            }
            searchedPlayers.Clear();


        }

        private void searchListBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = searchListBoard.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                Controller.GotoPlayer(item.Text);
                searchBox.Clear();
                break;
            }
        }
    }
}
