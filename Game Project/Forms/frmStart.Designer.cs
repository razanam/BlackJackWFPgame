namespace Game_Project.Forms
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.lblBlackJack = new System.Windows.Forms.Label();
            this.lblGameRules = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBlackJack
            // 
            this.lblBlackJack.AutoSize = true;
            this.lblBlackJack.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackJack.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackJack.ForeColor = System.Drawing.Color.White;
            this.lblBlackJack.Location = new System.Drawing.Point(37, 72);
            this.lblBlackJack.Name = "lblBlackJack";
            this.lblBlackJack.Size = new System.Drawing.Size(357, 79);
            this.lblBlackJack.TabIndex = 0;
            this.lblBlackJack.Text = "BlackJack";
            // 
            // lblGameRules
            // 
            this.lblGameRules.AutoSize = true;
            this.lblGameRules.BackColor = System.Drawing.Color.Transparent;
            this.lblGameRules.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRules.ForeColor = System.Drawing.Color.White;
            this.lblGameRules.Location = new System.Drawing.Point(46, 219);
            this.lblGameRules.Name = "lblGameRules";
            this.lblGameRules.Size = new System.Drawing.Size(156, 26);
            this.lblGameRules.TabIndex = 1;
            this.lblGameRules.Text = "Game Rules";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.Location = new System.Drawing.Point(47, 307);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(573, 240);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(51, 610);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(142, 37);
            this.txtPlayerName.TabIndex = 4;
            this.txtPlayerName.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Game_Project.Properties.Resources.glossy_rectangle_button_204630;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(244, 597);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(131, 56);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // frmStart
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Project.Properties.Resources.blackjack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 762);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblGameRules);
            this.Controls.Add(this.lblBlackJack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.Text = "Black Jack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBlackJack;
        private System.Windows.Forms.Label lblGameRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.RichTextBox txtPlayerName;
        private System.Windows.Forms.Button btnPlay;
    }
}