namespace KortSpel
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardControl));
            this.hold = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.Card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hold
            // 
            this.hold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hold.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hold.Location = new System.Drawing.Point(3, 152);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(95, 50);
            this.hold.TabIndex = 24;
            this.hold.Text = "HOLD";
            this.hold.UseVisualStyleBackColor = false;
            this.hold.Click += new System.EventHandler(this.Card_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(3, 7);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(38, 21);
            this.checkBox.TabIndex = 23;
            this.checkBox.TabStop = false;
            this.checkBox.Text = "1";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.Visible = false;
            // 
            // Card
            // 
            this.Card.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card.BackgroundImage")));
            this.Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Card.FlatAppearance.BorderSize = 0;
            this.Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card.ForeColor = System.Drawing.Color.Transparent;
            this.Card.Location = new System.Drawing.Point(3, 3);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(95, 139);
            this.Card.TabIndex = 22;
            this.Card.TabStop = false;
            this.Card.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Card.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Card.UseVisualStyleBackColor = false;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.hold);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Card);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(100, 216);
            this.Load += new System.EventHandler(this.CardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hold;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button Card;
    }
}
