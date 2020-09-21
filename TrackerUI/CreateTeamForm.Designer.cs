namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.labelCreateTeam = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamNameValue = new System.Windows.Forms.TextBox();
            this.labelSelectTeamMember = new System.Windows.Forms.Label();
            this.comboBoxTeamMember = new System.Windows.Forms.ComboBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCellphone = new System.Windows.Forms.Label();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxCellphoneValue = new System.Windows.Forms.TextBox();
            this.textBoxEmailValue = new System.Windows.Forms.TextBox();
            this.textBoxLastNameValue = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameValue = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonCreateTeam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreateTeam
            // 
            this.labelCreateTeam.AutoSize = true;
            this.labelCreateTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCreateTeam.Location = new System.Drawing.Point(19, 15);
            this.labelCreateTeam.Name = "labelCreateTeam";
            this.labelCreateTeam.Size = new System.Drawing.Size(190, 30);
            this.labelCreateTeam.TabIndex = 0;
            this.labelCreateTeam.Text = "Create Tournament";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeamName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTeamName.Location = new System.Drawing.Point(19, 67);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(153, 23);
            this.labelTeamName.TabIndex = 0;
            this.labelTeamName.Text = "Tournament Name";
            // 
            // labelTeamNameValue
            // 
            this.labelTeamNameValue.Location = new System.Drawing.Point(19, 93);
            this.labelTeamNameValue.Name = "labelTeamNameValue";
            this.labelTeamNameValue.Size = new System.Drawing.Size(231, 23);
            this.labelTeamNameValue.TabIndex = 1;
            // 
            // labelSelectTeamMember
            // 
            this.labelSelectTeamMember.AutoSize = true;
            this.labelSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectTeamMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSelectTeamMember.Location = new System.Drawing.Point(19, 131);
            this.labelSelectTeamMember.Name = "labelSelectTeamMember";
            this.labelSelectTeamMember.Size = new System.Drawing.Size(169, 23);
            this.labelSelectTeamMember.TabIndex = 0;
            this.labelSelectTeamMember.Text = "Select Team Member";
            // 
            // comboBoxTeamMember
            // 
            this.comboBoxTeamMember.FormattingEnabled = true;
            this.comboBoxTeamMember.Location = new System.Drawing.Point(19, 157);
            this.comboBoxTeamMember.Name = "comboBoxTeamMember";
            this.comboBoxTeamMember.Size = new System.Drawing.Size(231, 23);
            this.comboBoxTeamMember.TabIndex = 2;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddMember.Location = new System.Drawing.Point(66, 195);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(122, 39);
            this.buttonAddMember.TabIndex = 6;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCellphone);
            this.groupBox1.Controls.Add(this.buttonCreateMember);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxCellphoneValue);
            this.groupBox1.Controls.Add(this.textBoxEmailValue);
            this.groupBox1.Controls.Add(this.textBoxLastNameValue);
            this.groupBox1.Controls.Add(this.textBoxFirstNameValue);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Location = new System.Drawing.Point(19, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Member";
            // 
            // labelCellphone
            // 
            this.labelCellphone.AutoSize = true;
            this.labelCellphone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCellphone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCellphone.Location = new System.Drawing.Point(6, 156);
            this.labelCellphone.Name = "labelCellphone";
            this.labelCellphone.Size = new System.Drawing.Size(80, 21);
            this.labelCellphone.TabIndex = 0;
            this.labelCellphone.Text = "Cellphone";
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateMember.Location = new System.Drawing.Point(67, 197);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(174, 39);
            this.buttonCreateMember.TabIndex = 6;
            this.buttonCreateMember.Text = "Create Member";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelEmail.Location = new System.Drawing.Point(6, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 21);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLastName.Location = new System.Drawing.Point(6, 74);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 21);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxCellphoneValue
            // 
            this.textBoxCellphoneValue.Location = new System.Drawing.Point(118, 152);
            this.textBoxCellphoneValue.Name = "textBoxCellphoneValue";
            this.textBoxCellphoneValue.Size = new System.Drawing.Size(148, 23);
            this.textBoxCellphoneValue.TabIndex = 4;
            // 
            // textBoxEmailValue
            // 
            this.textBoxEmailValue.Location = new System.Drawing.Point(118, 113);
            this.textBoxEmailValue.Name = "textBoxEmailValue";
            this.textBoxEmailValue.Size = new System.Drawing.Size(148, 23);
            this.textBoxEmailValue.TabIndex = 4;
            // 
            // textBoxLastNameValue
            // 
            this.textBoxLastNameValue.Location = new System.Drawing.Point(118, 74);
            this.textBoxLastNameValue.Name = "textBoxLastNameValue";
            this.textBoxLastNameValue.Size = new System.Drawing.Size(148, 23);
            this.textBoxLastNameValue.TabIndex = 4;
            // 
            // textBoxFirstNameValue
            // 
            this.textBoxFirstNameValue.Location = new System.Drawing.Point(118, 35);
            this.textBoxFirstNameValue.Name = "textBoxFirstNameValue";
            this.textBoxFirstNameValue.Size = new System.Drawing.Size(148, 23);
            this.textBoxFirstNameValue.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(6, 33);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 21);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 15;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(331, 92);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(250, 364);
            this.listBoxTeamMembers.TabIndex = 8;
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteMember.Location = new System.Drawing.Point(587, 243);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(111, 62);
            this.buttonDeleteMember.TabIndex = 5;
            this.buttonDeleteMember.Text = "Delete Member";
            this.buttonDeleteMember.UseVisualStyleBackColor = false;
            // 
            // buttonCreateTeam
            // 
            this.buttonCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateTeam.Location = new System.Drawing.Point(256, 517);
            this.buttonCreateTeam.Name = "buttonCreateTeam";
            this.buttonCreateTeam.Size = new System.Drawing.Size(174, 39);
            this.buttonCreateTeam.TabIndex = 6;
            this.buttonCreateTeam.Text = "Create Team";
            this.buttonCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 568);
            this.Controls.Add(this.buttonCreateTeam);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.comboBoxTeamMember);
            this.Controls.Add(this.labelSelectTeamMember);
            this.Controls.Add(this.labelTeamNameValue);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelCreateTeam);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.TextBox labelTeamNameValue;
        private System.Windows.Forms.Label labelSelectTeamMember;
        private System.Windows.Forms.ComboBox comboBoxTeamMember;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCellphone;
        private System.Windows.Forms.Button buttonCreateMember;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxCellphoneValue;
        private System.Windows.Forms.TextBox textBoxEmailValue;
        private System.Windows.Forms.TextBox textBoxLastNameValue;
        private System.Windows.Forms.TextBox textBoxFirstNameValue;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Button buttonCreateTeam;
    }
}