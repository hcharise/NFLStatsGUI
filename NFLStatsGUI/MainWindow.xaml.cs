using System;
using System.Diagnostics.Metrics;
using System.Windows;

namespace MyWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OutputTextBlock.Text = "Welcome!\n\nEnter a Team Number (1 - 32) and a Game Number (1 - 16) above.\nThen click \"Show Stats\" to view the stats from that match up in the 2020 NFL season.\n\nYay sports!";
        }

        private async void ShowStatsButton_Click(object sender, RoutedEventArgs e)
        {
            string teamNumStr = TeamNumInput.Text;
            string gameNumStr = GameNumInput.Text;


            int teamNum = ConvertAndValidateInt(teamNumStr, 1, 32);
            int gameNum = ConvertAndValidateInt(gameNumStr, 1, 16);

            if (teamNum == -1 || gameNum == -1)
            {
                OutputTextBlock.Text = "Invalid input.\nTeam Number must be an integer from 1 to 32.\nGame Number must be an integer from 1 to 16.\n";

                return; // Stop execution if input is invalid
            }

            // Initialize the JSON handler, responsible for fetching and deserializing data
            JsonHandler jsonHandler = new JsonHandler();

            TeamHandler teamHandler = new TeamHandler(jsonHandler, teamNum);
            await teamHandler.LoadJsonData();

            OutputTextBlock.Text = teamHandler.PrintSpecificMatchUpStats(gameNum);
        }

        // Converts an input to a int (if possible) and checks if within range; reprompts if not an int within range
        private int ConvertAndValidateInt(string strInput, int min, int max)
        {
            int intOutput;

            // Validate user input - int and within min and max
            if (!int.TryParse(strInput, out intOutput) || intOutput < min || intOutput > max)
            {
                return -1; // Indicate invalid input
            }

            return intOutput;
        }
    }
}
