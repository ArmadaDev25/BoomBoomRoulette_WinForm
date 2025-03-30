using System.Diagnostics;

namespace BoomBoomRoulette
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }
        // Array that stores what "ammo in loaded in the gun and in what order"
        string[] ammoLoaded = [];
        int playerHealth = 0;
        int computerHealth = 0;
        // bool that store whether or not the player is the target
        // Only 2 possible choices to the target, one of which is the player. The other target is not the player. 
        bool isPlayerTarget = false;
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
            for (int i = 0; i < 5; i++)
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
            if (ammoLoaded[0] == "Live")
            {
                EventsBox.Items.Add("Bang");


            }
            if (ammoLoaded[0] == "Blank")
            {
                EventsBox.Items.Add("Click");

            }

        }



        private void StartRoundBtn_Click(object sender, EventArgs e)
        {
            loadGun();
            showLoadedRounds();
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
    }
}
