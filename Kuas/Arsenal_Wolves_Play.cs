using System;
using System.Windows.Forms;

namespace Kuas
{
    public partial class Arsenal_Wolves_Play : Form
    {
        public Arsenal_Wolves_Play()
        {
            InitializeComponent();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Granit Xhaka");
        }

        private void label47_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Gabriel Jesus");
        }

        private void label45_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Bukayo Saka");
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Leandro Trossard");
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Jakub Kiwior");
        }

        private void label53_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Emile Smith Rowe");
        }

        private void label58_Click(object sender, EventArgs e)
        {
            Controller.GotoPlayer("Thomas Partey");
        }
    }
}
