using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortSpel
{
    public partial class CardControl : UserControl
    {
        public bool checkControlBox { get; set; }
        public Image CardImage { get; set; }
        public Color HoldButtonColor { get; set; }
        public CardControl()
        {
            
            InitializeComponent();
        //    Card.BackgroundImage = CardImage;
        }

        public void FixImage()
        {
            Card.BackgroundImage = CardImage;
            hold.BackColor = HoldButtonColor;
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Card.BackgroundImage = CardImage;
            if (checkBox.Checked == true)
            {
                checkBox.Checked = false;
                hold.BackColor = System.Drawing.SystemColors.ButtonFace;
                checkControlBox = false;
            }
            else if (checkBox.Checked == false)
            {
                checkBox.Checked = true;
                hold.BackColor = System.Drawing.SystemColors.ControlDark;
                checkControlBox = true;
            }
        }

        private void CardControl_Load(object sender, EventArgs e)
        {
        
        }
    }
}
