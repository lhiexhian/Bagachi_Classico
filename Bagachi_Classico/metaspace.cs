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

        void RefreshCoin()
        {
            //if attack was performed, reduce coin by 1
            //else if block was performed, that attack does no damage
            //else if heal was performed, increase coin by 1 (max 3)
            // Update coin UI accordingly
            // take account of who went first
            // take account of what action the opponent took
            // Consider both Scenarios: Player goes first, Enemy goes first

            //if (playerGoesFirst)
            //    switch (pendingAction)
            //    {
            //        case 1: // attack
            //            if (coin2 > 0)
            //            { 
            //                if (action2 != 2)
            //                {
            //                    coinValue2.Location = new Point(coinValue2.Location.X - 50, coinValue2.Location.Y);
            //                    coin2--;
            //                }
            //            }
            //            break;
            //        case 2: // block
            //            break;
            //        case 3: // heal
            //            if (coin < 3) 
            //            { 
            //                coin++;
            //                coinValue.Location = new Point(coinValue.Location.X + 50, coinValue.Location.Y);
            //            } 
            //            break;
            //    }
            //else
            //{
            //    switch (pendingAction)
            //    {
            //        case 1: // attack
            //            if (coin > 0)
            //            {
            //                if (action != 2)
            //                {
            //                    coinValue.Location = new Point(coinValue.Location.X - 50, coinValue.Location.Y);
            //                    coin--;
            //                }
            //            }
            //            break;
            //        case 2: // block
            //            break;
            //        case 3: // heal
            //            if (coin2 < 3)
            //            {
            //                coin2++;
            //                coinValue2.Location = new Point(coinValue2.Location.X + 50, coinValue2.Location.Y);
            //            }
            //            break;
            //    }
            //}
            if (playerGoesFirst)
            {
                // Player's action
                if (pendingAction == 1 && coin2 > 0 && action2 != 2) // attack
                {
                    coin2--;
                    coinValue2.Location = new Point(coinValue2.Location.X - 50, coinValue2.Location.Y);
                }
                else if (pendingAction == 3 && coin < 3) // heal
                {
                    coin++;
                    coinValue.Location = new Point(coinValue.Location.X + 50, coinValue.Location.Y);
                }
                // Enemy's action
                if (action2 == 1 && coin > 0 && pendingAction != 2) // attack
                {
                    coin--;
                    coinValue.Location = new Point(coinValue.Location.X - 50, coinValue.Location.Y);
                }
                else if (action2 == 3 && coin2 < 3) // heal
                {
                    coin2++;
                    coinValue2.Location = new Point(coinValue2.Location.X + 50, coinValue2.Location.Y);
                }
            }
            else
            {
                // Enemy's action
                if (action2 == 1 && coin > 0 && pendingAction != 2) // attack
                {
                    coin--;
                    coinValue.Location = new Point(coinValue.Location.X - 50, coinValue.Location.Y);
                }
                else if (action2 == 3 && coin2 < 3) // heal
                {
                    coin2++;
                    coinValue2.Location = new Point(coinValue2.Location.X + 50, coinValue2.Location.Y);
                }
                // Player's action
                if (pendingAction == 1 && coin2 > 0 && action2 != 2) // attack
                {
                    coin2--;
                    coinValue2.Location = new Point(coinValue2.Location.X - 50, coinValue2.Location.Y);
                }
                else if (pendingAction == 3 && coin < 3) // heal
                {
                    coin++;
                    coinValue.Location = new Point(coinValue.Location.X + 50, coinValue.Location.Y);
                }
            }
        }

        void ChooseAction(int actionType)
        {
            pendingAction = actionType;


            // Let the player guess
            GuessOddEven goe = new GuessOddEven();
            goe.ShowDialog();

            dice.Visible = true;
            diceTime.Start();
        }

        void StartTurnOrder()
        {
            if (playerGoesFirst)
            {
                performTurn(pendingAction);
                PerformEnemyTurn();
                RefreshCoin();
            }
            else
            {
                PerformEnemyTurn();
                performTurn(pendingAction);
                RefreshCoin();
            }
        }
        void AnimateP2(int act)
        {
            action2 = act;
            counter2 = 0;
        }
        void PerformEnemyTurn()
        {
            Random r = new Random();
            //action2 = 1;
            action2 = r.Next(1, 4);
            AnimateP2(action2);
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
            Thread.Sleep(500);
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

    }
}
