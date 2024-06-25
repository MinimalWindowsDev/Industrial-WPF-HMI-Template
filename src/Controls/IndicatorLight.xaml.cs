using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyProject.Controls
{
    public partial class IndicatorLight : UserControl
    {
        public static readonly DependencyProperty IsOnProperty =
            DependencyProperty.Register("IsOn", typeof(bool), typeof(IndicatorLight),
                new PropertyMetadata(false, OnIsOnChanged));

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(IndicatorLight),
                new PropertyMetadata(Brushes.Gray));

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(IndicatorLight),
                new PropertyMetadata(string.Empty));

        public bool IsOn
        {
            get { return (bool)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }

        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public IndicatorLight()
        {
            InitializeComponent();
            UpdateVisuals();
        }

        private static void OnIsOnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as IndicatorLight;
            control.UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            Light.Fill = IsOn ? Color : Brushes.Transparent;
            Label.Text = LabelText;
        }
    }
}
