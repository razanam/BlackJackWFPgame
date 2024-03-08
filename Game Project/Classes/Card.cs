using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Classes
{
    /*Creates a card object which holds values
     * such as card suit and card number
     * also return image index for each card assigned in image list.
     */
    class Card
    {
        private char suit; //S, C, D, or H
        private int value; //1 - 13
        private static int cardCounter = 0; //keeps track of how many cards have been made for a deck
        private int imageIndex; //used to display the accurate card image on form

        public Card(int value, char suit)
        {
            this.value = value;
            this.suit = suit;

            this.imageIndex = cardCounter;
            Card.cardCounter = (Card.cardCounter + 1) % 52;
        }

        public int getValue() //returns value 1 - 13
        {
            return this.value;
        }

        public char getSuit() //suits c,h,d,s
        {
            return this.suit;
        }

        public int getImageIndex() //used to know which card image needs to be used
        {
            return this.imageIndex;
        }

        //return card as a string in form "The blank of blanks"
        public String toString()
        {
            String[] valuesAsWords = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack","Queen", "King"};
            String outValue = valuesAsWords[this.value - 1];

            String outSuit = "";
            switch (Convert.ToChar(this.suit))
            {
                case 'C':
                    outSuit = "Clubs";
                    break;
                case 'S':
                    outSuit = "Spades";
                    break;
                case 'H':
                    outSuit = "Hearts";
                    break;
                case 'D':
                    outSuit = "Diamonds";
                    break;
            }

            return $"The {outValue} of {outSuit}" + " " + this.imageIndex;
        }

    }
}

