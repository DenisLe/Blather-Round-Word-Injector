
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.altSpellingTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoryComboBox = new System.Windows.Forms.ComboBox();
            this.clueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bannedTextBox = new System.Windows.Forms.TextBox();
            this.yourClueListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sendToYourClues = new System.Windows.Forms.Button();
            this.hintTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedClueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FalseRadioButton = new System.Windows.Forms.RadioButton();
            this.TrueRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(139, 39);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subcategory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(429, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alt. Spellings";
            // 
            // altSpellingTextBox
            // 
            this.altSpellingTextBox.Location = new System.Drawing.Point(550, 41);
            this.altSpellingTextBox.Name = "altSpellingTextBox";
            this.altSpellingTextBox.Size = new System.Drawing.Size(336, 20);
            this.altSpellingTextBox.TabIndex = 6;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "story",
            "person",
            "place",
            "thing"});
            this.categoryComboBox.Location = new System.Drawing.Point(139, 78);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 7;
            // 
            // subcategoryComboBox
            // 
            this.subcategoryComboBox.FormattingEnabled = true;
            this.subcategoryComboBox.Location = new System.Drawing.Point(139, 114);
            this.subcategoryComboBox.Name = "subcategoryComboBox";
            this.subcategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.subcategoryComboBox.TabIndex = 8;
            // 
            // clueListView
            // 
            this.clueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.clueListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clueListView.HideSelection = false;
            this.clueListView.Location = new System.Drawing.Point(38, 272);
            this.clueListView.MultiSelect = false;
            this.clueListView.Name = "clueListView";
            this.clueListView.Size = new System.Drawing.Size(302, 366);
            this.clueListView.TabIndex = 10;
            this.clueListView.UseCompatibleStateImageBehavior = false;
            this.clueListView.View = System.Windows.Forms.View.Details;
            this.clueListView.SelectedIndexChanged += new System.EventHandler(this.clueListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "General Clue Types";
            this.columnHeader1.Width = 160;
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(57, 21);
            this.easyRadioButton.TabIndex = 11;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(6, 42);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(75, 21);
            this.mediumRadioButton.TabIndex = 12;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(6, 65);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(57, 21);
            this.hardRadioButton.TabIndex = 13;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.easyRadioButton);
            this.groupBox1.Controls.Add(this.hardRadioButton);
            this.groupBox1.Controls.Add(this.mediumRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(39, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(429, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Banned Words";
            // 
            // bannedTextBox
            // 
            this.bannedTextBox.Location = new System.Drawing.Point(550, 78);
            this.bannedTextBox.Name = "bannedTextBox";
            this.bannedTextBox.Size = new System.Drawing.Size(336, 20);
            this.bannedTextBox.TabIndex = 16;
            // 
            // yourClueListView
            // 
            this.yourClueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.yourClueListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yourClueListView.HideSelection = false;
            this.yourClueListView.Location = new System.Drawing.Point(550, 272);
            this.yourClueListView.Name = "yourClueListView";
            this.yourClueListView.Size = new System.Drawing.Size(389, 366);
            this.yourClueListView.TabIndex = 17;
            this.yourClueListView.UseCompatibleStateImageBehavior = false;
            this.yourClueListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Your Clues";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hint";
            this.columnHeader3.Width = 175;
            // 
            // sendToYourClues
            // 
            this.sendToYourClues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendToYourClues.Location = new System.Drawing.Point(387, 429);
            this.sendToYourClues.Name = "sendToYourClues";
            this.sendToYourClues.Size = new System.Drawing.Size(112, 46);
            this.sendToYourClues.TabIndex = 18;
            this.sendToYourClues.Text = "Add To Your Cluelist";
            this.sendToYourClues.UseVisualStyleBackColor = true;
            this.sendToYourClues.Click += new System.EventHandler(this.sendToYourClues_Click);
            // 
            // hintTextBox
            // 
            this.hintTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hintTextBox.Location = new System.Drawing.Point(362, 381);
            this.hintTextBox.Name = "hintTextBox";
            this.hintTextBox.Size = new System.Drawing.Size(167, 23);
            this.hintTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(365, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hint for Selected Clue";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(403, 593);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "Finalize";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(391, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Selected Clue";
            // 
            // selectedClueTextBox
            // 
            this.selectedClueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectedClueTextBox.Location = new System.Drawing.Point(362, 295);
            this.selectedClueTextBox.Name = "selectedClueTextBox";
            this.selectedClueTextBox.ReadOnly = true;
            this.selectedClueTextBox.Size = new System.Drawing.Size(167, 23);
            this.selectedClueTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(429, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(550, 113);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(336, 20);
            this.IDtextBox.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FalseRadioButton);
            this.groupBox2.Controls.Add(this.TrueRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(433, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 73);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "US";
            // 
            // FalseRadioButton
            // 
            this.FalseRadioButton.AutoSize = true;
            this.FalseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FalseRadioButton.Location = new System.Drawing.Point(10, 42);
            this.FalseRadioButton.Name = "FalseRadioButton";
            this.FalseRadioButton.Size = new System.Drawing.Size(60, 21);
            this.FalseRadioButton.TabIndex = 1;
            this.FalseRadioButton.TabStop = true;
            this.FalseRadioButton.Text = "False";
            this.FalseRadioButton.UseVisualStyleBackColor = true;
            // 
            // TrueRadioButton
            // 
            this.TrueRadioButton.AutoSize = true;
            this.TrueRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TrueRadioButton.Location = new System.Drawing.Point(10, 19);
            this.TrueRadioButton.Name = "TrueRadioButton";
            this.TrueRadioButton.Size = new System.Drawing.Size(56, 21);
            this.TrueRadioButton.TabIndex = 0;
            this.TrueRadioButton.TabStop = true;
            this.TrueRadioButton.Text = "True";
            this.TrueRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteButton.Location = new System.Drawing.Point(387, 508);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 47);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete From Cluelist";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 650);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectedClueTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hintTextBox);
            this.Controls.Add(this.sendToYourClues);
            this.Controls.Add(this.yourClueListView);
            this.Controls.Add(this.bannedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clueListView);
            this.Controls.Add(this.subcategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.altSpellingTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Blather Word Injector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox altSpellingTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox subcategoryComboBox;
        private System.Windows.Forms.ListView clueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bannedTextBox;
        private System.Windows.Forms.ListView yourClueListView;
        private System.Windows.Forms.Button sendToYourClues;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox hintTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectedClueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FalseRadioButton;
        private System.Windows.Forms.RadioButton TrueRadioButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

