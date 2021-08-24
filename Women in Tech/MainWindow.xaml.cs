using System.Windows;
using System.Windows.Media;

namespace Women_in_Tech
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
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            // If the YES radio button is checked
            yesLabel.Foreground = Brushes.Purple;
        }

        private void radioButton1_Unchecked(object sender, RoutedEventArgs e)
        {
            // If it is not unchecked
            yesLabel.Foreground = Brushes.Black;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            //If the NO radio button is checked
            noLabel.Foreground = Brushes.Purple;
        }

        private void radioButton2_Unchecked(object sender, RoutedEventArgs e)
        {
            // If it is unchecked
            noLabel.Foreground = Brushes.Black;
        }
        // For the summit Button
        private void summitButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextbox.Text) && !string.IsNullOrWhiteSpace(IdTextbox.Text) && !string.IsNullOrWhiteSpace(collegeTextbox.Text)
                && !string.IsNullOrWhiteSpace(whatsappTextbox.Text) && (radioButton1.IsChecked == true || radioButton2.IsChecked == true))
            {
                MessageBox.Show("Form Summitted");
            }
            else
            {
                MessageBox.Show("Complete the form");
            }

        }
        // For the Clear Button
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextbox.Clear();
            IdTextbox.Clear();
            collegeTextbox.Clear();
            whatsappTextbox.Clear();
            if(radioButton1.IsChecked == true)
            {
                radioButton1.IsChecked = false;
            }
            else
            {
                radioButton2.IsChecked = false;
            }
        }
        // For sending to the link website
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void Hyperlink_RequestNavigate_1(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void Hyperlink_RequestNavigate_2(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
