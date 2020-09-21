namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.labelCreateTournament = new System.Windows.Forms.Label();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.textBoxTournamentNameValue = new System.Windows.Forms.TextBox();
            this.labelEntryFee = new System.Windows.Forms.Label();
            this.textBoxEntryFeeValue = new System.Windows.Forms.TextBox();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.comboBoxSelectTeam = new System.Windows.Forms.ComboBox();
            this.linkLabelCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreatePrize = new System.Windows.Forms.Button();
            this.listBoxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.labelTeamsPlayers = new System.Windows.Forms.Label();
            this.buttonDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.buttonDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreateTournament
            // 
            this.labelCreateTournament.AutoSize = true;
            this.labelCreateTournament.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCreateTournament.Location = new System.Drawing.Point(12, 9);
            this.labelCreateTournament.Name = "labelCreateTournament";
            this.labelCreateTournament.Size = new System.Drawing.Size(190, 30);
            this.labelCreateTournament.TabIndex = 0;
            this.labelCreateTournament.Text = "Create Tournament";
            this.labelCreateTournament.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTournamentName.Location = new System.Drawing.Point(13, 49);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(153, 23);
            this.labelTournamentName.TabIndex = 0;
            this.labelTournamentName.Text = "Tournament Name";
            this.labelTournamentName.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // textBoxTournamentNameValue
            // 
            this.textBoxTournamentNameValue.Location = new System.Drawing.Point(12, 75);
            this.textBoxTournamentNameValue.Name = "textBoxTournamentNameValue";
            this.textBoxTournamentNameValue.Size = new System.Drawing.Size(231, 23);
            this.textBoxTournamentNameValue.TabIndex = 1;
            // 
            // labelEntryFee
            // 
            this.labelEntryFee.AutoSize = true;
            this.labelEntryFee.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntryFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelEntryFee.Location = new System.Drawing.Point(13, 132);
            this.labelEntryFee.Name = "labelEntryFee";
            this.labelEntryFee.Size = new System.Drawing.Size(77, 23);
            this.labelEntryFee.TabIndex = 0;
            this.labelEntryFee.Text = "Entry fee";
            this.labelEntryFee.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // textBoxEntryFeeValue
            // 
            this.textBoxEntryFeeValue.Location = new System.Drawing.Point(96, 132);
            this.textBoxEntryFeeValue.Name = "textBoxEntryFeeValue";
            this.textBoxEntryFeeValue.Size = new System.Drawing.Size(148, 23);
            this.textBoxEntryFeeValue.TabIndex = 1;
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSelectTeam.Location = new System.Drawing.Point(13, 182);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(100, 23);
            this.labelSelectTeam.TabIndex = 0;
            this.labelSelectTeam.Text = "Select Team";
            this.labelSelectTeam.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // comboBoxSelectTeam
            // 
            this.comboBoxSelectTeam.FormattingEnabled = true;
            this.comboBoxSelectTeam.Location = new System.Drawing.Point(13, 208);
            this.comboBoxSelectTeam.Name = "comboBoxSelectTeam";
            this.comboBoxSelectTeam.Size = new System.Drawing.Size(231, 23);
            this.comboBoxSelectTeam.TabIndex = 2;
            // 
            // linkLabelCreateNewTeam
            // 
            this.linkLabelCreateNewTeam.AutoSize = true;
            this.linkLabelCreateNewTeam.Location = new System.Drawing.Point(176, 188);
            this.linkLabelCreateNewTeam.Name = "linkLabelCreateNewTeam";
            this.linkLabelCreateNewTeam.Size = new System.Drawing.Size(68, 15);
            this.linkLabelCreateNewTeam.TabIndex = 3;
            this.linkLabelCreateNewTeam.TabStop = true;
            this.linkLabelCreateNewTeam.Text = "Create New";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.BackColor = System.Drawing.Color.Silver;
            this.buttonAddTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddTeam.Location = new System.Drawing.Point(64, 274);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(139, 34);
            this.buttonAddTeam.TabIndex = 5;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = false;
            // 
            // buttonCreatePrize
            // 
            this.buttonCreatePrize.BackColor = System.Drawing.Color.Silver;
            this.buttonCreatePrize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePrize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreatePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreatePrize.Location = new System.Drawing.Point(64, 329);
            this.buttonCreatePrize.Name = "buttonCreatePrize";
            this.buttonCreatePrize.Size = new System.Drawing.Size(139, 34);
            this.buttonCreatePrize.TabIndex = 5;
            this.buttonCreatePrize.Text = "Create Prize";
            this.buttonCreatePrize.UseVisualStyleBackColor = false;
            // 
            // listBoxTournamentPlayers
            // 
            this.listBoxTournamentPlayers.FormattingEnabled = true;
            this.listBoxTournamentPlayers.ItemHeight = 15;
            this.listBoxTournamentPlayers.Location = new System.Drawing.Point(305, 75);
            this.listBoxTournamentPlayers.Name = "listBoxTournamentPlayers";
            this.listBoxTournamentPlayers.Size = new System.Drawing.Size(254, 124);
            this.listBoxTournamentPlayers.TabIndex = 3;
            // 
            // labelTeamsPlayers
            // 
            this.labelTeamsPlayers.AutoSize = true;
            this.labelTeamsPlayers.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeamsPlayers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamsPlayers.Location = new System.Drawing.Point(305, 49);
            this.labelTeamsPlayers.Name = "labelTeamsPlayers";
            this.labelTeamsPlayers.Size = new System.Drawing.Size(160, 23);
            this.labelTeamsPlayers.TabIndex = 0;
            this.labelTeamsPlayers.Text = "Tournament Players";
            this.labelTeamsPlayers.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // buttonDeleteSelectedPlayer
            // 
            this.buttonDeleteSelectedPlayer.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSelectedPlayer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteSelectedPlayer.Location = new System.Drawing.Point(575, 106);
            this.buttonDeleteSelectedPlayer.Name = "buttonDeleteSelectedPlayer";
            this.buttonDeleteSelectedPlayer.Size = new System.Drawing.Size(111, 62);
            this.buttonDeleteSelectedPlayer.TabIndex = 5;
            this.buttonDeleteSelectedPlayer.Text = "Delete Player/Team";
            this.buttonDeleteSelectedPlayer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(305, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Players";
            this.label1.Click += new System.EventHandler(this.labelTournament_Click);
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 15;
            this.listBoxPrizes.Location = new System.Drawing.Point(305, 257);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(254, 124);
            this.listBoxPrizes.TabIndex = 3;
            // 
            // buttonDeleteSelectedPrize
            // 
            this.buttonDeleteSelectedPrize.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPrize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSelectedPrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteSelectedPrize.Location = new System.Drawing.Point(575, 287);
            this.buttonDeleteSelectedPrize.Name = "buttonDeleteSelectedPrize";
            this.buttonDeleteSelectedPrize.Size = new System.Drawing.Size(111, 62);
            this.buttonDeleteSelectedPrize.TabIndex = 5;
            this.buttonDeleteSelectedPrize.Text = "Delete Prize";
            this.buttonDeleteSelectedPrize.UseVisualStyleBackColor = false;
            this.buttonDeleteSelectedPrize.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.BackColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateTournament.Location = new System.Drawing.Point(257, 410);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(195, 34);
            this.buttonCreateTournament.TabIndex = 5;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 475);
            this.Controls.Add(this.buttonDeleteSelectedPrize);
            this.Controls.Add(this.buttonDeleteSelectedPlayer);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.listBoxTournamentPlayers);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.buttonCreatePrize);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.linkLabelCreateNewTeam);
            this.Controls.Add(this.comboBoxSelectTeam);
            this.Controls.Add(this.labelSelectTeam);
            this.Controls.Add(this.textBoxEntryFeeValue);
            this.Controls.Add(this.textBoxTournamentNameValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEntryFee);
            this.Controls.Add(this.labelTeamsPlayers);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelCreateTournament);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateTournament;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.TextBox textBoxTournamentNameValue;
        private System.Windows.Forms.Label labelEntryFee;
        private System.Windows.Forms.TextBox textBoxEntryFeeValue;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam;
        private System.Windows.Forms.LinkLabel linkLabelCreateNewTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreatePrize;
        private System.Windows.Forms.ListBox listBoxTournamentPlayers;
        private System.Windows.Forms.Label labelTeamsPlayers;
        private System.Windows.Forms.Button buttonDeleteSelectedPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Button buttonDeleteSelectedPrize;
        private System.Windows.Forms.Button buttonCreateTournament;
    }
}