/*
 * Rawnaz Anam Blackjack Project
 * Due date 11/11/2019
 * This is the game form
 * this handles a lot of the logic of the game 
 * and how the game should handle user input and AI input
 */

using Game_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game_Project.Forms
{


    public partial class frmTable : Form
    {
        WindowsMediaPlayer song = new WindowsMediaPlayer(); //creates a instance of WMP for music
        //Attributes for the game
        private Player Bond;
        private decimal startCash =1000;
        private Hand dealerHand = new Hand();
        private Hand playerHand = new Hand();
       
        private decimal currentAmnt;
        private decimal totalBet;
        private Dealer hustler = new Dealer();
        private Size size = new Size(163, 213);
        private int PlayerHitCount = 0;
        private int DealerHitCount = 0;
        Button DealerCard;
        Point PlayerPanelLocation;
        Point DealerPanelLocation;
        string[] songCollection = new string[6];
        int songCounter = 0;
        public frmTable()//also assigns selected song to an array for music player
        {
            InitializeComponent();
            song.URL = "kick.mp3";
            songCollection[0]= "kick.mp3";
            songCollection[1]= "bluemoon.mp3";
            songCollection[2] = "moon.mp3";
            songCollection[3] = "tl.mp3";
            songCollection[4] = "bbb.mp3";
            songCollection[5] = "eats.mp3";

        }


        private void FrmTable_Load(object sender, EventArgs e) // Upon load the form would maximize 
        {
            Bond = new Player(frmStart.name, startCash); // creating player object

            lblBank.Text = Bond.getName()+"  Balance " + Bond.getAmount().ToString("c"); //updating player details
            PlayerPanelLocation = pnlPlayerHand.Location; //storing the location of panel for later
            DealerPanelLocation = pnlDealerHand.Location;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            song.controls.play(); // starts song

        }

        private void Label1_Click(object sender, EventArgs e) //Cash out would show amount cashing out and amount won or lost
        {
            decimal k = Bond.getAmount();
            
            string end = Bond.getAmount().ToString("c");
            if (k < 1000)
            {
                k = 1000 - k;
                MessageBox.Show("You are cashing out " + end + "\n" + "you lost $" + k);
                this.Close();
            }
            else
            {
                k = k- 1000;
                MessageBox.Show("You are cashing out " + end + "\n" + "you won $" + k);
                this.Close();
            }
            
        }

        public void clickChip()
        {
             currentAmnt = Bond.getAmount();
            if (currentAmnt >= 100)
            {
                btn100.Enabled = true;
                btn100.Visible = true;
               
            }
            else
            {
                btn100.Enabled = false;
                btn100.Visible = false;
            }
            if (currentAmnt >= 50)
            {
                btn50.Enabled = true;
                btn50.Visible = true;
            }
            else
            {
                btn50.Enabled = false;
                btn50.Visible = false;
            }
            if (currentAmnt >= 20)
            {
                btn20.Enabled = true;
                btn20.Visible = true;
            }
            else
            {
                btn20.Enabled = false;
                btn20.Visible = false;
            }
            if (currentAmnt >= 10)
            {
                btn10.Enabled = true;
                btn10.Visible = true;
            }
            else
            {
                btn10.Enabled = false;
                btn10.Visible = false;
            }
            if (currentAmnt >= 5)
            {
                btn5.Enabled = true;
                btn5.Visible = true;
            }
            else
            {
                btn5.Enabled = false;
                btn5.Visible = false;
            }
        } //This Method enables or disables chips depending on the money player has.

        private void LblBank_Click(object sender, EventArgs e) //not used
        {

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            totalBet += 5;
            currentAmnt -= 5;
            Bond.playerLost(5);
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            lblPot.Enabled = true;
            lblPot.Visible = true;
            lblPot.Text = "Pot amount \n     " + totalBet;
            btnDeal.Enabled = true;
            btnDeal.Visible = true;
            picPot.Enabled = true;
            picPot.Visible = true;
            clickChip();
        } //the following button clicks are chips to be assisgned to the pot and calls the click chip method

        private void Btn100_Click(object sender, EventArgs e)
        {
            totalBet += 100;
            currentAmnt -= 100;
            Bond.playerLost(100);
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            lblPot.Enabled = true;
            lblPot.Visible = true;
            lblPot.Text = "Pot amount \n     " + totalBet;
            btnDeal.Enabled = true;
            btnDeal.Visible = true;
            picPot.Enabled = true;
            picPot.Visible = true;
            clickChip();
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            totalBet += 50;
            currentAmnt -= 50;
            Bond.playerLost(50);
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            lblPot.Enabled = true;
            lblPot.Visible = true;
            lblPot.Text = "Pot amount \n     " + totalBet;
            btnDeal.Enabled = true;
            btnDeal.Visible = true;
            picPot.Enabled = true;
            picPot.Visible = true;
            clickChip();
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            totalBet += 20;
            currentAmnt -= 20;
            Bond.playerLost(20);
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            lblPot.Enabled = true;
            lblPot.Visible = true;
            lblPot.Text = "Pot amount \n     " + totalBet;
            btnDeal.Enabled = true;
            btnDeal.Visible = true;
            picPot.Enabled = true;
            picPot.Visible = true;
            clickChip();
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            totalBet += 10;
            currentAmnt -= 10;
            Bond.playerLost(10);
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            lblPot.Enabled = true;
            lblPot.Visible = true;
            lblPot.Text = "Pot amount \n     " + totalBet;
            btnDeal.Enabled = true;
            btnDeal.Visible = true;
            picPot.Enabled = true;
            picPot.Visible = true;
            clickChip();
        }

        private void GrpChips_Enter(object sender, EventArgs e)
        {

        }
        
        private void BtnDeal_Click(object sender, EventArgs e) //When deal button is clicked diables betting and enables player control
        {

            hustler.ShuffleDeck(); // Calls dealers shuffle method as dealers shuffle

            pnlPlayerHand.Visible = true;
            pnlPlayerHand.Enabled = true;
            grpChips.Enabled = false;
            grpChips.Visible = false;
            lblCashOut.Enabled = false;
            pnlPlayerHand.Enabled = true;
            pnlPlayerHand.Visible = true;
            pnlDealerHand.Enabled = true;
            pnlDealerHand.Visible = true;

            
            btnHit.Enabled = true;
            btnHit.Visible = true;
            btnStand.Enabled = true;
            btnStand.Visible = true;
            
            btnDeal.Enabled = false;
            btnDeal.Visible = false;
            DealCards(); // calls deal card method below
        }
        public void DealCards() // deals 2 cards to player and 2 cards for dealer
        {
         

            Button card1 = new Button();
            Button card2 = new Button();
            Button card3 = new Button();
            Button card4 = new Button();

             

            Card temp = hustler.dealCard();
            playerHand.addCard(temp);
            card1.Size = size;
            card1.BackgroundImage = imgList.Images[temp.getImageIndex()];
            card1.BackgroundImageLayout = ImageLayout.Stretch;

            pnlPlayerHand.Controls.Add(card1);
            card2.Size = size;
            temp = hustler.dealCard();
            dealerHand.addCard(temp);
            card2.BackgroundImage = imgList.Images[52];
            card2.BackgroundImageLayout = ImageLayout.Stretch;
            DealerCard = card2;
           
            pnlDealerHand.Controls.Add(card2);

            card3.Size = size;
            Point p = card1.Location;
            temp = hustler.dealCard();
            playerHand.addCard(temp);
            card3.BackgroundImage = imgList.Images[temp.getImageIndex()];
            card3.BackgroundImageLayout = ImageLayout.Stretch;
            card3.Location = new Point(p.X + 100, p.Y);
            pnlPlayerHand.Controls.Add(card3);
            card3.BringToFront();

            card4.Size = size;
            temp = hustler.dealCard();
            dealerHand.addCard(temp);
            Point p2 = card2.Location;

            card4.BackgroundImage = imgList.Images[temp.getImageIndex()];
            card4.BackgroundImageLayout = ImageLayout.Stretch;
            card4.Location = new Point(p2.X + 100, p2.Y);
            pnlDealerHand.Controls.Add(card4);
            card4.BringToFront();
            //MessageBox.Show("" + playerHand.getHandValue()); //Check player card value after deal you can uncomment this to get the card value
            if (playerHand.getHandValue() == 21 && dealerHand.getHandValue() == 21) // Handles BlackJack if player gets 21 upon deal
            {
                DealerCard.BackgroundImage = imgList.Images[dealerHand.flipDealerCard().getImageIndex()]; //flips dealer card that is upside down
                MessageBox.Show("What a coincidence! STANDOFF!");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value
                Bond.playerWin(totalBet);
                clearTable();

            }
            else if (playerHand.getHandValue() == 21)
            {
                DealerCard.BackgroundImage = imgList.Images[dealerHand.flipDealerCard().getImageIndex()];//flips dealer card that is upside down
                MessageBox.Show("BlackJack!");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value
                decimal winAmount = totalBet * 2.50m; // player win is 3/2 pot amount when blackjack
                Bond.playerWin(winAmount);
                clearTable();

            }

        }

        private void BtnHit_Click(object sender, EventArgs e)
        {

            hit("player"); // calls hit method for player 
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            dealerTurn(); // goes to dealer turn method below

        }
      
        public void hit(string hand) // gets one card from top of deck for both player or dealer
        {

            Button hitCard = new Button();
            hitCard.Size = size;
            Card temp = hustler.dealCard();

            if (hand.Equals("player")) // if player hits
            {
                playerHand.addCard(temp);

                Point p = pnlPlayerHand.Location;
                hitCard.BackgroundImage = imgList.Images[temp.getImageIndex()];// assigns card image for card assign
                hitCard.BackgroundImageLayout = ImageLayout.Stretch;
                hitCard.Location = new Point(200 + PlayerHitCount * 100, 0);
                PlayerHitCount++;
                pnlPlayerHand.Location = new Point(p.X - 75, p.Y);
                pnlPlayerHand.Controls.Add(hitCard);
                hitCard.BringToFront();
                //MessageBox.Show("" + playerHand.getHandValue());//Check player card value un comment 
                if (playerHand.getHandValue() >= 21) // stops player hitting if value is over 21 or equals and handles bust
                {
                    if (playerHand.getHandValue() > 21)
                    {
                        MessageBox.Show("Buster you busted");
                    }
                    else
                    {
                        MessageBox.Show("Hand value is 21 don't be stupid to hit again");
                    }
                    dealerTurn();
                    
                }
               


            }
            else if (hand.Equals("dealer")) // if dealer hits
            {
                dealerHand.addCard(temp);
                Point p = pnlDealerHand.Location;
                System.Threading.Thread.Sleep(1000);
                hitCard.BackgroundImage = imgList.Images[temp.getImageIndex()];
                hitCard.BackgroundImageLayout = ImageLayout.Stretch;
                hitCard.Location = new Point(200 + DealerHitCount * 100, 0);
                DealerHitCount++;
                pnlDealerHand.Location = new Point(p.X - 75, p.Y);
                pnlDealerHand.Controls.Add(hitCard);
                hitCard.BringToFront();
                hitCard.Refresh();
               
           
            }
        }
        private void LblPot_Click(object sender, EventArgs e)
        {

        }

        public void dealerTurn() // handles dealers turn when players turn is over
        {
            btnHit.Enabled = false;
            btnHit.Visible = false;
            btnStand.Enabled = false;
            btnStand.Visible = false;
            System.Threading.Thread.Sleep(1000);
            DealerCard.BackgroundImage = imgList.Images[dealerHand.flipDealerCard().getImageIndex()];//flips dealer card that is upside down
            DealerCard.Refresh();
            
            //this is the dealer's turn
            while (hustler.decideMove(dealerHand.getHandValue(), playerHand.getHandValue(), dealerHand.hasAce()))
            {
                hit("dealer");
            }
            
            //evaluate hands after dealer finishes playing
            if (playerHand.getHandValue() == dealerHand.getHandValue()) //this is a push
            {

                MessageBox.Show("We got ourself a standoff here ladies & gents");
               MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() +"\n" +"Player Hand Value "+playerHand.getHandValue());//Check Dealer hand card value
                Bond.playerWin(totalBet);
                    
            }
           
            else if (dealerHand.getHandValue() > 21) //dealer busted
            {
                MessageBox.Show("Player Won; The dealer made a oopsie and busted");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value
                decimal winAmount = totalBet * 2;
                Bond.playerWin(winAmount);
            }
            else if (playerHand.getHandValue() > 21) //player busted
            {
                MessageBox.Show("The House always wins baby");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value

            }
            else if (playerHand.getHandValue() > dealerHand.getHandValue()) //player wins w/o dealer busting
            {
                MessageBox.Show("Player Won");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value
                decimal winAmount = totalBet * 2;
                Bond.playerWin(winAmount);
            }
            else if (playerHand.getHandValue() < dealerHand.getHandValue() && dealerHand.getHandValue()<=21) //dealer wins w/o player busting
            {
                MessageBox.Show("The House always wins baby");
                MessageBox.Show("Dealer Hand Value  " + dealerHand.getHandValue() + "\n" + "Player Hand Value " + playerHand.getHandValue());//Check Dealer hand card value

            }


            clearTable();

            
        }

        public void clearTable() // This method clears table for next round
        {
            btnHit.Enabled = false;
            btnHit.Visible = false;
            btnStand.Enabled = false;
            btnStand.Visible = false;
            lblBank.Text = Bond.getName() + "  Balance " + Bond.getAmount().ToString("c");
            totalBet = 0;
            pnlDealerHand.Controls.Clear();
            pnlPlayerHand.Controls.Clear();
            pnlDealerHand.Location = DealerPanelLocation;
            pnlPlayerHand.Location = PlayerPanelLocation;
            grpChips.Enabled = true;
            grpChips.Visible = true;
            lblCashOut.Enabled = true;
            picPot.Enabled = false;
            picPot.Visible = false;
            lblPot.Visible = false;
            lblPot.Enabled = false;
            DealerHitCount = 0;
            PlayerHitCount = 0;

            //put cards back in deck
            hustler.pickUpCards(playerHand.getCards());
            hustler.pickUpCards(dealerHand.getCards());

            //reset hand attributes
            playerHand.resetHand();
            dealerHand.resetHand();
            clickChip();

            if (Bond.getAmount() == 0) // Check to see if player is out of money
            {
                MessageBox.Show("Go home Loser!");
                this.Close();
            }

        }

        private void PicPlay_Click(object sender, EventArgs e)//Music player play button
        {
            song.controls.play();
        }

        private void PictureBox1_Click(object sender, EventArgs e) // music player pause button
        {
            song.controls.pause();
        }

        private void PicNext_Click(object sender, EventArgs e)//music player next button
        {
            if (songCounter == 5)
            {
                songCounter = 0;
            }
            else
            {
                songCounter++;
            }
            song.URL = songCollection[songCounter];
        }

        private void PicBack_Click(object sender, EventArgs e) //music player previous button
        {
            if (songCounter == 0)
            {
                songCounter = 5;
            }
            else
            {
                songCounter--;
            }
            
            song.URL = songCollection[songCounter];
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)// closes out game
        {
            this.Close();
        }
    }
    }

