using System;
using System.Windows;
using System.Windows.Controls;

namespace MyProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateTemperature_Click(object sender, RoutedEventArgs e)
        {
            double temperature;
            if (double.TryParse(TemperatureTextBox.Text, out temperature))
            {
                string status = GetTemperatureStatus(temperature);
                StatusTextBlock.Text = "Current Temperature: " + temperature.ToString() + "°C - " + status;
            }
            else
            {
                StatusTextBlock.Text = "Invalid input. Please enter a valid number.";
            }
        }

        private string GetTemperatureStatus(double temperature)
        {
            if (temperature < 0)
                return "Freezing!";
            else if (temperature < 20)
                return "Cool";
            else if (temperature < 30)
                return "Comfortable";
            else
                return "Hot!";
        }
    }
}
