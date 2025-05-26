namespace _1_Hemtenta_drinks
{
    partial class Form1
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
			this.optFantaBt = new System.Windows.Forms.Button();
			this.opt2FantaBt = new System.Windows.Forms.Button();
			this.drinkLabel = new System.Windows.Forms.Label();
			this.sizeComboBox = new System.Windows.Forms.ComboBox();
			this.confirmBt = new System.Windows.Forms.Button();
			this.fantaComboBox = new System.Windows.Forms.ComboBox();
			this.receiptLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.upBt = new System.Windows.Forms.Button();
			this.fantaBt = new System.Windows.Forms.Button();
			this.DrPepperBt = new System.Windows.Forms.Button();
			this.SpriteBt = new System.Windows.Forms.Button();
			this.pepsiBt = new System.Windows.Forms.Button();
			this.colaBt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// optFantaBt
			// 
			this.optFantaBt.BackColor = System.Drawing.Color.SkyBlue;
			this.optFantaBt.Location = new System.Drawing.Point(77, 446);
			this.optFantaBt.Name = "optFantaBt";
			this.optFantaBt.Size = new System.Drawing.Size(139, 61);
			this.optFantaBt.TabIndex = 7;
			this.optFantaBt.Text = "Sweeteners";
			this.optFantaBt.UseVisualStyleBackColor = false;
			this.optFantaBt.Visible = false;
			this.optFantaBt.Click += new System.EventHandler(this.optFantaBt_Click);
			// 
			// opt2FantaBt
			// 
			this.opt2FantaBt.Location = new System.Drawing.Point(249, 446);
			this.opt2FantaBt.Name = "opt2FantaBt";
			this.opt2FantaBt.Size = new System.Drawing.Size(139, 61);
			this.opt2FantaBt.TabIndex = 8;
			this.opt2FantaBt.Text = "Sugar";
			this.opt2FantaBt.UseVisualStyleBackColor = true;
			this.opt2FantaBt.Visible = false;
			this.opt2FantaBt.Click += new System.EventHandler(this.opt2FantaBt_Click);
			// 
			// drinkLabel
			// 
			this.drinkLabel.AutoSize = true;
			this.drinkLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.drinkLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.drinkLabel.Location = new System.Drawing.Point(123, 172);
			this.drinkLabel.Name = "drinkLabel";
			this.drinkLabel.Size = new System.Drawing.Size(165, 32);
			this.drinkLabel.TabIndex = 9;
			this.drinkLabel.Text = "Choose Drink!";
			// 
			// sizeComboBox
			// 
			this.sizeComboBox.FormattingEnabled = true;
			this.sizeComboBox.Items.AddRange(new object[] {
            "4x4",
            "6x4",
            "6x6"});
			this.sizeComboBox.Location = new System.Drawing.Point(153, 596);
			this.sizeComboBox.Name = "sizeComboBox";
			this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
			this.sizeComboBox.TabIndex = 15;
			this.sizeComboBox.Text = "Choose size:";
			this.sizeComboBox.Visible = false;
			this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
			// 
			// confirmBt
			// 
			this.confirmBt.Location = new System.Drawing.Point(290, 594);
			this.confirmBt.Name = "confirmBt";
			this.confirmBt.Size = new System.Drawing.Size(76, 23);
			this.confirmBt.TabIndex = 16;
			this.confirmBt.Text = "Confirm";
			this.confirmBt.UseVisualStyleBackColor = true;
			this.confirmBt.Visible = false;
			this.confirmBt.Click += new System.EventHandler(this.confirmBt_Click);
			// 
			// fantaComboBox
			// 
			this.fantaComboBox.BackColor = System.Drawing.Color.SkyBlue;
			this.fantaComboBox.FormattingEnabled = true;
			this.fantaComboBox.Items.AddRange(new object[] {
            "Orange",
            "Tropical",
            "Grapefruit"});
			this.fantaComboBox.Location = new System.Drawing.Point(167, 419);
			this.fantaComboBox.Name = "fantaComboBox";
			this.fantaComboBox.Size = new System.Drawing.Size(121, 21);
			this.fantaComboBox.TabIndex = 17;
			this.fantaComboBox.Text = "Choose flavour:";
			this.fantaComboBox.Visible = false;
			this.fantaComboBox.SelectedIndexChanged += new System.EventHandler(this.fantaComboBox_SelectedIndexChanged);
			// 
			// receiptLabel
			// 
			this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.receiptLabel.Location = new System.Drawing.Point(822, 186);
			this.receiptLabel.Name = "receiptLabel";
			this.receiptLabel.Size = new System.Drawing.Size(189, 416);
			this.receiptLabel.TabIndex = 18;
			this.receiptLabel.Text = "Receipt here";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::_1_Hemtenta_drinks.Properties.Resources.bubbles;
			this.pictureBox1.Location = new System.Drawing.Point(611, 419);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(174, 242);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// upBt
			// 
			this.upBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources.up;
			this.upBt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.upBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upBt.Location = new System.Drawing.Point(309, 322);
			this.upBt.Name = "upBt";
			this.upBt.Size = new System.Drawing.Size(79, 70);
			this.upBt.TabIndex = 5;
			this.upBt.UseVisualStyleBackColor = true;
			this.upBt.Click += new System.EventHandler(this.upBt_Click);
			// 
			// fantaBt
			// 
			this.fantaBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources.fanta;
			this.fantaBt.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.fantaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fantaBt.Location = new System.Drawing.Point(108, 322);
			this.fantaBt.Name = "fantaBt";
			this.fantaBt.Size = new System.Drawing.Size(75, 70);
			this.fantaBt.TabIndex = 4;
			this.fantaBt.UseVisualStyleBackColor = true;
			this.fantaBt.Click += new System.EventHandler(this.fantaBt_Click);
			// 
			// DrPepperBt
			// 
			this.DrPepperBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources.mylove;
			this.DrPepperBt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DrPepperBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DrPepperBt.Location = new System.Drawing.Point(355, 246);
			this.DrPepperBt.Name = "DrPepperBt";
			this.DrPepperBt.Size = new System.Drawing.Size(75, 70);
			this.DrPepperBt.TabIndex = 3;
			this.DrPepperBt.UseVisualStyleBackColor = true;
			this.DrPepperBt.Click += new System.EventHandler(this.DrPepperBt_Click);
			// 
			// SpriteBt
			// 
			this.SpriteBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources.sprite;
			this.SpriteBt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SpriteBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SpriteBt.Location = new System.Drawing.Point(260, 246);
			this.SpriteBt.Name = "SpriteBt";
			this.SpriteBt.Size = new System.Drawing.Size(75, 70);
			this.SpriteBt.TabIndex = 2;
			this.SpriteBt.UseVisualStyleBackColor = true;
			this.SpriteBt.Click += new System.EventHandler(this.SpriteBt_Click);
			// 
			// pepsiBt
			// 
			this.pepsiBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources.pepsi;
			this.pepsiBt.Location = new System.Drawing.Point(153, 246);
			this.pepsiBt.Name = "pepsiBt";
			this.pepsiBt.Size = new System.Drawing.Size(75, 70);
			this.pepsiBt.TabIndex = 1;
			this.pepsiBt.UseVisualStyleBackColor = true;
			this.pepsiBt.Click += new System.EventHandler(this.pepsiBt_Click);
			// 
			// colaBt
			// 
			this.colaBt.BackColor = System.Drawing.Color.Azure;
			this.colaBt.BackgroundImage = global::_1_Hemtenta_drinks.Properties.Resources._1_coke;
			this.colaBt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.colaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colaBt.Location = new System.Drawing.Point(60, 246);
			this.colaBt.Name = "colaBt";
			this.colaBt.Size = new System.Drawing.Size(75, 70);
			this.colaBt.TabIndex = 0;
			this.colaBt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.colaBt.UseVisualStyleBackColor = false;
			this.colaBt.Click += new System.EventHandler(this.colaBt_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(326, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 47);
			this.label1.TabIndex = 20;
			this.label1.Text = "C#-Soda\'s Market!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(123, 528);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 32);
			this.label2.TabIndex = 21;
			this.label2.Text = "Choose Size!";
			this.label2.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(1049, 655);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.receiptLabel);
			this.Controls.Add(this.fantaComboBox);
			this.Controls.Add(this.confirmBt);
			this.Controls.Add(this.sizeComboBox);
			this.Controls.Add(this.drinkLabel);
			this.Controls.Add(this.opt2FantaBt);
			this.Controls.Add(this.optFantaBt);
			this.Controls.Add(this.upBt);
			this.Controls.Add(this.fantaBt);
			this.Controls.Add(this.DrPepperBt);
			this.Controls.Add(this.SpriteBt);
			this.Controls.Add(this.pepsiBt);
			this.Controls.Add(this.colaBt);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "m";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colaBt;
        private System.Windows.Forms.Button pepsiBt;
        private System.Windows.Forms.Button SpriteBt;
        private System.Windows.Forms.Button DrPepperBt;
        private System.Windows.Forms.Button fantaBt;
        private System.Windows.Forms.Button upBt;
        private System.Windows.Forms.Button optFantaBt;
        private System.Windows.Forms.Button opt2FantaBt;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Button confirmBt;
        private System.Windows.Forms.ComboBox fantaComboBox;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

