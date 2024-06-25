using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;
using MyProject.Controls;

namespace MyProject
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            SetupTimer();
            // UpdateDateTime(); // Initial update
            InitializeControls();
        }

        private void SetupTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
            UpdateInputs();
            UpdateOutputs();
        }

        // private void UpdateInputs()
        // {
        //     Input1.Value = random.Next(10);
        //     Input2.Value = random.Next(10);
        //     Input3.Value = random.Next(10);
        //     Input4.Value = random.Next(10);
        //     Input5.Value = random.Next(10);
        //     Input6.Value = random.Next(10);
        //     Input7.Value = random.Next(10);
        // }

        // private void UpdateOutputs()
        // {
        //     Output1.Value = random.Next(10);
        //     Output2.Value = random.Next(10);
        //     Output3.Value = random.Next(10);
        //     Output4.Value = random.Next(10);
        //     Output5.Value = random.Next(10);
        //     Output6.Value = random.Next(10);
        //     Output7.Value = random.Next(10);
        // }

        private void UpdateDateTime()
        {
            DateTimeDisplay.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void InitializeControls()
        {
            // Initialize inputs and outputs
            for (int i = 1; i <= 7; i++)
            {
                var input = new SevenSegmentDisplay { Value = 0, Color = System.Windows.Media.Brushes.Red };
                var output = new SevenSegmentDisplay { Value = 0, Color = System.Windows.Media.Brushes.Blue };
                InputsPanel.Children.Add(input);
                OutputsPanel.Children.Add(output);
            }
        }

        private void UpdateInputs()
        {
            foreach (SevenSegmentDisplay display in InputsPanel.Children)
            {
                display.Value = random.Next(10);
            }
        }

        private void UpdateOutputs()
        {
            foreach (SevenSegmentDisplay display in OutputsPanel.Children)
            {
                display.Value = random.Next(10);
            }
        }

        // private void SimulateProcessing()
        // {
        //     foreach (IndicatorLight light in InputsControl.Items)
        //     {
        //         light.IsOn = random.Next(2) == 0;
        //     }

        //     foreach (IndicatorLight light in OutputsControl.Items)
        //     {
        //         light.IsOn = random.Next(2) == 0;
        //     }

        //     if (random.Next(2) == 0)
        //     {
        //         MainStatusDisplay.OkCount++;
        //     }
        //     else
        //     {
        //         MainStatusDisplay.NgCount++;
        //     }

        //     UpdatePerformanceMetrics();
        // }

        private void UpdatePerformanceMetrics()
        {
            TimeLimit.Text = string.Format("{0:F1} %", random.Next(70, 100) / 10.0);
            HingLimit.Text = string.Format("{0:F1} %", random.Next(40, 70) / 10.0);
        }

        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = System.Windows.Media.VisualTreeHelper.GetChild(parent, i);
                if (child != null && child is T)
                    return (T)child;
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private void HighMode_Checked(object sender, RoutedEventArgs e)
        {
            HighIndicator.Opacity = 1.0; // Lamp is lit
            LowIndicator.Opacity = 0.2;  // Lamp is unlit
            (FindName("HighIndicator") as UIElement).Visibility = Visibility.Visible;
            (FindName("LowIndicator") as UIElement).Visibility = Visibility.Hidden;
        }

        private void LowMode_Checked(object sender, RoutedEventArgs e)
        {
            LowIndicator.Opacity = 1.0;  // Lamp is lit
            HighIndicator.Opacity = 0.2; // Lamp is unlit
            (FindName("HighIndicator") as UIElement).Visibility = Visibility.Hidden;
            (FindName("LowIndicator") as UIElement).Visibility = Visibility.Visible;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement start logic here
            MessageBox.Show("Process started");
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement stop logic here
            MessageBox.Show("Process stopped");
        }

        private void ProductDescription_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product Description");
        }

        private void Preferences_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Preferences");
        }

        private void Alarm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alarm");
        }

        private void ExternalDevices_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("External Devices");
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement up logic here
            MessageBox.Show("Up button clicked");
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement down logic here
            MessageBox.Show("Down button clicked");
        }
    }
}
