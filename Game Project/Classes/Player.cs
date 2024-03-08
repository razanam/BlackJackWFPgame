using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Classes
{
    class Player
    {
        /*
         * Rawnaz Anam Blackjack Project
         * Due date 11/11/2019
         * Player class has player name and cash amount.
         * provides table with amount of cash they have.
         * and subtracts or add player win or lost amount. 
         */
        private string name;
        private decimal cash;

        public Player(string playerName, decimal playerCash)
            {
            name = playerName;
            cash = playerCash;
            }
        public void playerWin(decimal pot) //gives the player money after the appropriate multiplier is applied in the code behind
        {
            cash += pot;
        }
        public void playerLost(decimal pot) //used to add money to the pot when betting
        {
            cash -= pot;
        }

        public decimal getAmount()
        {
            decimal amount = cash;
            return amount;
        }
        public string getName()
        {
            return name;
        }

    }
}
