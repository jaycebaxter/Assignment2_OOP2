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
        // Creating board
        // Referenced here a bit https://stackoverflow.com/questions/19220942/creating-a-3x3-matrix-with-user-input-numbers-c-sharp
        const int BOARD_ROWS = 3;
        const int BOARD_COLUMNS = 3;
        
        // Creating array
        string[,] board = new string[BOARD_ROWS, BOARD_COLUMNS];

        // Setting current player to default to nothing
        public string currentPlayer = "";
        
        // Initializing random logic that we will use in the "choose current player" button
        Random myRandom = new Random();

        // Disables all of the buttons in the tik tac toe grid, used for declaring a winner
        public void DisableButtons()
        {
            BtnGrid1.IsEnabled = false;
            BtnGrid2.IsEnabled = false;
            BtnGrid3.IsEnabled = false;
            BtnGrid4.IsEnabled = false;
            BtnGrid5.IsEnabled = false;
            BtnGrid6.IsEnabled = false;
            BtnGrid7.IsEnabled = false;
            BtnGrid8.IsEnabled = false;
            BtnGrid9.IsEnabled = false;
        }

        // Checks if there has been a winner in the rows
        public bool CheckRows()
        {
            string winner = "";

            // Checking rows
            for (int row = 0; row < BOARD_ROWS; row++) {
                if (board [row, 0] != "" && board[row, 0] == board[row, 1] && board[row, 2] == board[row, 1])
                {
                    winner = currentPlayer;
                    MessageBox.Show(currentPlayer + " is the winner!");
                    DisableButtons();
                    return true;
                }
            }
            return false;
        }

        // Checks if there has been a winner in the columns
        public bool CheckColumns()
        {
            string winner = "";
            for (int column = 0; column < BOARD_COLUMNS; column++)
            {
                if (board[0, column] != "" && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    winner = currentPlayer;
                    MessageBox.Show(currentPlayer + " is the winner!");
                    DisableButtons();
                    return true;
                }
            }
            return false;
        }

        // Checks if there has been a winner diagonally

        public bool CheckDiagonal()
        {
            string winner = "";
            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winner = currentPlayer;
                MessageBox.Show(currentPlayer + " is the winner!");
                DisableButtons();
                return true;
            }

            else if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winner = currentPlayer;
                MessageBox.Show(currentPlayer + " is the winner!");
                DisableButtons();
                return true;
            }
            else
            {
                return false;
            }
        }

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

            // Filling array with null values because it's throwing an error I don't know
            for (int fillingRow = 0; fillingRow < BOARD_ROWS; fillingRow++)
            {
                for (int fillingColumn = 0; fillingColumn < BOARD_COLUMNS; fillingColumn++)
                {
                    board[fillingColumn, fillingRow] = "";
                }
            }
        }

        private void BtnGrid1_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid1.Content = currentPlayer;
            board[0, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid2_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid2.Content = currentPlayer;
            board[0, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid3_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid3.Content = currentPlayer;
            board[0, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid4_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid4.Content = currentPlayer;
            board[1, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid5_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid5.Content = currentPlayer;
            board[1, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid6_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid6.Content = currentPlayer;
            board[1, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid7_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid7.Content = currentPlayer;
            board[2, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid8_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid8.Content = currentPlayer;
            board[2, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            ChangePlayer();
        }

        private void BtnGrid9_Click(object sender, RoutedEventArgs e)
        {
            BtnGrid9.Content = currentPlayer;
            board[2, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
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