using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagachi_Classico
{

    public partial class metaspace : Form
    {

        int pendingAction = 0;
        int pendingAction2 = 0;
        bool playerGoesFirst = false;
        Random rnd = new Random();

        int counter = 0;
        int counter2 = 0;
        int action = 0;
        int action2 = 0;
        int coin = 3;
        int coin2 = 3;
        int rngCounter = 0;
        int mil = 0;
        int days = 0;
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int milliseconds = 0;

        // Flicker animation state
        private int flickerTicksP1 = 0;
        private int flickerTicksP2 = 0;
        private const int FlickerTickCount = 6; // total toggles (adjust for faster/slower flicker)
        private const int FlickerIntervalMs = 100; // interval per toggle

        void RefreshCoin(int a, PictureBox ap, ref int ac, int b, PictureBox bp, ref int bc)
        {

            int oldAc = ac;
            int oldBc = bc;

            if (a == 1 && b == 1) bc = Math.Max(bc - 1, 0);

            if (b == 1 && a == 1) ac = Math.Max(ac - 1, 0);

            if (a == 3 && b != 1) ac = Math.Min(ac + 1, 3);

            if (b == 3 && a != 1) bc = Math.Min(bc + 1, 3);

            // Update visuals
            UpdateCoinUI(ac, ap);
            UpdateCoinUI(bc, bp);

            // Start flicker animation when a player's coin count is reduced
            if (ac < oldAc)
            {
                StartFlickerP1();
            }

            if (bc < oldBc)
            {
                StartFlickerP2();
            }

            if (ac == 0 || bc == 0) GameOver();
        }

        void UpdateCoinUI(int amount, PictureBox p)
        {
            switch (amount)
            {
                case 0: p.Image = Bagachi_Classico.Properties.Resources.health4; break;
                case 1: p.Image = Bagachi_Classico.Properties.Resources.health3; break;
                case 2: p.Image = Bagachi_Classico.Properties.Resources.health2; break;
                case 3: p.Image = Bagachi_Classico.Properties.Resources.health1; break;
                default: break;
            }
        }

        void GameOver()
        {
            // 1. Determine winner
            if (coin == coin2)
            {
                sharedAppData.winner = "DRAW";
            }
            else if (coin == 0)
            {
                sharedAppData.winner = "Player 2 wins";
            }
            else
            {
                sharedAppData.winner = "Player 1 wins";
            }

            // 2. Update points, wins, and loses
            using (SqlConnection conn = new SqlConnection(sharedAppData.conString))
            {
                string selectQuery = "SELECT HighScore, Win, Lose FROM Accounts WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", sharedAppData.Id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int currentHighScore = 0;
                        int wins = 0;
                        int loses = 0;

                        if (reader.Read())
                        {
                            currentHighScore = reader.GetInt32(0);
                            wins = reader.GetInt32(1);
                            loses = reader.GetInt32(2);
                        }

                        reader.Close();

                        bool isDraw = coin == coin2;
                        bool player1Wins = coin > coin2;
                        bool player2Wins = coin < coin2;

                        if (isDraw)
                            sharedAppData.winner = "DRAW";
                        else if (player1Wins)
                            sharedAppData.winner = "Player 1 wins";
                        else
                            sharedAppData.winner = "Player 2 wins";

                        // 2. Calculate points
                        int baseWinPoints = 50;
                        int drawPoints = 20;
                        //coinMultiplier based on how many time has passed

                        int coinMultiplier = (seconds/30) * (10/baseWinPoints) + 10;

                        int player1Points = 0;

                        if (isDraw)
                        {
                            player1Points = drawPoints + (coin * coinMultiplier / 2) + (baseWinPoints * coinMultiplier / 2);
                            sharedAppData.score = player1Points;
                        }
                        else if (player1Wins)
                        {
                            player1Points = baseWinPoints + (coin * coinMultiplier) + (baseWinPoints * coinMultiplier / 2);
                            sharedAppData.score = player1Points;
                        }
                        else // player2Wins
                        {
                            player1Points = coin + (baseWinPoints * coinMultiplier / 2);
                            sharedAppData.score = player1Points;
                        }
                        sharedAppData.score = player1Points;
                        // Update highscore if newPoints > currentHighScore
                        if (player1Points > currentHighScore)
                            currentHighScore = player1Points;


                        // Update wins/loses
                        if (sharedAppData.winner == "Player 1 wins")
                            wins += 1;
                        else if (sharedAppData.winner == "Player 2 wins")
                            loses += 1;
                        sharedAppData.Wins = wins;
                        sharedAppData.Loses = loses;

                        sharedAppData.hscore = currentHighScore;
                        // Update the database
                        string updateQuery = "UPDATE Accounts SET HighScore = @HighScore, Win = @Wins, Lose = @Loses WHERE Id = @Id";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@HighScore", currentHighScore);
                            updateCmd.Parameters.AddWithValue("@Wins", wins);
                            updateCmd.Parameters.AddWithValue("@Loses", loses);
                            updateCmd.Parameters.AddWithValue("@Id", sharedAppData.Id);

                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            // 3. Show Game Over dialog
            gameOver go = new gameOver();
            go.ShowDialog();

            // 4. Close the current game form
            this.Close();
        }


        void ChooseAction(int actionType)
        {
            pendingAction = actionType;

            if (!sharedAppData.keepChoice)
            {
                // Let the player guess
                GuessOddEven goe = new GuessOddEven();
                goe.ShowDialog();
                timer2.Start();
            }


            dice.Visible = true;
            diceTime.Start();
        }

        void StartTurnOrder()
        {
            if (playerGoesFirst)
            {
                performTurn(pendingAction);
                PerformEnemyTurn();
                RefreshCoin(pendingAction, coinValue, ref coin, action2, coinValue2, ref coin2);
            }
            else
            {
                PerformEnemyTurn();
                performTurn(pendingAction);
                RefreshCoin(action2, coinValue2, ref coin2, pendingAction, coinValue, ref coin);
            }
        }
        void AnimateP2(int act)
        {
            action2 = act;
            counter2 = 0;
        }
        void PerformEnemyTurn()
        {
            //action2 = 1;
            int temp = rnd.Next(100);

            if (coin2 == 3 && temp < 50) // full health, attack
            {
                AnimateP2(1);
            }
            else if (temp < 10 || (coin2 < 2 && temp == 40)) // 10% chance to heal, more likely if coins are low
            {
                AnimateP2(3); // heal
            }
            else if (temp < 70 || (coin2 > 1 && temp < 80)) // 60% chance to attack, more likely if coins are high
            {
                AnimateP2(1); // attack
            }
            else if (temp < 100 || (coin2 < 3 && temp < 30)) // 30% chance to block, more likely if coins are low
            {
                AnimateP2(2); // block
            }
            else // default to idle
            {
                AnimateP2(2);
            }
        }
        void performTurn(int a)
        {
            action = a;
            counter = 0;
        }
        public metaspace()
        {
            InitializeComponent();

            // safe image flip (guard against null)
            if (P2?.Image != null)
                P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            dice.Visible = false;

            // initialize flicker timers
            flickerTimerP1.Interval = FlickerIntervalMs;
            flickerTimerP1.Tick += FlickerTimerP1_Tick;

            flickerTimerP2.Interval = FlickerIntervalMs;
            flickerTimerP2.Tick += FlickerTimerP2_Tick;

            // don't start timer1 here — start in Shown where the form is displayed
            // timer1.Start();
        }

        private void UpdatePlayer1Animation()
        {
            switch (action)
            {
                case 0:
                    ShowFrame(P1, "Idle", 4, counter, ref action, false);
                    break;
                case 1:
                    ShowFrame(P1, "attack", 4, counter, ref action, true);

                    break;
                case 2:
                    ShowFrame(P1, "block", 4, counter, ref action, true);
                    break;
                case 3:
                    ShowFrame(P1, "heal", 4, counter, ref action, true);
                    break;
            }
        }

        private void UpdatePlayer2Animation()
        {
            switch (action2)
            {
                case 0:
                    ShowFrame(P2, "Idle", 4, counter2, ref action2, false);
                    break;
                case 1:
                    ShowFrame(P2, "attack", 4, counter2, ref action2, true);
                    break;
                case 2:
                    ShowFrame(P2, "block", 4, counter2, ref action2, true);
                    break;
                case 3:
                    ShowFrame(P2, "heal", 4, counter2, ref action2, true);
                    break;
            }

            if (P2?.Image != null)
                P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }
        private void ShowFrame(PictureBox pic, string animName, int totalFrames, int localCounter, ref int actionVar, bool reset = false)
        {
            int frame = localCounter % totalFrames;
            int frameNumber = frame + 1;


            string key = $"{animName}{frameNumber}";

            Image img = Bagachi_Classico.Properties.Resources.ResourceManager.GetObject(key) as Image;

            if (img != null)
            {
                pic.Image = img;
            }

            if (frame == totalFrames - 1 && reset)
            {
                actionVar = 0;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing) return;

            UpdatePlayer1Animation();
            UpdatePlayer2Animation();

            counter++;
            counter2++;
        }

        private void attack_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(1);
            attack_btn.BackgroundImage = Properties.Resources.button_pressed;
        }

        private void block_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(2);
            block_btn.BackgroundImage = Properties.Resources.button_pressed;
        }

        private void heal_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(3);
            heal_btn.BackgroundImage = Properties.Resources.button_pressed;
        }


        private void diceTime_Tick(object sender, EventArgs e)
        {
            int rng = rnd.Next(1, 6);

            // Display dice frame
            dice.Image = Bagachi_Classico.Properties.Resources.ResourceManager
                .GetObject($"dice{rng}") as Image;

            if (rngCounter < 30)
            {
                rngCounter++;
                return; //break loop until enough ticks
            }

            diceTime.Stop();
            rngCounter = 0;
            dice.Visible = false;

            bool correctGuess =
                (sharedAppData.guess && rng % 2 == 0) ||      // guessed EVEN and RNG is even
                (!sharedAppData.guess && rng % 2 != 0);       // guessed ODD and RNG is odd

            if (correctGuess)
            {
                label1.Text = "P1 > P2";
                playerGoesFirst = true;
            }
            else
            {
                label1.Text = "P2 > P1";
                playerGoesFirst = false;
            }

            StartTurnOrder();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mil += 100;
            days = (mil / 1000) / 86400;
            hours = (mil / 1000) / 3600;
            minutes = (mil / 1000) / 60;
            seconds = (mil / 1000) % 60;
            milliseconds = mil % 1000;
        }

        private void metaspace_Load(object sender, EventArgs e)
        {

        }

        private void metaspace_Shown(object sender, EventArgs e)
        {
            label1.Text = $"welcome {sharedAppData.Username}";
            if (!timer1.Enabled)
                timer1.Start();
        }

        // Flicker timer handlers and helpers
        private void StartFlickerP1()
        {
            // if already flickering, reset the count to full duration
            flickerTicksP1 = FlickerTickCount;
            flickerTimerP1?.Start();
        }

        private void StartFlickerP2()
        {
            flickerTicksP2 = FlickerTickCount;
            flickerTimerP2?.Start();
        }

        private void FlickerTimerP1_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                flickerTimerP1.Stop();
                return;
            }

            if (flickerTicksP1 <= 0)
            {
                flickerTimerP1.Stop();
                if (P1 != null) P1.Visible = true;
                return;
            }

            if (P1 != null)
                P1.Visible = !P1.Visible;

            flickerTicksP1--;
            if (flickerTicksP1 == 0)
            {
                if (P1 != null) P1.Visible = true;
                flickerTimerP1.Stop();
            }
        }

        private void FlickerTimerP2_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                flickerTimerP2.Stop();
                return;
            }

            if (flickerTicksP2 <= 0)
            {
                flickerTimerP2.Stop();
                if (P2 != null) P2.Visible = true;
                return;
            }

            if (P2 != null)
                P2.Visible = !P2.Visible;

            flickerTicksP2--;
            if (flickerTicksP2 == 0)
            {
                if (P2 != null) P2.Visible = true;
                flickerTimerP2.Stop();
            }
        }

        private void attack_btn_MouseHover(object sender, EventArgs e)
        {
            attack_btn.BackgroundImage = Properties.Resources.button_hover;
        }
        private void block_btn_MouseHover(object sender, EventArgs e)
        {
            block_btn.BackgroundImage = Properties.Resources.button_hover;
        }
        private void heal_btn_MouseHover(object sender, EventArgs e)
        {
            heal_btn.BackgroundImage = Properties.Resources.button_hover;
        }

        private void atk_btn_MouseLeave(object sender, EventArgs e)
        {
            attack_btn.BackgroundImage = Properties.Resources.button;
        }

        private void block_btn_MouseLeave(object sender, EventArgs e)
        {
            block_btn.BackgroundImage = Properties.Resources.button;
        }

        private void heal_btn_MouseLeave(object sender, EventArgs e)
        {
            heal_btn.BackgroundImage = Properties.Resources.button;
        }
    }
}