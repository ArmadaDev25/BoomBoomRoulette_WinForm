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
                    ammoLoaded = ammoLoaded.Append("live").ToArray();
                }
                else
                {
                    ammoLoaded = ammoLoaded.Append("live").ToArray();

                }

            }
        }

        void showLoadedRounds() { }

        private void StartRoundBtn_Click(object sender, EventArgs e)
        {
            loadGun();
            //EventsBox.Items.Add(ammoLoaded);
        }
    }
}
