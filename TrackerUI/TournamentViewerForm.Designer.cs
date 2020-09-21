namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.checkBoxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.labelTeamOne = new System.Windows.Forms.Label();
            this.labelTeamOneScore = new System.Windows.Forms.Label();
            this.textBoxTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.labelTeamTwo = new System.Windows.Forms.Label();
            this.labelTeamTwoScore = new System.Windows.Forms.Label();
            this.textBoxTeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.labelVs = new System.Windows.Forms.Label();
            this.buttonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTournament
            // 
            this.labelTournament.AutoSize = true;
            this.labelTournament.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTournament.Location = new System.Drawing.Point(23, 23);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(129, 30);
            this.labelTournament.TabIndex = 0;
            this.labelTournament.Text = "Tournament:";
            this.labelTournament.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTournamentName.Location = new System.Drawing.Point(163, 23);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(91, 30);
            this.labelTournamentName.TabIndex = 0;
            this.labelTournamentName.Text = "<none>";
            this.labelTournamentName.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRound.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRound.Location = new System.Drawing.Point(23, 78);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(61, 23);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round";
            this.labelRound.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxUnplayedOnly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(91, 106);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(119, 23);
            this.checkBoxUnplayedOnly.TabIndex = 1;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 15;
            this.listBoxMatchup.Location = new System.Drawing.Point(23, 171);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(254, 244);
            this.listBoxMatchup.TabIndex = 3;
            // 
            // labelTeamOne
            // 
            this.labelTeamOne.AutoSize = true;
            this.labelTeamOne.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTeamOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamOne.Location = new System.Drawing.Point(305, 187);
            this.labelTeamOne.Name = "labelTeamOne";
            this.labelTeamOne.Size = new System.Drawing.Size(102, 23);
            this.labelTeamOne.TabIndex = 0;
            this.labelTeamOne.Text = "<teamone>";
            this.labelTeamOne.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // labelTeamOneScore
            // 
            this.labelTeamOneScore.AutoSize = true;
            this.labelTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeamOneScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamOneScore.Location = new System.Drawing.Point(305, 223);
            this.labelTeamOneScore.Name = "labelTeamOneScore";
            this.labelTeamOneScore.Size = new System.Drawing.Size(49, 21);
            this.labelTeamOneScore.TabIndex = 0;
            this.labelTeamOneScore.Text = "Score";
            this.labelTeamOneScore.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // textBoxTeamOneScoreValue
            // 
            this.textBoxTeamOneScoreValue.Location = new System.Drawing.Point(363, 223);
            this.textBoxTeamOneScoreValue.Name = "textBoxTeamOneScoreValue";
            this.textBoxTeamOneScoreValue.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeamOneScoreValue.TabIndex = 4;
            // 
            // labelTeamTwo
            // 
            this.labelTeamTwo.AutoSize = true;
            this.labelTeamTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTeamTwo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamTwo.Location = new System.Drawing.Point(305, 303);
            this.labelTeamTwo.Name = "labelTeamTwo";
            this.labelTeamTwo.Size = new System.Drawing.Size(102, 23);
            this.labelTeamTwo.TabIndex = 0;
            this.labelTeamTwo.Text = "<teamtwo>";
            this.labelTeamTwo.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // labelTeamTwoScore
            // 
            this.labelTeamTwoScore.AutoSize = true;
            this.labelTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeamTwoScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamTwoScore.Location = new System.Drawing.Point(305, 339);
            this.labelTeamTwoScore.Name = "labelTeamTwoScore";
            this.labelTeamTwoScore.Size = new System.Drawing.Size(49, 21);
            this.labelTeamTwoScore.TabIndex = 0;
            this.labelTeamTwoScore.Text = "Score";
            this.labelTeamTwoScore.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // textBoxTeamTwoScoreValue
            // 
            this.textBoxTeamTwoScoreValue.Location = new System.Drawing.Point(363, 339);
            this.textBoxTeamTwoScoreValue.Name = "textBoxTeamTwoScoreValue";
            this.textBoxTeamTwoScoreValue.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeamTwoScoreValue.TabIndex = 4;
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelVs.Location = new System.Drawing.Point(367, 262);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(40, 23);
            this.labelVs.TabIndex = 0;
            this.labelVs.Text = "-vs-";
            this.labelVs.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.BackColor = System.Drawing.Color.Silver;
            this.buttonScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonScore.Location = new System.Drawing.Point(494, 262);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(111, 61);
            this.buttonScore.TabIndex = 5;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.textBoxTeamTwoScoreValue);
            this.Controls.Add(this.textBoxTeamOneScoreValue);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxUnplayedOnly);
            this.Controls.Add(this.labelTeamTwoScore);
            this.Controls.Add(this.labelTeamOneScore);
            this.Controls.Add(this.labelTeamTwo);
            this.Controls.Add(this.labelTeamOne);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelTournament);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTeamOne;
        private System.Windows.Forms.Label labelTeamOneScore;
        private System.Windows.Forms.TextBox textBoxTeamOneScoreValue;
        private System.Windows.Forms.Label labelTeamTwo;
        private System.Windows.Forms.Label labelTeamTwoScore;
        private System.Windows.Forms.TextBox textBoxTeamTwoScoreValue;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.Button buttonScore;
    }
}