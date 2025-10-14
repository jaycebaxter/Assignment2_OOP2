// Program:     Tik Tac Toe
// Author:      Jayce Baxter-Johnson
// Date:        October 14th, 2025
// Description: Simple tik tac toe board

using Microsoft.VisualBasic;
using System.Reflection;
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
        private string currentPlayer = "";

        // Setting the scores to 0 for the beginning
        private int playerXScore = 0;
        private int playerOScore = 0;

        // Setting the winner to null for now
        string winner = "";

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

        // Adds up the score depending on the winner
        public void AddScores()
        {
            if (winner == "X")
            {
                playerXScore = playerXScore + 1;
                TxtXScoreDisplay.Text = playerXScore.ToString();
            }
            else if (winner == "O")
            {
                playerOScore = playerOScore + 1;
                TxtOScoreDisplay.Text = playerOScore.ToString();
            }
        }

        // this not workingggggggg lol

        //public bool CheckDraw()
        //{
        //    if (BtnGrid1.Content != "" &&
        //        BtnGrid2.Content != "" &&
        //        BtnGrid3.Content != "" &&
        //        BtnGrid4.Content != "" &&
        //        BtnGrid5.Content != "" &&
        //        BtnGrid6.Content != "" &&
        //        BtnGrid7.Content != "" &&
        //        BtnGrid8.Content != "" &&
        //        BtnGrid9.Content != "")
        //    {
        //        MessageBox.Show("It's a draw!");
        //        return true;
        //    }
        //    return false;
        //}

        // Checks if there has been a winner in the rows
        public bool CheckRows()
        {
            // Checking rows
            for (int row = 0; row < BOARD_ROWS; row++) {
                if (board [row, 0] != "" && board[row, 0] == board[row, 1] && board[row, 2] == board[row, 1])
                {
                    winner = currentPlayer;
                    WinnerName();
                    AddScores();
                    DisableButtons();
                    FillNullArray();
                    ResetAll();
                    return true;
                }
            }
            return false;
        }

        // Checks if there has been a winner in the columns
        public bool CheckColumns()
        {
            for (int column = 0; column < BOARD_COLUMNS; column++)
            {
                if (board[0, column] != "" && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    winner = currentPlayer;
                    WinnerName();
                    AddScores();
                    DisableButtons();
                    ResetAll();
                    FillNullArray();
                    return true;
                }
            }
            return false;
        }

        // Checks if there has been a winner diagonally
        public bool CheckDiagonal()
        {
            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winner = currentPlayer;
                WinnerName();
                AddScores();
                DisableButtons();
                ResetAll();
                FillNullArray();
                return true;
            }

            else if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winner = currentPlayer;
                WinnerName();
                AddScores();
                DisableButtons();
                ResetAll();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get winner name
        private void WinnerName()
        {
            if (winner == "X")
            {
                MessageBox.Show(TxtXNameInput.Text + " is the winner!");
            }
            else if (winner == "O")
            {
                MessageBox.Show(TxtONameInput.Text + " is the winner!");
            }
            else
            {
                return;
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
        private void FillNullArray()
        {
            // Filling array with null values because it's throwing an error I don't know
            for (int fillingRow = 0; fillingRow < BOARD_ROWS; fillingRow++)
            {
                for (int fillingColumn = 0; fillingColumn < BOARD_COLUMNS; fillingColumn++)
                {
                    board[fillingRow, fillingColumn] = "";
                }
            }
        }

        // Checking that names have been set 
        private void CheckNames()
        {
            if (TxtXNameInput.Text == "" ||  TxtONameInput.Text == "")
            {
                MessageBox.Show("Please enter your names");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            FillNullArray();
        }

        // Event handlers for all of the 3x3 grid clicks
        private void BtnGrid1_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid1.Content = currentPlayer;
                BtnGrid1.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid1.IsEnabled = true;
            }

            board[0, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid2_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid2.Content = currentPlayer;
                BtnGrid2.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid2.IsEnabled = true;
            }
            board[0, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid3_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid3.Content = currentPlayer;
                BtnGrid3.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid3.IsEnabled = true;
            }
            board[0, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid4_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid4.Content = currentPlayer;
                BtnGrid4.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid4.IsEnabled = true;
            }
            board[1, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid5_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid5.Content = currentPlayer;
                BtnGrid5.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid5.IsEnabled = true;
            }
            board[1, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid6_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid6.Content = currentPlayer;
                BtnGrid6.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid6.IsEnabled = true;
            }
            board[1, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid7_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid7.Content = currentPlayer;
                BtnGrid7.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid7.IsEnabled = true;
            }
            board[2, 0] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid8_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid8.Content = currentPlayer;
                BtnGrid8.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid8.IsEnabled = true;
            }
            board[2, 1] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
            ChangePlayer();
        }

        private void BtnGrid9_Click(object sender, RoutedEventArgs e)
        {
            if (currentPlayer != "")
            {
                BtnGrid9.Content = currentPlayer;
                BtnGrid9.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please select a starting player");
                BtnGrid9.IsEnabled = true;
            }
            board[2, 2] = currentPlayer;
            CheckRows();
            CheckColumns();
            CheckDiagonal();
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

        // Making a reset function so I can reuse it
        private void ResetAll()
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

            BtnGrid1.IsEnabled = true;
            BtnGrid2.IsEnabled = true;
            BtnGrid3.IsEnabled = true;
            BtnGrid4.IsEnabled = true;
            BtnGrid5.IsEnabled = true;
            BtnGrid6.IsEnabled = true;
            BtnGrid7.IsEnabled = true;
            BtnGrid8.IsEnabled = true;
            BtnGrid9.IsEnabled = true;

            TxtCurrentPlayer.Text = "";

            currentPlayer = "";
            FillNullArray();
        }
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}