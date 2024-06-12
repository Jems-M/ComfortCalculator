namespace ComfortCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSocProgress = new Label();
            lblCrimeIndex = new Label();
            lblFreedomIndex = new Label();
            lblComfortScore = new Label();
            lblSocProgressNum = new Label();
            lblCrimeIndexNum = new Label();
            lblFreedomIndexNum = new Label();
            lblComfortScoreNum = new Label();
            lblUK = new Label();
            lblUSA = new Label();
            lblRussia = new Label();
            lblChina = new Label();
            lblChad = new Label();
            lblBrazil = new Label();
            lblCountryName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.map;
            pictureBox1.Location = new Point(12, 59);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1108, 701);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(235, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(586, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Choose a country to calculate its Comfort Index:";
            lblTitle.Click += label1_Click;
            // 
            // lblSocProgress
            // 
            lblSocProgress.Anchor = AnchorStyles.Top;
            lblSocProgress.AutoSize = true;
            lblSocProgress.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocProgress.Location = new Point(1126, 118);
            lblSocProgress.Name = "lblSocProgress";
            lblSocProgress.Size = new Size(286, 24);
            lblSocProgress.TabIndex = 2;
            lblSocProgress.Text = "Social Progress Index: ";
            lblSocProgress.Click += label1_Click_1;
            // 
            // lblCrimeIndex
            // 
            lblCrimeIndex.AutoSize = true;
            lblCrimeIndex.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrimeIndex.Location = new Point(1192, 211);
            lblCrimeIndex.Name = "lblCrimeIndex";
            lblCrimeIndex.Size = new Size(166, 24);
            lblCrimeIndex.TabIndex = 3;
            lblCrimeIndex.Text = "Crime Index: ";
            lblCrimeIndex.Click += lblSafetyIndex_Click;
            // 
            // lblFreedomIndex
            // 
            lblFreedomIndex.AutoSize = true;
            lblFreedomIndex.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFreedomIndex.Location = new Point(1177, 321);
            lblFreedomIndex.Name = "lblFreedomIndex";
            lblFreedomIndex.Size = new Size(190, 24);
            lblFreedomIndex.TabIndex = 4;
            lblFreedomIndex.Text = "Freedom Index: ";
            // 
            // lblComfortScore
            // 
            lblComfortScore.AutoSize = true;
            lblComfortScore.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComfortScore.Location = new Point(1168, 605);
            lblComfortScore.Name = "lblComfortScore";
            lblComfortScore.Size = new Size(190, 24);
            lblComfortScore.TabIndex = 5;
            lblComfortScore.Text = "Comfort Score: ";
            // 
            // lblSocProgressNum
            // 
            lblSocProgressNum.AutoSize = true;
            lblSocProgressNum.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocProgressNum.Location = new Point(1235, 158);
            lblSocProgressNum.Name = "lblSocProgressNum";
            lblSocProgressNum.Size = new Size(51, 28);
            lblSocProgressNum.TabIndex = 6;
            lblSocProgressNum.Text = "...";
            // 
            // lblCrimeIndexNum
            // 
            lblCrimeIndexNum.AutoSize = true;
            lblCrimeIndexNum.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrimeIndexNum.Location = new Point(1235, 260);
            lblCrimeIndexNum.Name = "lblCrimeIndexNum";
            lblCrimeIndexNum.Size = new Size(51, 28);
            lblCrimeIndexNum.TabIndex = 7;
            lblCrimeIndexNum.Text = "...";
            // 
            // lblFreedomIndexNum
            // 
            lblFreedomIndexNum.AutoSize = true;
            lblFreedomIndexNum.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFreedomIndexNum.Location = new Point(1236, 362);
            lblFreedomIndexNum.Name = "lblFreedomIndexNum";
            lblFreedomIndexNum.Size = new Size(51, 28);
            lblFreedomIndexNum.TabIndex = 8;
            lblFreedomIndexNum.Text = "...";
            // 
            // lblComfortScoreNum
            // 
            lblComfortScoreNum.AutoSize = true;
            lblComfortScoreNum.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComfortScoreNum.Location = new Point(1235, 666);
            lblComfortScoreNum.Name = "lblComfortScoreNum";
            lblComfortScoreNum.Size = new Size(51, 28);
            lblComfortScoreNum.TabIndex = 9;
            lblComfortScoreNum.Text = "...";
            // 
            // lblUK
            // 
            lblUK.AutoSize = true;
            lblUK.BackColor = Color.White;
            lblUK.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUK.ForeColor = Color.White;
            lblUK.Location = new Point(527, 211);
            lblUK.Name = "lblUK";
            lblUK.Size = new Size(10, 13);
            lblUK.TabIndex = 10;
            lblUK.Text = "I";
            lblUK.Click += lblUK_Click;
            // 
            // lblUSA
            // 
            lblUSA.AutoSize = true;
            lblUSA.BackColor = Color.White;
            lblUSA.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUSA.ForeColor = Color.White;
            lblUSA.Location = new Point(116, 251);
            lblUSA.Name = "lblUSA";
            lblUSA.Size = new Size(112, 52);
            lblUSA.TabIndex = 11;
            lblUSA.Text = "USAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSA";
            lblUSA.Click += lblUSA_Click;
            // 
            // lblRussia
            // 
            lblRussia.AutoSize = true;
            lblRussia.BackColor = Color.White;
            lblRussia.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRussia.ForeColor = Color.White;
            lblRussia.Location = new Point(697, 158);
            lblRussia.Name = "lblRussia";
            lblRussia.Size = new Size(245, 44);
            lblRussia.TabIndex = 12;
            lblRussia.Text = "USAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSAUSA\r\n\r\n\r\n";
            lblRussia.Click += label1_Click_2;
            // 
            // lblChina
            // 
            lblChina.AutoSize = true;
            lblChina.BackColor = Color.White;
            lblChina.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChina.ForeColor = Color.White;
            lblChina.Location = new Point(827, 273);
            lblChina.Name = "lblChina";
            lblChina.Size = new Size(125, 44);
            lblChina.TabIndex = 13;
            lblChina.Text = "USAUSAUSAUSAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSAUSAUSAUSA\r\n\r\n\r\n";
            lblChina.Click += lblChina_Click;
            // 
            // lblChad
            // 
            lblChad.AutoSize = true;
            lblChad.BackColor = Color.White;
            lblChad.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChad.ForeColor = Color.White;
            lblChad.Location = new Point(593, 369);
            lblChad.Name = "lblChad";
            lblChad.Size = new Size(20, 44);
            lblChad.TabIndex = 14;
            lblChad.Text = "USA\r\nUSA\r\n\r\n\r\n";
            lblChad.Click += label1_Click_3;
            // 
            // lblBrazil
            // 
            lblBrazil.AutoSize = true;
            lblBrazil.BackColor = Color.White;
            lblBrazil.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrazil.ForeColor = Color.White;
            lblBrazil.Location = new Point(304, 480);
            lblBrazil.Name = "lblBrazil";
            lblBrazil.Size = new Size(80, 55);
            lblBrazil.TabIndex = 15;
            lblBrazil.Text = "USAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSA\r\nUSAUSAUSAUSAUSA\r\n\r\n\r\n";
            lblBrazil.Click += label2_Click;
            // 
            // lblCountryName
            // 
            lblCountryName.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountryName.ImageAlign = ContentAlignment.TopLeft;
            lblCountryName.Location = new Point(1140, 59);
            lblCountryName.Name = "lblCountryName";
            lblCountryName.Size = new Size(250, 28);
            lblCountryName.TabIndex = 16;
            lblCountryName.Text = "...";
            lblCountryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 771);
            Controls.Add(lblCountryName);
            Controls.Add(lblBrazil);
            Controls.Add(lblChad);
            Controls.Add(lblChina);
            Controls.Add(lblRussia);
            Controls.Add(lblUSA);
            Controls.Add(lblUK);
            Controls.Add(lblComfortScoreNum);
            Controls.Add(lblFreedomIndexNum);
            Controls.Add(lblCrimeIndexNum);
            Controls.Add(lblSocProgressNum);
            Controls.Add(lblComfortScore);
            Controls.Add(lblFreedomIndex);
            Controls.Add(lblCrimeIndex);
            Controls.Add(lblSocProgress);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Comfort Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSocProgress;
        private Label lblCrimeIndex;
        private Label lblFreedomIndex;
        private Label lblComfortScore;
        private Label lblSocProgressNum;
        private Label lblCrimeIndexNum;
        private Label lblFreedomIndexNum;
        private Label lblComfortScoreNum;
        private Label lblUK;
        private Label lblUSA;
        private Label lblRussia;
        private Label lblChina;
        private Label lblChad;
        private Label lblBrazil;
        private Label lblCountryName;
    }
}
