using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyProject.Controls
{
    public partial class SevenSegmentDisplay : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(SevenSegmentDisplay),
                new PropertyMetadata(0, OnValueChanged));

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(SevenSegmentDisplay),
                new PropertyMetadata(Brushes.Red, OnColorChanged));

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public SevenSegmentDisplay()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SevenSegmentDisplay)d).UpdateDisplay();
        }

        private static void OnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SevenSegmentDisplay)d).UpdateColor();
        }

        private void UpdateDisplay()
        {
            bool[] segments = GetSegments(Value);
            SegmentA.Opacity = segments[0] ? 1 : 0.1;
            SegmentB.Opacity = segments[1] ? 1 : 0.1;
            SegmentC.Opacity = segments[2] ? 1 : 0.1;
            SegmentD.Opacity = segments[3] ? 1 : 0.1;
            SegmentE.Opacity = segments[4] ? 1 : 0.1;
            SegmentF.Opacity = segments[5] ? 1 : 0.1;
            SegmentG.Opacity = segments[6] ? 1 : 0.1;
        }

        private void UpdateColor()
        {
            SegmentA.Fill = Color;
            SegmentB.Fill = Color;
            SegmentC.Fill = Color;
            SegmentD.Fill = Color;
            SegmentE.Fill = Color;
            SegmentF.Fill = Color;
            SegmentG.Fill = Color;
        }

        private bool[] GetSegments(int value)
        {
            switch (value)
            {
                case 0: return new bool[] { true, true, true, true, true, true, false };
                case 1: return new bool[] { false, true, true, false, false, false, false };
                case 2: return new bool[] { true, true, false, true, true, false, true };
                case 3: return new bool[] { true, true, true, true, false, false, true };
                case 4: return new bool[] { false, true, true, false, false, true, true };
                case 5: return new bool[] { true, false, true, true, false, true, true };
                case 6: return new bool[] { true, false, true, true, true, true, true };
                case 7: return new bool[] { true, true, true, false, false, false, false };
                case 8: return new bool[] { true, true, true, true, true, true, true };
                case 9: return new bool[] { true, true, true, true, false, true, true };
                default: return new bool[] { false, false, false, false, false, false, false };
            }
        }
    }
}
