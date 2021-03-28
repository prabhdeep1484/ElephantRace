namespace ElephantRace
{
    partial class RacingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingForm));
            this.Elephant1 = new System.Windows.Forms.PictureBox();
            this.Elephant2 = new System.Windows.Forms.PictureBox();
            this.Elephant3 = new System.Windows.Forms.PictureBox();
            this.Elephant4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JoeBet = new System.Windows.Forms.Label();
            this.JennyBet = new System.Windows.Forms.Label();
            this.AlBet = new System.Windows.Forms.Label();
            this.BetDetails = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.ElephantNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.JoeRButton = new System.Windows.Forms.RadioButton();
            this.JennyRButton = new System.Windows.Forms.RadioButton();
            this.AlButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racetrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElephantNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // Elephant1
            // 
            this.Elephant1.Image = ((System.Drawing.Image)(resources.GetObject("Elephant1.Image")));
            this.Elephant1.Location = new System.Drawing.Point(13, 13);
            this.Elephant1.Margin = new System.Windows.Forms.Padding(4);
            this.Elephant1.Name = "Elephant1";
            this.Elephant1.Size = new System.Drawing.Size(109, 88);
            this.Elephant1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Elephant1.TabIndex = 1;
            this.Elephant1.TabStop = false;
            // 
            // Elephant2
            // 
            this.Elephant2.Image = ((System.Drawing.Image)(resources.GetObject("Elephant2.Image")));
            this.Elephant2.Location = new System.Drawing.Point(17, 118);
            this.Elephant2.Margin = new System.Windows.Forms.Padding(4);
            this.Elephant2.Name = "Elephant2";
            this.Elephant2.Size = new System.Drawing.Size(105, 87);
            this.Elephant2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Elephant2.TabIndex = 2;
            this.Elephant2.TabStop = false;
            // 
            // Elephant3
            // 
            this.Elephant3.Image = ((System.Drawing.Image)(resources.GetObject("Elephant3.Image")));
            this.Elephant3.Location = new System.Drawing.Point(17, 223);
            this.Elephant3.Margin = new System.Windows.Forms.Padding(4);
            this.Elephant3.Name = "Elephant3";
            this.Elephant3.Size = new System.Drawing.Size(104, 85);
            this.Elephant3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Elephant3.TabIndex = 3;
            this.Elephant3.TabStop = false;
            // 
            // Elephant4
            // 
            this.Elephant4.Image = ((System.Drawing.Image)(resources.GetObject("Elephant4.Image")));
            this.Elephant4.Location = new System.Drawing.Point(18, 326);
            this.Elephant4.Margin = new System.Windows.Forms.Padding(4);
            this.Elephant4.Name = "Elephant4";
            this.Elephant4.Size = new System.Drawing.Size(104, 84);
            this.Elephant4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Elephant4.TabIndex = 4;
            this.Elephant4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.JoeBet);
            this.groupBox1.Controls.Add(this.JennyBet);
            this.groupBox1.Controls.Add(this.AlBet);
            this.groupBox1.Controls.Add(this.BetDetails);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.ElephantNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.JoeRButton);
            this.groupBox1.Controls.Add(this.JennyRButton);
            this.groupBox1.Controls.Add(this.AlButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(1076, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 441);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elephant Race Betting System";
            // 
            // JoeBet
            // 
            this.JoeBet.BackColor = System.Drawing.SystemColors.Info;
            this.JoeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeBet.Location = new System.Drawing.Point(19, 358);
            this.JoeBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoeBet.Name = "JoeBet";
            this.JoeBet.Size = new System.Drawing.Size(386, 20);
            this.JoeBet.TabIndex = 13;
            // 
            // JennyBet
            // 
            this.JennyBet.BackColor = System.Drawing.SystemColors.Info;
            this.JennyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JennyBet.Location = new System.Drawing.Point(19, 328);
            this.JennyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JennyBet.Name = "JennyBet";
            this.JennyBet.Size = new System.Drawing.Size(386, 20);
            this.JennyBet.TabIndex = 12;
            // 
            // AlBet
            // 
            this.AlBet.BackColor = System.Drawing.SystemColors.Info;
            this.AlBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlBet.Location = new System.Drawing.Point(19, 298);
            this.AlBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlBet.Name = "AlBet";
            this.AlBet.Size = new System.Drawing.Size(386, 20);
            this.AlBet.TabIndex = 11;
            // 
            // BetDetails
            // 
            this.BetDetails.AutoSize = true;
            this.BetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetDetails.Location = new System.Drawing.Point(15, 268);
            this.BetDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetDetails.Name = "BetDetails";
            this.BetDetails.Size = new System.Drawing.Size(48, 20);
            this.BetDetails.TabIndex = 10;
            this.BetDetails.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Gray;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(226, 393);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // ElephantNumber
            // 
            this.ElephantNumber.Location = new System.Drawing.Point(184, 226);
            this.ElephantNumber.Margin = new System.Windows.Forms.Padding(4);
            this.ElephantNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ElephantNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ElephantNumber.Name = "ElephantNumber";
            this.ElephantNumber.Size = new System.Drawing.Size(85, 22);
            this.ElephantNumber.TabIndex = 8;
            this.ElephantNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elephant number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(186, 167);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Gray;
            this.Bets.Location = new System.Drawing.Point(19, 157);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(112, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // JoeRButton
            // 
            this.JoeRButton.AutoSize = true;
            this.JoeRButton.Checked = true;
            this.JoeRButton.Location = new System.Drawing.Point(19, 119);
            this.JoeRButton.Margin = new System.Windows.Forms.Padding(4);
            this.JoeRButton.Name = "JoeRButton";
            this.JoeRButton.Size = new System.Drawing.Size(52, 21);
            this.JoeRButton.TabIndex = 3;
            this.JoeRButton.TabStop = true;
            this.JoeRButton.Text = "Joe";
            this.JoeRButton.UseVisualStyleBackColor = true;
            this.JoeRButton.CheckedChanged += new System.EventHandler(this.JoeButton_CheckedChanged);
            // 
            // JennyRButton
            // 
            this.JennyRButton.AutoSize = true;
            this.JennyRButton.Location = new System.Drawing.Point(19, 90);
            this.JennyRButton.Margin = new System.Windows.Forms.Padding(4);
            this.JennyRButton.Name = "JennyRButton";
            this.JennyRButton.Size = new System.Drawing.Size(67, 21);
            this.JennyRButton.TabIndex = 2;
            this.JennyRButton.Text = "Jenny";
            this.JennyRButton.UseVisualStyleBackColor = true;
            this.JennyRButton.CheckedChanged += new System.EventHandler(this.JennyButton_CheckedChanged);
            // 
            // AlButton
            // 
            this.AlButton.AutoSize = true;
            this.AlButton.Location = new System.Drawing.Point(19, 60);
            this.AlButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlButton.Name = "AlButton";
            this.AlButton.Size = new System.Drawing.Size(41, 21);
            this.AlButton.TabIndex = 1;
            this.AlButton.Text = "Al";
            this.AlButton.UseVisualStyleBackColor = true;
            this.AlButton.CheckedChanged += new System.EventHandler(this.AlButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 4);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 416);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // RacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Elephant4);
            this.Controls.Add(this.Elephant3);
            this.Controls.Add(this.Elephant2);
            this.Controls.Add(this.Elephant1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RacingForm";
            this.Text = "Race Course";
            ((System.ComponentModel.ISupportInitialize)(this.Elephant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elephant4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElephantNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Elephant1;
        private System.Windows.Forms.PictureBox Elephant2;
        private System.Windows.Forms.PictureBox Elephant3;
        private System.Windows.Forms.PictureBox Elephant4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton JoeRButton;
        private System.Windows.Forms.RadioButton JennyRButton;
        private System.Windows.Forms.RadioButton AlButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown ElephantNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label BetDetails;
        private System.Windows.Forms.Label AlBet;
        private System.Windows.Forms.Label JoeBet;
        private System.Windows.Forms.Label JennyBet;
        private System.Windows.Forms.PictureBox racetrack;
    }
}
