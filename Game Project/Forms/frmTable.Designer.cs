namespace Game_Project.Forms
{
    partial class frmTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.grpChips = new System.Windows.Forms.GroupBox();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblCashOut = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.pnlPlayerHand = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnlDealerHand = new System.Windows.Forms.Panel();
            this.picPot = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.grpChips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChips
            // 
            this.grpChips.BackColor = System.Drawing.Color.Transparent;
            this.grpChips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpChips.BackgroundImage")));
            this.grpChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpChips.Controls.Add(this.btn20);
            this.grpChips.Controls.Add(this.btn50);
            this.grpChips.Controls.Add(this.btn100);
            this.grpChips.Controls.Add(this.btn10);
            this.grpChips.Controls.Add(this.btn5);
            this.grpChips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpChips.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChips.ForeColor = System.Drawing.Color.White;
            this.grpChips.Location = new System.Drawing.Point(0, 179);
            this.grpChips.Name = "grpChips";
            this.grpChips.Size = new System.Drawing.Size(188, 636);
            this.grpChips.TabIndex = 0;
            this.grpChips.TabStop = false;
            this.grpChips.Text = "Chips";
            this.grpChips.Enter += new System.EventHandler(this.GrpChips_Enter);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.Transparent;
            this.btn20.BackgroundImage = global::Game_Project.Properties.Resources.NicePng_poker_chips_png_594998;
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20.ForeColor = System.Drawing.Color.Black;
            this.btn20.Location = new System.Drawing.Point(48, 285);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(93, 84);
            this.btn20.TabIndex = 4;
            this.btn20.Text = "$20";
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.Btn20_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.Transparent;
            this.btn50.BackgroundImage = global::Game_Project.Properties.Resources.NicePng_poker_chips_png_594938;
            this.btn50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn50.ForeColor = System.Drawing.Color.Black;
            this.btn50.Location = new System.Drawing.Point(48, 375);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(93, 88);
            this.btn50.TabIndex = 3;
            this.btn50.Text = "$50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.Btn50_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.Transparent;
            this.btn100.BackgroundImage = global::Game_Project.Properties.Resources.NicePng_poker_chips_png_594546;
            this.btn100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.ForeColor = System.Drawing.Color.Black;
            this.btn100.Location = new System.Drawing.Point(48, 469);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(93, 79);
            this.btn100.TabIndex = 2;
            this.btn100.Text = "$100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.Btn100_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Transparent;
            this.btn10.BackgroundImage = global::Game_Project.Properties.Resources.NicePng_poker_chips_png_594395;
            this.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10.ForeColor = System.Drawing.Color.Black;
            this.btn10.Location = new System.Drawing.Point(48, 186);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(93, 89);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "$10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.Btn10_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = global::Game_Project.Properties.Resources.NicePng_poker_chips_png_595619;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(48, 99);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 81);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "$5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBank.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.White;
            this.lblBank.Location = new System.Drawing.Point(43, 51);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(82, 26);
            this.lblBank.TabIndex = 2;
            this.lblBank.Text = "Bank ";
            this.lblBank.Click += new System.EventHandler(this.LblBank_Click);
            // 
            // lblCashOut
            // 
            this.lblCashOut.AutoSize = true;
            this.lblCashOut.BackColor = System.Drawing.Color.Transparent;
            this.lblCashOut.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOut.ForeColor = System.Drawing.Color.White;
            this.lblCashOut.Location = new System.Drawing.Point(43, 112);
            this.lblCashOut.Name = "lblCashOut";
            this.lblCashOut.Size = new System.Drawing.Size(122, 26);
            this.lblCashOut.TabIndex = 3;
            this.lblCashOut.Text = "Cash Out";
            this.lblCashOut.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblPot
            // 
            this.lblPot.BackColor = System.Drawing.Color.Transparent;
            this.lblPot.Enabled = false;
            this.lblPot.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.ForeColor = System.Drawing.Color.Yellow;
            this.lblPot.Location = new System.Drawing.Point(874, 655);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(150, 50);
            this.lblPot.TabIndex = 4;
            this.lblPot.Text = "Pot Amount";
            this.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPot.Visible = false;
            this.lblPot.Click += new System.EventHandler(this.LblPot_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Transparent;
            this.btnDeal.BackgroundImage = global::Game_Project.Properties.Resources.hiclipart_com_id_imwmi;
            this.btnDeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeal.Enabled = false;
            this.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeal.Location = new System.Drawing.Point(1061, 549);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(159, 75);
            this.btnDeal.TabIndex = 5;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Visible = false;
            this.btnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Transparent;
            this.btnStand.BackgroundImage = global::Game_Project.Properties.Resources.buttonStock1;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.Enabled = false;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStand.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStand.Location = new System.Drawing.Point(509, 549);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(203, 131);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "STAND";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Transparent;
            this.btnHit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHit.BackgroundImage")));
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHit.Enabled = false;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHit.Location = new System.Drawing.Point(1226, 567);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(182, 99);
            this.btnHit.TabIndex = 7;
            this.btnHit.Text = "Hit!";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // pnlPlayerHand
            // 
            this.pnlPlayerHand.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerHand.Enabled = false;
            this.pnlPlayerHand.Location = new System.Drawing.Point(742, 708);
            this.pnlPlayerHand.Name = "pnlPlayerHand";
            this.pnlPlayerHand.Size = new System.Drawing.Size(840, 316);
            this.pnlPlayerHand.TabIndex = 8;
            this.pnlPlayerHand.Visible = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "ace_of_spades.png");
            this.imgList.Images.SetKeyName(1, "2_of_spades.png");
            this.imgList.Images.SetKeyName(2, "3_of_spades.png");
            this.imgList.Images.SetKeyName(3, "4_of_spades.png");
            this.imgList.Images.SetKeyName(4, "5_of_spades.png");
            this.imgList.Images.SetKeyName(5, "6_of_spades.png");
            this.imgList.Images.SetKeyName(6, "7_of_spades.png");
            this.imgList.Images.SetKeyName(7, "8_of_spades.png");
            this.imgList.Images.SetKeyName(8, "9_of_spades.png");
            this.imgList.Images.SetKeyName(9, "10_of_spades.png");
            this.imgList.Images.SetKeyName(10, "jack_of_spades2.png");
            this.imgList.Images.SetKeyName(11, "queen_of_spades2.png");
            this.imgList.Images.SetKeyName(12, "king_of_spades2.png");
            this.imgList.Images.SetKeyName(13, "ace_of_clubs.png");
            this.imgList.Images.SetKeyName(14, "2_of_clubs.png");
            this.imgList.Images.SetKeyName(15, "3_of_clubs.png");
            this.imgList.Images.SetKeyName(16, "4_of_clubs.png");
            this.imgList.Images.SetKeyName(17, "5_of_clubs.png");
            this.imgList.Images.SetKeyName(18, "6_of_clubs.png");
            this.imgList.Images.SetKeyName(19, "7_of_clubs.png");
            this.imgList.Images.SetKeyName(20, "8_of_clubs.png");
            this.imgList.Images.SetKeyName(21, "9_of_clubs.png");
            this.imgList.Images.SetKeyName(22, "10_of_clubs.png");
            this.imgList.Images.SetKeyName(23, "jack_of_clubs2.png");
            this.imgList.Images.SetKeyName(24, "queen_of_clubs2.png");
            this.imgList.Images.SetKeyName(25, "king_of_clubs2.png");
            this.imgList.Images.SetKeyName(26, "ace_of_diamonds.png");
            this.imgList.Images.SetKeyName(27, "2_of_diamonds.png");
            this.imgList.Images.SetKeyName(28, "3_of_diamonds.png");
            this.imgList.Images.SetKeyName(29, "4_of_diamonds.png");
            this.imgList.Images.SetKeyName(30, "5_of_diamonds.png");
            this.imgList.Images.SetKeyName(31, "6_of_diamonds.png");
            this.imgList.Images.SetKeyName(32, "7_of_diamonds.png");
            this.imgList.Images.SetKeyName(33, "8_of_diamonds.png");
            this.imgList.Images.SetKeyName(34, "9_of_diamonds.png");
            this.imgList.Images.SetKeyName(35, "10_of_diamonds.png");
            this.imgList.Images.SetKeyName(36, "jack_of_diamonds2.png");
            this.imgList.Images.SetKeyName(37, "queen_of_diamonds2.png");
            this.imgList.Images.SetKeyName(38, "king_of_diamonds2.png");
            this.imgList.Images.SetKeyName(39, "ace_of_hearts.png");
            this.imgList.Images.SetKeyName(40, "2_of_hearts.png");
            this.imgList.Images.SetKeyName(41, "3_of_hearts.png");
            this.imgList.Images.SetKeyName(42, "4_of_hearts.png");
            this.imgList.Images.SetKeyName(43, "5_of_hearts.png");
            this.imgList.Images.SetKeyName(44, "6_of_hearts.png");
            this.imgList.Images.SetKeyName(45, "7_of_hearts.png");
            this.imgList.Images.SetKeyName(46, "8_of_hearts.png");
            this.imgList.Images.SetKeyName(47, "9_of_hearts.png");
            this.imgList.Images.SetKeyName(48, "10_of_hearts.png");
            this.imgList.Images.SetKeyName(49, "jack_of_hearts2.png");
            this.imgList.Images.SetKeyName(50, "queen_of_hearts2.png");
            this.imgList.Images.SetKeyName(51, "king_of_hearts2.png");
            this.imgList.Images.SetKeyName(52, "card back purple.png");
            // 
            // pnlDealerHand
            // 
            this.pnlDealerHand.BackColor = System.Drawing.Color.Transparent;
            this.pnlDealerHand.Enabled = false;
            this.pnlDealerHand.Location = new System.Drawing.Point(742, 162);
            this.pnlDealerHand.Name = "pnlDealerHand";
            this.pnlDealerHand.Size = new System.Drawing.Size(840, 316);
            this.pnlDealerHand.TabIndex = 9;
            this.pnlDealerHand.Visible = false;
            // 
            // picPot
            // 
            this.picPot.BackColor = System.Drawing.Color.Transparent;
            this.picPot.BackgroundImage = global::Game_Project.Properties.Resources.kisspng_gold_coin_leprechaun_money_gold_pot_5ac31174a95299_4293746815227334286936;
            this.picPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPot.Enabled = false;
            this.picPot.Location = new System.Drawing.Point(878, 522);
            this.picPot.Name = "picPot";
            this.picPot.Size = new System.Drawing.Size(146, 112);
            this.picPot.TabIndex = 10;
            this.picPot.TabStop = false;
            this.picPot.Visible = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::Game_Project.Properties.Resources._580b57fcd9996e24bc43c4fc;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(1710, 12);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(36, 33);
            this.picPlay.TabIndex = 11;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.PicPlay_Click);
            // 
            // picPause
            // 
            this.picPause.BackColor = System.Drawing.Color.Transparent;
            this.picPause.BackgroundImage = global::Game_Project.Properties.Resources._24c5909801ae3483cb100b0584265d48;
            this.picPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPause.Location = new System.Drawing.Point(1752, 12);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(36, 33);
            this.picPause.TabIndex = 12;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = global::Game_Project.Properties.Resources.icons8_next_page_96;
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNext.Location = new System.Drawing.Point(1794, 12);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(36, 33);
            this.picNext.TabIndex = 13;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.PicNext_Click);
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImage = global::Game_Project.Properties.Resources.icons8_back_to_96;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBack.Location = new System.Drawing.Point(1668, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(36, 33);
            this.picBack.TabIndex = 14;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::Game_Project.Properties.Resources.Red_Close_Button_Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(1868, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(44, 40);
            this.picClose.TabIndex = 15;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Project.Properties.Resources.poker_table_background_77211_140;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picPot);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.pnlDealerHand);
            this.Controls.Add(this.pnlPlayerHand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.lblCashOut);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.grpChips);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTable";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.FrmTable_Load);
            this.grpChips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChips;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblCashOut;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Panel pnlPlayerHand;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel pnlDealerHand;
        private System.Windows.Forms.PictureBox picPot;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picClose;
    }
}