using Microsoft.VisualBasic;
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
    public partial class MainWindow : Window
    {
        // Setting current player to default to nothing
        public string currentPlayer = "";
        
        // Initializing random logic that we will use in the "choose current player" button
        Random myRandom = new Random();

        // Function to change players after the current player chooses their spot

        private void ChangePlayer()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
                TxtCurrentPlayer.Text = currentPlayer;
            }

            else if (currentPlayer == "O")
            {
                currentPlayer = "X";
                TxtCurrentPlayer.Text = currentPlayer;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGrid1_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid1.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid2_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid2.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid3_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid3.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid4_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid4.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid5_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid5.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid6_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid6.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid7_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid7.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid8_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid8.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnGrid9_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid9.Content = currentPlayer;
            ChangePlayer();
        }

        private void BtnChooseStart_Click(object sender, RoutedEventArgs e)
        {
            int randomNum = myRandom.Next(1, 3);
            if (randomNum == 1)
            {
                currentPlayer = "X";
                TxtCurrentPlayer.Text = "X";
            }

            else
            {
                currentPlayer = "O";
                TxtCurrentPlayer.Text = "O";
            }
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

            TxtCurrentPlayer.Text = "";

            currentPlayer = "";
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}