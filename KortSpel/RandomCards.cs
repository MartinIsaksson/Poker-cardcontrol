using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace KortSpel
{
    public partial class RandomCards : Form
    {
        private CardsConst Deck;
        private int Credits = 100;
        private int tempCred = 0;
        private int Bet = 0;
        private int DealCounter = 0;

        private Bitmap source = new Bitmap(@"C:\Users\martin\Pictures\PlayingCards\cards.png");
        private List<Rectangle> savedCardValues = new List<Rectangle>();
        //   private List<Rectangle> SectionList = new List<Rectangle>();
        private List<CardControl> CardControls = new List<CardControl>();
        //  Cards Cards = new Cards();

        private List<CheckBox> boxes;

        public RandomCards()
        {


            InitializeComponent();
            creditdisplaylevel.Text = Credits.ToString();
            numbershufflesDisplay.Text = "3";
            Deck = new CardsConst();
            savedCardValues = PlaceRandomCards();
            //HoldCardsOrNot(source, savedCardValues);
            numberofShufflesLeftBar.Maximum = 99;
            CardControls.Add(cardControl1);
            CardControls.Add(cardControl2);
            CardControls.Add(cardControl3);
            CardControls.Add(cardControl4);
            CardControls.Add(cardControl5);
            DisableCardControls();


        }

        private void DisableCardControls()
        {
            foreach (var card in CardControls)
            {
                card.Enabled = false;
            }
        }

        private void RandomCardButton_Click(object sender, EventArgs e)
        {
            EnableCardControls();
            if (DealCounter == 0)
            {
                AnnouncerLabel.Text = string.Empty;
                tempCred = Credits;
                Credits -= Bet;

                creditdisplaylevel.Text = Credits.ToString();
                DisableBetting();
                numberofShufflesLeftBar.Value = 0;
            }
            DealCounter++;
            
            numberofShufflesLeftBar.Value += 33;
            listBox1.Items.Clear();
            List<Rectangle> SectionList = PlaceRandomCards();
            CheckCardsbox(source, SectionList);
            //HoldCardsOrNot(source, SectionList);
            List<Card> cardsOnShow = new List<Card>();
            foreach (var position in savedCardValues)
            {
                foreach (var card in Deck.Cards)
                {
                    if (card.posX == position.Location.X && card.posY == position.Location.Y)
                    {
                        cardsOnShow.Add(card);
                        listBox1.Items.Add("Cardtype: " + card.TypeOfCard + ", value: " + card.Value);
                        break;
                    }
                }
            }


            if (DealCounter >= 3)
            {

                RightOfAKind(cardsOnShow);
                CheckFlush(cardsOnShow);
                CheckStraight(cardsOnShow);
                creditdisplaylevel.Text = Credits.ToString();
                if (tempCred > Credits)
                {
                    AnnouncerLabel.Text = "Game Over!";
                    MessageBox.Show("You lost!");
                }
                else if (tempCred < Credits)
                {

                }
                DealCounter = 0;
                for (int i = 0; i < CardControls.Count; i++)
                {
                    CardControls[i].HoldButtonColor = System.Drawing.SystemColors.ButtonFace;
                    CardControls[i].checkControlBox = false;
                    CardControls[i].FixImage();
                }
                EnableBetting();
                DisableCardControls();
            }
            numbershufflesDisplay.Text = (3 - DealCounter).ToString();


        }

        private void EnableCardControls()
        {
            foreach (var card in CardControls)
            {
                card.Enabled = true;
            }
        }

        private void EnableBetting()
        {
            button7.Enabled = true;
            button8.Enabled = true;
            button1.Enabled = true;
            button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            button8.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void DisableBetting()
        {
            button8.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;
            button1.BackColor = Color.DimGray;
            button1.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void CheckCardsbox(Bitmap source, List<Rectangle> SectionList)
        {
            for (int i = 0; i < CardControls.Count; i++)
            {
                if (!CardControls[i].checkControlBox)
                {
                    CardControls[i].CardImage = CropImage(source, SectionList[i]);
                    CardControls[i].FixImage();
                    CardControls[i].Refresh();
                    System.Threading.Thread.Sleep(60);
                    savedCardValues[i] = SectionList[i];

                }
            }
        }

        private List<Card> PlaceStraigthFlushCards(List<Card> cardsOnShow)
        {

            cardsOnShow[0].TypeOfCard = "Clubs";
            cardsOnShow[0].Value = 2;
            cardsOnShow[1].TypeOfCard = "Clubs";
            cardsOnShow[1].Value = 3;
            cardsOnShow[2].TypeOfCard = "Clubs";
            cardsOnShow[2].Value = 4;
            cardsOnShow[3].TypeOfCard = "Clubs";
            cardsOnShow[3].Value = 5;
            cardsOnShow[4].TypeOfCard = "Clubs";
            cardsOnShow[4].Value = 6;
            return cardsOnShow;

        } // kollar endast  om straight flush fungerar ingen kod som behövs




        private void CheckFlush(List<Card> cardsOnShow)
        {
            if (cardsOnShow.TrueForAll(e => e.TypeOfCard == cardsOnShow[0].TypeOfCard))
            {
                if (CheckStraight(cardsOnShow))
                {

                    AnnouncerLabel.Text = "Straight Flush!";
                    Credits -= (Bet * 4);
                    Credits += (Bet * 50);
                }
                else
                {
                    AnnouncerLabel.Text = "Flush!";
                    Credits += (Bet * 6);
                }
            }
        }


        private bool CheckStraight(List<Card> cardsOnShow)
        {
            int counterLadder = 0;
            for (int i = 0; i < cardsOnShow.Count - 1; i++)
            {
                if (cardsOnShow[i].Value < cardsOnShow[i + 1].Value && 1 + (cardsOnShow[i].Value) == cardsOnShow[i + 1].Value)
                {
                    counterLadder++;

                }
                else
                {
                    break;
                }
                if (counterLadder >= 4)
                {

                    AnnouncerLabel.Text = "Straight!";
                    Credits += (Bet * 4);

                    return true;
                }

            }
            return false;
        }

        private List<Rectangle> PlaceRandomCards()
        {
            List<Rectangle> SectionList = new List<Rectangle>();
            int width = 105;
            int height = 164;
            for (int i = 0; i < 5; i++)
            {
                Rectangle tempPos = new Rectangle(new Point(PointWidth(), PointHeight()), new Size(width, height));
                if (i != 0)
                {
                    while (SectionList.Contains(tempPos) || savedCardValues.Contains(tempPos))
                    {
                        System.Threading.Thread.Sleep(10);
                        tempPos = new Rectangle(new Point(PointWidth(), PointHeight()), new Size(width, height));
                        System.Threading.Thread.Sleep(10);
                    }

                }

                SectionList.Add(tempPos);
            }
            return SectionList;
        }



        private void RightOfAKind(List<Card> cardsOnShow)
        {
            AnnouncerLabel.Text = "";
            PokerRightBox.Items.Clear();
            List<int> valueRights = new List<int>();
            List<int> keySpecifik = new List<int>();

            for (int i = 0; i < cardsOnShow.Count; i++)
            {
                keySpecifik.Add(cardsOnShow[i].Value);
                valueRights.Add(0);
                for (int j = 0; j < keySpecifik.Count; j++)
                {
                    if (keySpecifik[i] == cardsOnShow[j].Value)
                    {
                        valueRights[j]++;
                    }
                }
            }
            for (int k = 0; k < valueRights.Count; k++)
            {
                for (int i = k + 1; i < keySpecifik.Count; i++)
                {
                    if (keySpecifik[k] == keySpecifik[i])
                    {

                        if (valueRights[k] >= valueRights[i])
                        {
                            valueRights.RemoveAt(i);
                            keySpecifik.RemoveAt(i);
                        }
                    }
                }

            }
            for (int i = 0; i < keySpecifik.Count; i++)
            {
                if (valueRights[i] <= 1)
                {
                    valueRights.RemoveAt(i);
                    keySpecifik.RemoveAt(i);
                    i = 0;
                }
            }

            for (int i = 0; i < keySpecifik.Count - 1; i++)
            {
                if (keySpecifik.Count >= 2)
                {
                    if (valueRights[i] == 2 && valueRights[i + 1] == 2)
                    {
                        AnnouncerLabel.Text = "Two Pairs!";
                        Credits += (Bet * 2);
                    }
                    if (valueRights[i] == 3 && valueRights[i + 1] == 2)
                    {
                        AnnouncerLabel.Text = "Full house!";
                        Credits += (Bet * 9);
                    }
                    else if (valueRights[i] == 2 && valueRights[i + 1] == 3)
                    {
                        AnnouncerLabel.Text = "Full house!";
                        Credits += (Bet * 9);
                    }
                }


            }
            if (AnnouncerLabel.Text == string.Empty)
            {
                for (int i = 0; i < keySpecifik.Count; i++)
                {
                    if (keySpecifik.Count < 2)
                    {
                        if (valueRights[i] == 4)
                        {
                            AnnouncerLabel.Text = "Four of a Kind!";
                            Credits += (Bet * 25);
                        }
                        else if (valueRights[i] == 3)
                        {
                            AnnouncerLabel.Text = "Three of a Kind!";
                            Credits += (Bet * 3);
                        }
                        else if (valueRights[i] == 2)
                        {
                            AnnouncerLabel.Text = "Jacks!";
                            Credits += (Bet * 1);
                        }

                    }
                    if (valueRights[i] > 1)
                    {
                        PokerRightBox.Items.Add("Value of cards: " + keySpecifik[i] + ", amount of equal cards: " + valueRights[i]);
                    }
                }
            }
        }

        private int PointWidth()
        {
            Random randWidth = new Random();
            int widthMultiplier = randWidth.Next(0, 13);
            widthMultiplier = widthMultiplier * 79;
            return widthMultiplier;
        }

        private int PointHeight()
        {
            Random randHeight = new Random();
            int heightMultiplier = randHeight.Next(0, 4);
            heightMultiplier = heightMultiplier * 123;
            return heightMultiplier;
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {


            Bitmap bitmap = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bitmap;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Bet++;
            CheckBetLevel();
            betleveldisplay.Text = Bet.ToString();
        } // Bet up

        private void CheckBetLevel()
        {
            if (Bet > 5)
            {
                Bet = 5;
            }
            else if (Bet <= 0)
            {
                Bet = 0;
            }
        } // Checking the Bet level

        private void button7_Click(object sender, EventArgs e)
        {
            Bet--;
            CheckBetLevel();
            betleveldisplay.Text = Bet.ToString();
        } // Bet down

        private void button1_Click(object sender, EventArgs e)
        {
            Bet = 5;
            betleveldisplay.Text = Bet.ToString();
        }

        private void RandomCards_Load(object sender, EventArgs e)
        {

        } // MAX BET method










    }
}
