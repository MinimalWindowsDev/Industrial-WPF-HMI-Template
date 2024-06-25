using System.Windows;
using System.Windows.Controls;

namespace MyProject.Controls
{
    public partial class StatusDisplay : UserControl
    {
        public static readonly DependencyProperty OkCountProperty =
            DependencyProperty.Register("OkCount", typeof(int), typeof(StatusDisplay),
                new PropertyMetadata(0, OnCountChanged));

        public static readonly DependencyProperty NgCountProperty =
            DependencyProperty.Register("NgCount", typeof(int), typeof(StatusDisplay),
                new PropertyMetadata(0, OnCountChanged));

        public int OkCount
        {
            get { return (int)GetValue(OkCountProperty); }
            set { SetValue(OkCountProperty, value); }
        }

        public int NgCount
        {
            get { return (int)GetValue(NgCountProperty); }
            set { SetValue(NgCountProperty, value); }
        }

        public StatusDisplay()
        {
            InitializeComponent();
        }

        private static void OnCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as StatusDisplay;
            control.UpdateCounts();
        }

        private void UpdateCounts()
        {
            var okCountTextBlock = FindName("OkCount") as TextBlock;
            var ngCountTextBlock = FindName("NgCount") as TextBlock;
            var totalCountTextBlock = FindName("TotalCount") as TextBlock;

            if (okCountTextBlock != null)
                okCountTextBlock.Text = string.Format("U:{0}", OkCount);
            if (ngCountTextBlock != null)
                ngCountTextBlock.Text = string.Format("U:{0}", NgCount);
            if (totalCountTextBlock != null)
                totalCountTextBlock.Text = (OkCount + NgCount).ToString();
        }
    }
}
