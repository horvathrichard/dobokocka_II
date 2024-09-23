using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobokocka_II
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int player1Score = 0;
        private int player2Score = 0;
        private int player1Wins = 0;
        private int player2Wins = 0;
        private int roundNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlayer1Roll_Click(object sender, EventArgs e)
        {
            PlayRound();
        }

        private void PlayRound()
        {
            // Dobások
            int player1Roll1 = random.Next(1, 7);
            int player1Roll2 = random.Next(1, 7);
            int player2Roll1 = random.Next(1, 7);
            int player2Roll2 = random.Next(1, 7);

            // Játékosok értékei
            int player1Result = CalculateDiceResult(player1Roll1, player1Roll2);
            int player2Result = CalculateDiceResult(player2Roll1, player2Roll2);

            // Kijelző frissítése
            labelPlayer1Roll.Text = $"Player 1: {player1Roll1}{player1Roll2} ({player1Result})";
            labelPlayer2Roll.Text = $"Player 2: {player2Roll1}{player2Roll2} ({player2Result})";

            // Kör győztesének eldöntése
            if (player1Result > player2Result)
            {
                player1Wins++;
                labelRoundWinner.Text = $"Round {roundNumber}: Player 1 wins!";
            }
            else if (player2Result > player1Result)
            {
                player2Wins++;
                labelRoundWinner.Text = $"Round {roundNumber}: Player 2 wins!";
            }
            else
            {
                labelRoundWinner.Text = $"Round {roundNumber}: It's a draw!";
            }

            roundNumber++;

            // Eredmény kijelzése
            labelGameResult.Text = $"Player 1 Wins: {player1Wins} | Player 2 Wins: {player2Wins}";

            // Ellenőrzés, hogy van-e győztes
            if (player1Wins == 6)
            {
                MessageBox.Show("Player 1 wins the game!");
                ResetGame();
            }
            else if (player2Wins == 6)
            {
                MessageBox.Show("Player 2 wins the game!");
                ResetGame();
            }
            else if (roundNumber > 11)
            {
                if (player1Wins > player2Wins)
                    MessageBox.Show("Player 1 wins the game!");
                else if (player2Wins > player1Wins)
                    MessageBox.Show("Player 2 wins the game!");
                else
                    MessageBox.Show("It's a tie!");
                ResetGame();
            }
        }

        private int CalculateDiceResult(int die1, int die2)
        {
            // A kocka kombinációk erősségi sorrendjének kezelése
            if (die1 == 2 && die2 == 1) return 100; // Speciális szabály a 21-es dobásra
            if (die1 == die2) return 90 + die1; // Páros dobások 66-tól 11-ig
            return die1 * 10 + die2; // Egyéb dobások normál értéke
        }

        private void ResetGame()
        {
            player1Wins = 0;
            player2Wins = 0;
            roundNumber = 1;
            labelPlayer1Roll.Text = "Player 1: ";
            labelPlayer2Roll.Text = "Player 2: ";
            labelRoundWinner.Text = "Round winner: ";
            labelGameResult.Text = "Player 1 Wins: 0 | Player 2 Wins: 0";
        }
    }
}
