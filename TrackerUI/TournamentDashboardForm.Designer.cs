namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.comboBoxLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.labelLoadExistingTournament = new System.Windows.Forms.Label();
            this.buttonLoadTournament = new System.Windows.Forms.Button();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHeader.Location = new System.Drawing.Point(112, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(231, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Tournament Dashboard";
            // 
            // comboBoxLoadExistingTournament
            // 
            this.comboBoxLoadExistingTournament.FormattingEnabled = true;
            this.comboBoxLoadExistingTournament.Location = new System.Drawing.Point(112, 108);
            this.comboBoxLoadExistingTournament.Name = "comboBoxLoadExistingTournament";
            this.comboBoxLoadExistingTournament.Size = new System.Drawing.Size(231, 23);
            this.comboBoxLoadExistingTournament.TabIndex = 2;
            // 
            // labelLoadExistingTournament
            // 
            this.labelLoadExistingTournament.AutoSize = true;
            this.labelLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoadExistingTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLoadExistingTournament.Location = new System.Drawing.Point(124, 82);
            this.labelLoadExistingTournament.Name = "labelLoadExistingTournament";
            this.labelLoadExistingTournament.Size = new System.Drawing.Size(207, 23);
            this.labelLoadExistingTournament.TabIndex = 0;
            this.labelLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // buttonLoadTournament
            // 
            this.buttonLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoadTournament.Location = new System.Drawing.Point(139, 161);
            this.buttonLoadTournament.Name = "buttonLoadTournament";
            this.buttonLoadTournament.Size = new System.Drawing.Size(177, 39);
            this.buttonLoadTournament.TabIndex = 6;
            this.buttonLoadTournament.Text = "Load Tournament";
            this.buttonLoadTournament.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateTournament.Location = new System.Drawing.Point(104, 249);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(247, 69);
            this.buttonCreateTournament.TabIndex = 6;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 341);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.buttonLoadTournament);
            this.Controls.Add(this.labelLoadExistingTournament);
            this.Controls.Add(this.comboBoxLoadExistingTournament);
            this.Controls.Add(this.labelHeader);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ComboBox comboBoxLoadExistingTournament;
        private System.Windows.Forms.Label labelLoadExistingTournament;
        private System.Windows.Forms.Button buttonLoadTournament;
        private System.Windows.Forms.Button buttonCreateTournament;
    }
}