using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        int minutes = 0;
        int seconds = 0;
        int milliseconds = 0;

        void RefreshCoin(int a, Panel ap, ref int ac, int b, Panel bp, ref int bc)
        {
            if (a == 1 && b != 2) bc = Math.Max(bc - 1, 0); // A attacks unless B blocked
            if (b == 1 && a != 2) ac = Math.Max(ac - 1, 0); 
            if (a == 3 && b != 1) ac = Math.Min(ac + 1, 3); // A heals if not attacked by B
            if (b == 3 && a != 1) bc = Math.Min(bc + 1, 3); // B heals if not attacked by A

            UpdateCoinUI(ac, ap);
            UpdateCoinUI(bc, bp);
            if (ac == 0 || bc == 0) GameOver();
        }

        void UpdateCoinUI(int amount, Panel p)
        {
            switch (amount)
            {
                case 0: p.Location = new Point(-150, p.Location.Y); break;
                case 1: p.Location = new Point(-100, p.Location.Y); break;
                case 2: p.Location = new Point(-50, p.Location.Y); break;
                case 3: p.Location = new Point(0, p.Location.Y); break;
                default: break;
            }
        }

        void GameOver()
        {
            if (minutes != 0)
                sharedAppData.time = $"{minutes}:{seconds}.{milliseconds}";
            else
                sharedAppData.time = $"{seconds}.{milliseconds}";
            if (coin == coin2 && coin == 0)
            {
                sharedAppData.winner = "DRAW";
            }
                sharedAppData.winner = (coin == 0) ? "Player 2 wins" : "Player 1 wins";
            gameOver go = new gameOver();
            go.ShowDialog();
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
            P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            timer1.Start();
            dice.Visible = false;
            spit.Visible = false;
            spit2.Visible = false;
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
                    int spitAnim = -1;
                    ShowFrame(spit, "spit", 4, counter, ref spitAnim, true);

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
                    int spit2Anim = -1;
                    ShowFrame(spit2, "spit", 4, counter2, ref spit2Anim, true);
                    break;
                case 2:
                    ShowFrame(P2, "block", 4, counter2, ref action2, true);
                    break;
                case 3:
                    ShowFrame(P2, "heal", 4, counter2, ref action2, true);
                    break;
            }

            P2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            spit2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
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
                pic.Visible = true; //to show visibile
            }

            if (frame == totalFrames - 1 && reset)
            {
                actionVar = 0;
                if (pic == spit || pic == spit2) pic.Visible = false;
            } 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePlayer1Animation();
            UpdatePlayer2Animation();

            counter++;
            counter2++;
        }

        private void attack_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(1);
        }

        private void block_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(2);
        }

        private void heal_btn_Click(object sender, EventArgs e)
        {
            ChooseAction(3);
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
            minutes = (mil / 1000) / 60;
            seconds = (mil / 1000) % 60;
            milliseconds = mil % 1000;
        }
    }
}
