using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment2
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

        private void BtnGrid1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGrid9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChooseStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid1.Content = "";
            BtnGrid2.Content = "";
            BtnGrid3.Content = "";
            BtnGrid4.Content = "";
            BtnGrid5.Content = "";
            BtnGrid6.Content = "";
            BtnGrid7.Content = "";
            BtnGrid8.Content = "";
            BtnGrid9.Content = "";

            TxtXScoreDisplay.Text = "";
            TxtOScoreDisplay.Text = "";

            TxtXNameInput.Text = "";
            TxtONameInput.Text = "";

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}