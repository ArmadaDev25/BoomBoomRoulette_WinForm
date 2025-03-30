using System.Diagnostics;

namespace BoomBoomRoulette
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        // Variables
        // Array that stores what "ammo in loaded in the gun and in what order"
        string[] ammoLoaded = [];
        int playerHealth = 0;
        int computerHealth = 0;
        int RoundsToLoad = 5;
        // bool that store whether or not the player is the target
        // Only 2 possible choices to the target, one of which is the player. The other target is not the player. 
        bool isPlayerTarget = false;
        //Specify The Name of the file
        private string fileName = "saveFile.txt";
        // Stores the current index of the next "shell" to be fired in the AmmoLoaded array
        int CurrentAmmoRound = 0;
        
        // function that Generates a random number to be used throghtout the application
        int generateRandomNumber(int ranMax)
        {
            Random ran = new Random();
            // Generates a random number that is between 0 and the ranMax
            // The generated number is then stored in the outputNum variable
            int outputNum = ran.Next(0, ranMax);
            return outputNum;
        }

        // Function that will "load the gun with a random assortment of shells that are either live or not live"
        void loadGun()
        {
            // Loop that will load the gun by adding items to the ammoLoaded array
            for (int i = 0; i < RoundsToLoad; i++)
            {
                // Calls the generateRandomNumer function, and passes 2 into the function
                // The function should return either a 0 or 1, thus determining if the shell loaded is considered "live or not"
                int roundToLoad = generateRandomNumber(2);
                if (roundToLoad == 0)
                {
                    ammoLoaded = ammoLoaded.Append("Live").ToArray();
                }
                else
                {
                    ammoLoaded = ammoLoaded.Append("Blank").ToArray();

                }

            }
        }
        // Displays the rounds loaded to the user
        void showLoadedRounds()
        {
            // Adds the "Rounds Loaded" string to the textbox to denote to the user that these are the rounds loaded into the gun
            EventsBox.Items.Add("Rounds Loaded");
            // For loop that loops through each of the indexes within the ammoLoaded Array
            for (int i = 0; i < ammoLoaded.Length; i++)
            {
                EventsBox.Items.Add(ammoLoaded[i]);
            }

        }

        // Logic that happens when the player choses to fire the gun  
        void fireGun()
        {
            // If statements to check whether or not the Round was a "live" or a "blank"
            // Logic for if the ammo was live
            if (ammoLoaded[CurrentAmmoRound] == "Live")
            {
                EventsBox.Items.Add("Bang");

                // If the Player was selected as the target then the player takes damage
                if (isPlayerTarget == true)
                {
                    EventsBox.Items.Add("You Take a Shotgun Blast");
                    EventsBox.Items.Add("You Lose 1 Health");
                    playerHealth = playerHealth - 1;
                }
                // If the AI was selected as the target, then the AI takes damage
                else
                {
                    EventsBox.Items.Add("Your Opponent Takes a Shotgun Blast");
                    EventsBox.Items.Add("They Lose 1 Health");
                    computerHealth = computerHealth - 1;
                }


            }
            // Logic for if the ammo was a blank
            if (ammoLoaded[CurrentAmmoRound] == "Blank")
            {
                EventsBox.Items.Add("Click");

            }
            // Incriments the current ammo round
            CurrentAmmoRound++;
            // Updates the health player and Computer health UI after each shoot
            updateHealthCounters();

        }

        void updateHealthCounters() {
            lblPlayerHP.Text = playerHealth.ToString();
            lblcomputerHP.Text = computerHealth.ToString();
        
        
        }



        private void StartRoundBtn_Click(object sender, EventArgs e)
        {
            loadGun();
            showLoadedRounds();
            // Converts the health input text into an in
            int Health = Convert.ToInt32(hInput.Text);
            playerHealth = Health;
            computerHealth = Health;
            // Updates the Player and Computer Health UI elements
            updateHealthCounters();








        }



        // Player Clicks this button to set the target to themselves
        private void AimPlayerBtn_Click(object sender, EventArgs e)
        {
            isPlayerTarget = true;
        }

        // Player Clicks this button to set the target to the AI
        private void AimAiBtn_Click(object sender, EventArgs e)
        {
            isPlayerTarget = false;
        }

        // logic that happens when the player pushes the fire button
        private void fireBtn_Click(object sender, EventArgs e)
        {
            fireGun();

        }

        // Actions that occur once the MainGame form loads
        // Program should read data from saveFile.txt then display it in some way
        private void MainGame_Load(object sender, EventArgs e)
        {
            // Try/Catch Error handling to handle potential errors with the file read/write
            try 
            {
                // Changes the text of the label to the text within the file
                lblPlayerNameOutput.Text = File.ReadAllText(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            updateHealthCounters();

            
        }

   
    }
}
