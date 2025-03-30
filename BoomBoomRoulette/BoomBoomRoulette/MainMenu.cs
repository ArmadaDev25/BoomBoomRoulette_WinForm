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
        //Specify The Name of the file
        private string fileName = "saveFile.txt";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartGameP1_Click(object sender, EventArgs e)
        {
            // Writes the users name to a file
            writeNameToFile();

            // Create an instance of the MainGame form so it can be opened
            MainGame MainG = new MainGame();
            // Open the MainGame form
            MainG.Show();
            // Hides the main menu form
            this.Hide();
            

        }
        // Function that writes the Players name to a file
        void writeNameToFile() 
        {
            // Error handling implmented for the write to a file function
            // Attempts to write to a file, with throw error if the program runs into an issue
            try
            {
                File.WriteAllText(fileName, PlayerNameEntry.Text);

            }
            // If an error occurs when creating the file, a messagebox will show
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }

            
        
        }
    }
}
