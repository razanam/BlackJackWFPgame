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

namespace Game_Project.Forms
{

    /*
     * Rawnaz Anam Blackjack Project
     * Due date 11/11/2019
     * This form is a basic start form which
     * takes the user name and goes to the game form.
     * */
    public partial class frmStart : Form
    {
        public static string name;
        public frmStart()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None; //The following 2 lines of code maximizes the form

            WindowState = FormWindowState.Maximized;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
             name = txtPlayerName.Text;
            if (name.Length > 0) //checking if name is null or not
            {
                //if not null enabling the functions for player
                //Then moves to the next form closing this one

                this.Hide();
                Form Table = new frmTable();
                Table.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("player name field empty", "Entry error"); //asks to input name again. 
                txtPlayerName.Clear();
                txtPlayerName.Focus();

            }
            
        }
    }
}
