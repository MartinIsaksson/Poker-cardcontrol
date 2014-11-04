namespace KortSpel
{
    partial class RandomCards
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
            this.RandomCardButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PokerRightBox = new System.Windows.Forms.ListBox();
            this.AnnouncerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.creditdisplaylevel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.betleveldisplay = new System.Windows.Forms.Label();
            this.numberofshuffleslabel = new System.Windows.Forms.Label();
            this.numbershufflesDisplay = new System.Windows.Forms.Label();
            this.numberofShufflesLeftBar = new System.Windows.Forms.ProgressBar();
            this.cardControl5 = new KortSpel.CardControl();
            this.cardControl4 = new KortSpel.CardControl();
            this.cardControl3 = new KortSpel.CardControl();
            this.cardControl2 = new KortSpel.CardControl();
            this.cardControl1 = new KortSpel.CardControl();
            this.SuspendLayout();
            // 
            // RandomCardButton
            // 
            this.RandomCardButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RandomCardButton.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomCardButton.Location = new System.Drawing.Point(672, 349);
            this.RandomCardButton.Name = "RandomCardButton";
            this.RandomCardButton.Size = new System.Drawing.Size(64, 49);
            this.RandomCardButton.TabIndex = 1;
            this.RandomCardButton.Text = "DEAL";
            this.RandomCardButton.UseVisualStyleBackColor = false;
            this.RandomCardButton.Click += new System.EventHandler(this.RandomCardButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(12, 367);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 196);
            this.listBox1.TabIndex = 8;
            // 
            // PokerRightBox
            // 
            this.PokerRightBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.PokerRightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PokerRightBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokerRightBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PokerRightBox.FormattingEnabled = true;
            this.PokerRightBox.ItemHeight = 28;
            this.PokerRightBox.Location = new System.Drawing.Point(738, 12);
            this.PokerRightBox.Name = "PokerRightBox";
            this.PokerRightBox.Size = new System.Drawing.Size(305, 140);
            this.PokerRightBox.TabIndex = 9;
            // 
            // AnnouncerLabel
            // 
            this.AnnouncerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AnnouncerLabel.AutoSize = true;
            this.AnnouncerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnnouncerLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncerLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AnnouncerLabel.Location = new System.Drawing.Point(274, 56);
            this.AnnouncerLabel.Name = "AnnouncerLabel";
            this.AnnouncerLabel.Size = new System.Drawing.Size(392, 40);
            this.AnnouncerLabel.TabIndex = 15;
            this.AnnouncerLabel.Text = "Welcome to Pokalicious!";
            this.AnnouncerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "MAX   BET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(277, 352);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 49);
            this.button7.TabIndex = 22;
            this.button7.Text = "LOWER STAKES";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(347, 352);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 48);
            this.button8.TabIndex = 23;
            this.button8.Text = "RAISE STAKES";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CreditLabel.Location = new System.Drawing.Point(416, 368);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(116, 33);
            this.CreditLabel.TabIndex = 24;
            this.CreditLabel.Text = "CREDITS:";
            // 
            // creditdisplaylevel
            // 
            this.creditdisplaylevel.AutoSize = true;
            this.creditdisplaylevel.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditdisplaylevel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.creditdisplaylevel.Location = new System.Drawing.Point(510, 367);
            this.creditdisplaylevel.Name = "creditdisplaylevel";
            this.creditdisplaylevel.Size = new System.Drawing.Size(0, 33);
            this.creditdisplaylevel.TabIndex = 25;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.betLabel.Location = new System.Drawing.Point(278, 404);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(63, 33);
            this.betLabel.TabIndex = 26;
            this.betLabel.Text = "BET:";
            // 
            // betleveldisplay
            // 
            this.betleveldisplay.AutoSize = true;
            this.betleveldisplay.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betleveldisplay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.betleveldisplay.Location = new System.Drawing.Point(321, 404);
            this.betleveldisplay.Name = "betleveldisplay";
            this.betleveldisplay.Size = new System.Drawing.Size(0, 33);
            this.betleveldisplay.TabIndex = 27;
            // 
            // numberofshuffleslabel
            // 
            this.numberofshuffleslabel.AutoSize = true;
            this.numberofshuffleslabel.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofshuffleslabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numberofshuffleslabel.Location = new System.Drawing.Point(294, 13);
            this.numberofshuffleslabel.Name = "numberofshuffleslabel";
            this.numberofshuffleslabel.Size = new System.Drawing.Size(288, 33);
            this.numberofshuffleslabel.TabIndex = 28;
            this.numberofshuffleslabel.Text = "Number of shuffles left: ";
            // 
            // numbershufflesDisplay
            // 
            this.numbershufflesDisplay.AutoSize = true;
            this.numbershufflesDisplay.Font = new System.Drawing.Font("Segoe Marker", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbershufflesDisplay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numbershufflesDisplay.Location = new System.Drawing.Point(518, 12);
            this.numbershufflesDisplay.Name = "numbershufflesDisplay";
            this.numbershufflesDisplay.Size = new System.Drawing.Size(0, 33);
            this.numbershufflesDisplay.TabIndex = 29;
            this.numbershufflesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberofShufflesLeftBar
            // 
            this.numberofShufflesLeftBar.Location = new System.Drawing.Point(413, 443);
            this.numberofShufflesLeftBar.Name = "numberofShufflesLeftBar";
            this.numberofShufflesLeftBar.Size = new System.Drawing.Size(192, 28);
            this.numberofShufflesLeftBar.TabIndex = 35;
            // 
            // cardControl5
            // 
            this.cardControl5.BackColor = System.Drawing.Color.Transparent;
            this.cardControl5.CardImage = null;
            this.cardControl5.checkControlBox = false;
            this.cardControl5.HoldButtonColor = System.Drawing.Color.Empty;
            this.cardControl5.Location = new System.Drawing.Point(672, 99);
            this.cardControl5.Name = "cardControl5";
            this.cardControl5.Size = new System.Drawing.Size(136, 244);
            this.cardControl5.TabIndex = 34;
            // 
            // cardControl4
            // 
            this.cardControl4.BackColor = System.Drawing.Color.Transparent;
            this.cardControl4.CardImage = null;
            this.cardControl4.checkControlBox = false;
            this.cardControl4.HoldButtonColor = System.Drawing.Color.Empty;
            this.cardControl4.Location = new System.Drawing.Point(538, 99);
            this.cardControl4.Name = "cardControl4";
            this.cardControl4.Size = new System.Drawing.Size(141, 244);
            this.cardControl4.TabIndex = 33;
            // 
            // cardControl3
            // 
            this.cardControl3.BackColor = System.Drawing.Color.Transparent;
            this.cardControl3.CardImage = null;
            this.cardControl3.checkControlBox = false;
            this.cardControl3.HoldButtonColor = System.Drawing.Color.Empty;
            this.cardControl3.Location = new System.Drawing.Point(401, 99);
            this.cardControl3.Name = "cardControl3";
            this.cardControl3.Size = new System.Drawing.Size(131, 246);
            this.cardControl3.TabIndex = 32;
            // 
            // cardControl2
            // 
            this.cardControl2.BackColor = System.Drawing.Color.Transparent;
            this.cardControl2.CardImage = null;
            this.cardControl2.checkControlBox = false;
            this.cardControl2.HoldButtonColor = System.Drawing.Color.Empty;
            this.cardControl2.Location = new System.Drawing.Point(266, 99);
            this.cardControl2.Name = "cardControl2";
            this.cardControl2.Size = new System.Drawing.Size(145, 245);
            this.cardControl2.TabIndex = 31;
            // 
            // cardControl1
            // 
            this.cardControl1.BackColor = System.Drawing.Color.Transparent;
            this.cardControl1.CardImage = null;
            this.cardControl1.checkControlBox = false;
            this.cardControl1.HoldButtonColor = System.Drawing.Color.Empty;
            this.cardControl1.Location = new System.Drawing.Point(128, 99);
            this.cardControl1.Name = "cardControl1";
            this.cardControl1.Size = new System.Drawing.Size(132, 247);
            this.cardControl1.TabIndex = 30;
            // 
            // RandomCards
            // 
            this.AcceptButton = this.RandomCardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::KortSpel.Properties.Resources.blackBackgroundPoker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.numberofShufflesLeftBar);
            this.Controls.Add(this.cardControl5);
            this.Controls.Add(this.cardControl4);
            this.Controls.Add(this.cardControl3);
            this.Controls.Add(this.cardControl2);
            this.Controls.Add(this.cardControl1);
            this.Controls.Add(this.numbershufflesDisplay);
            this.Controls.Add(this.numberofshuffleslabel);
            this.Controls.Add(this.betleveldisplay);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.creditdisplaylevel);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnnouncerLabel);
            this.Controls.Add(this.PokerRightBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RandomCardButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Marker", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RandomCards";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RandomCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomCardButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox PokerRightBox;
        private System.Windows.Forms.Label AnnouncerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label creditdisplaylevel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label betleveldisplay;
        private System.Windows.Forms.Label numberofshuffleslabel;
        private System.Windows.Forms.Label numbershufflesDisplay;
        private CardControl cardControl1;
        private CardControl cardControl2;
        private CardControl cardControl3;
        private CardControl cardControl4;
        private CardControl cardControl5;
        private System.Windows.Forms.ProgressBar numberofShufflesLeftBar;
    }
}

