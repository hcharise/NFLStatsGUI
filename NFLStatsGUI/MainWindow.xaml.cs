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

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

            OutputTextBlock.Text = "Hello!";
        }
    }
}
