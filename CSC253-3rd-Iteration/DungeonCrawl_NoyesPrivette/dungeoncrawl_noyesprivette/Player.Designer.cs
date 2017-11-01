namespace DungeonCrawl_NoyesPrivette
{
    partial class Player
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
            this.nameInstructLabel1 = new System.Windows.Forms.Label();
            this.classInstructLabel = new System.Windows.Forms.Label();
            this.passInstructLabel1 = new System.Windows.Forms.Label();
            this.passInstructLabel2 = new System.Windows.Forms.Label();
            this.raceInstructLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameInstructLabel2 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passInstructLabel3 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInstructLabel1
            // 
            this.nameInstructLabel1.AutoSize = true;
            this.nameInstructLabel1.Location = new System.Drawing.Point(9, 7);
            this.nameInstructLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameInstructLabel1.Name = "nameInstructLabel1";
            this.nameInstructLabel1.Size = new System.Drawing.Size(148, 13);
            this.nameInstructLabel1.TabIndex = 0;
            this.nameInstructLabel1.Text = "Enter your new player\'s name.";
            // 
            // classInstructLabel
            // 
            this.classInstructLabel.AutoSize = true;
            this.classInstructLabel.Location = new System.Drawing.Point(9, 157);
            this.classInstructLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classInstructLabel.Name = "classInstructLabel";
            this.classInstructLabel.Size = new System.Drawing.Size(76, 13);
            this.classInstructLabel.TabIndex = 1;
            this.classInstructLabel.Text = "Select a class.";
            // 
            // passInstructLabel1
            // 
            this.passInstructLabel1.AutoSize = true;
            this.passInstructLabel1.Location = new System.Drawing.Point(9, 74);
            this.passInstructLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passInstructLabel1.Name = "passInstructLabel1";
            this.passInstructLabel1.Size = new System.Drawing.Size(215, 13);
            this.passInstructLabel1.TabIndex = 2;
            this.passInstructLabel1.Text = " Enter a password. It must be no longer than";
            // 
            // passInstructLabel2
            // 
            this.passInstructLabel2.AutoSize = true;
            this.passInstructLabel2.Location = new System.Drawing.Point(19, 88);
            this.passInstructLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passInstructLabel2.Name = "passInstructLabel2";
            this.passInstructLabel2.Size = new System.Drawing.Size(220, 13);
            this.passInstructLabel2.TabIndex = 3;
            this.passInstructLabel2.Text = "12 characters and contain 1 lowercase letter,";
            // 
            // raceInstructLabel
            // 
            this.raceInstructLabel.AutoSize = true;
            this.raceInstructLabel.Location = new System.Drawing.Point(9, 214);
            this.raceInstructLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raceInstructLabel.Name = "raceInstructLabel";
            this.raceInstructLabel.Size = new System.Drawing.Size(73, 13);
            this.raceInstructLabel.TabIndex = 4;
            this.raceInstructLabel.Text = "Select a race.";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 37);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.Location = new System.Drawing.Point(19, 21);
            this.nameInstructLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(189, 13);
            this.nameInstructLabel2.TabIndex = 6;
            this.nameInstructLabel2.Text = "It must be no more than 12 characters.";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(9, 118);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(200, 20);
            this.passTextBox.TabIndex = 7;
            // 
            // passInstructLabel3
            // 
            this.passInstructLabel3.AutoSize = true;
            this.passInstructLabel3.Location = new System.Drawing.Point(19, 102);
            this.passInstructLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passInstructLabel3.Name = "passInstructLabel3";
            this.passInstructLabel3.Size = new System.Drawing.Size(212, 13);
            this.passInstructLabel3.TabIndex = 8;
            this.passInstructLabel3.Text = "1 uppercase letter, and 1 special character.";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Thief",
            "Mage",
            "Warrior",
            "Cleric",
            "Barbarian"});
            this.classComboBox.Location = new System.Drawing.Point(9, 173);
            this.classComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(92, 21);
            this.classComboBox.TabIndex = 9;
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Orc",
            "Goblin",
            "Dwarf"});
            this.raceComboBox.Location = new System.Drawing.Point(9, 231);
            this.raceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(92, 21);
            this.raceComboBox.TabIndex = 10;
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Location = new System.Drawing.Point(143, 175);
            this.createPlayerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(81, 54);
            this.createPlayerButton.TabIndex = 11;
            this.createPlayerButton.Text = "Create New Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 262);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.passInstructLabel3);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.nameInstructLabel2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.raceInstructLabel);
            this.Controls.Add(this.passInstructLabel2);
            this.Controls.Add(this.passInstructLabel1);
            this.Controls.Add(this.classInstructLabel);
            this.Controls.Add(this.nameInstructLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Player";
            this.Text = "Create New Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameInstructLabel1;
        private System.Windows.Forms.Label classInstructLabel;
        private System.Windows.Forms.Label passInstructLabel1;
        private System.Windows.Forms.Label passInstructLabel2;
        private System.Windows.Forms.Label raceInstructLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameInstructLabel2;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passInstructLabel3;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Button createPlayerButton;
    }
}