using System;
using System.Windows;
using System.Windows.Controls;

namespace DailyInterestCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                decimal prin = Convert.ToDecimal(principal.Text);
                decimal intrate = Convert.ToDecimal(interest.Text) / 100;
                decimal dailyInterest = prin * intrate / 365;
                MessageBox.Show($"Approximate Interest is: ${dailyInterest.ToString("0.##")}");
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void principal_TextChanged(object sender, TextChangedEventArgs e) {
        }
    }
}
