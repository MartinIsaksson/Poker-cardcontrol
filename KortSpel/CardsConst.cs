using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KortSpel
{
    public class CardsConst
    {
        public List<Card> Cards;
        public CardsConst()
        {
            Cards = new List<Card>();
            int posX = 132;
            int posY = 186;
            string typeOfCard = "Clubs";
            for (int y = 0; y < 4; y++)
            {
                if (y == 0)
                {

                    typeOfCard = "Diamonds";
                }
                else if (y == 1)
                {
                    typeOfCard = "Clubs";
                }
                else if (y == 2)
                {
                    typeOfCard = "Hearts";
                }
                else if (y == 3)
                {
                    typeOfCard = "Spades";
                }
                int value = 1;
                for (int x = 0; x < 13; x++)
                {
                    Cards.Add(new Card { posX = (posX * x), posY = (posY * y), TypeOfCard = typeOfCard, Value = (value + 1) });
                    value++;
                }

            }

        }
    }
}
