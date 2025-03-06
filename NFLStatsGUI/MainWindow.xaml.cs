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

        private async void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            // will use if/when we add user choosing team
            string input = InputTextBox.Text;

            // Initialize the JSON handler, responsible for fetching and deserializing data
            JsonHandler jsonHandler = new JsonHandler();

            TeamHandler teamHandler = new TeamHandler(jsonHandler, 1);
            await teamHandler.LoadJsonData();


            OutputTextBlock.Text = teamHandler.PrintAllStats();
        }
    }
}
