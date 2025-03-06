using System;
using System.Windows;

namespace MyWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ShowStatsButton_Click(object sender, RoutedEventArgs e)
        {
            string teamNumStr = TeamNumInput.Text;

            int teamNum = ConvertAndValidateInt(teamNumStr, 1, 32);

            // Initialize the JSON handler, responsible for fetching and deserializing data
            JsonHandler jsonHandler = new JsonHandler();

            TeamHandler teamHandler = new TeamHandler(jsonHandler, teamNum);
            await teamHandler.LoadJsonData();


            OutputTextBlock.Text = teamHandler.PrintAllStats();
        }

        // Converts an input to a int (if possible) and checks if within range; reprompts if not an int within range
        private int ConvertAndValidateInt(string strInput, int min, int max)
        {
            int intOutput;

            // Validate user input - int and within min and max
            while (!int.TryParse(strInput, out intOutput) || intOutput < min || intOutput > max)
            {
                OutputTextBlock.Text = $"Invalid input. Please enter a integer from {min} to {max}.";
                strInput = TeamNumInput.Text;
            }

            return intOutput;
        }
    }
}
