using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomBoomRoulette
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartGameP1_Click(object sender, EventArgs e)
        {
            // Create an instance of the MainGame form so it can be opened
            MainGame MainG = new MainGame();
            // Open the MainGame form
            MainG.Show();
            // Hides the main menu form
            this.Hide();

        }
    }
}
