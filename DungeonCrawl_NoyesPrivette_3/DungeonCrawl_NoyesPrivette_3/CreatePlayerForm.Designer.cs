namespace DungeonCrawl_NoyesPrivette_3
{
    partial class CreatePlayerForm
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
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.castComboBox = new System.Windows.Forms.ComboBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.passInstructLabel3 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nameInstructLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.raceInstructLabel = new System.Windows.Forms.Label();
            this.passInstructLabel2 = new System.Windows.Forms.Label();
            this.passInstructLabel1 = new System.Windows.Forms.Label();
            this.castInstructLabel = new System.Windows.Forms.Label();
            this.nameInstructLabel1 = new System.Windows.Forms.Label();
            this.descInstructLabel2 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descInstructLabel1 = new System.Windows.Forms.Label();
            this.castListBox = new System.Windows.Forms.ListBox();
            this.raceListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.Location = new System.Drawing.Point(400, 146);
            this.createPlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(108, 66);
            this.createPlayerButton.TabIndex = 23;
            this.createPlayerButton.Text = "Create";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // castComboBox
            // 
            this.castComboBox.FormattingEnabled = true;
            this.castComboBox.Items.AddRange(new object[] {
            "Barbarian",
            "Cleric",
            "Mage",
            "Thief",
            "Warrior"});
            this.castComboBox.Location = new System.Drawing.Point(15, 267);
            this.castComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.castComboBox.Name = "castComboBox";
            this.castComboBox.Size = new System.Drawing.Size(121, 24);
            this.castComboBox.TabIndex = 22;
            this.castComboBox.SelectedIndexChanged += new System.EventHandler(this.castComboBox_SelectedIndexChanged);
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Goblin",
            "Human",
            "Orc"});
            this.raceComboBox.Location = new System.Drawing.Point(350, 267);
            this.raceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(121, 24);
            this.raceComboBox.TabIndex = 21;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // passInstructLabel3
            // 
            this.passInstructLabel3.AutoSize = true;
            this.passInstructLabel3.Location = new System.Drawing.Point(12, 163);
            this.passInstructLabel3.Name = "passInstructLabel3";
            this.passInstructLabel3.Size = new System.Drawing.Size(283, 17);
            this.passInstructLabel3.TabIndex = 20;
            this.passInstructLabel3.Text = "1 uppercase letter, and 1 special character.";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(15, 183);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(265, 22);
            this.passTextBox.TabIndex = 19;
            // 
            // nameInstructLabel2
            // 
            this.nameInstructLabel2.AutoSize = true;
            this.nameInstructLabel2.Location = new System.Drawing.Point(25, 50);
            this.nameInstructLabel2.Name = "nameInstructLabel2";
            this.nameInstructLabel2.Size = new System.Drawing.Size(252, 17);
            this.nameInstructLabel2.TabIndex = 18;
            this.nameInstructLabel2.Text = "It must be no more than 20 characters.";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 70);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 22);
            this.nameTextBox.TabIndex = 17;
            // 
            // raceInstructLabel
            // 
            this.raceInstructLabel.AutoSize = true;
            this.raceInstructLabel.Location = new System.Drawing.Point(361, 248);
            this.raceInstructLabel.Name = "raceInstructLabel";
            this.raceInstructLabel.Size = new System.Drawing.Size(95, 17);
            this.raceInstructLabel.TabIndex = 16;
            this.raceInstructLabel.Text = "Select a race.";
            // 
            // passInstructLabel2
            // 
            this.passInstructLabel2.AutoSize = true;
            this.passInstructLabel2.Location = new System.Drawing.Point(12, 146);
            this.passInstructLabel2.Name = "passInstructLabel2";
            this.passInstructLabel2.Size = new System.Drawing.Size(292, 17);
            this.passInstructLabel2.TabIndex = 15;
            this.passInstructLabel2.Text = "10 characters and contain 1 lowercase letter,";
            // 
            // passInstructLabel1
            // 
            this.passInstructLabel1.AutoSize = true;
            this.passInstructLabel1.Location = new System.Drawing.Point(12, 129);
            this.passInstructLabel1.Name = "passInstructLabel1";
            this.passInstructLabel1.Size = new System.Drawing.Size(279, 17);
            this.passInstructLabel1.TabIndex = 14;
            this.passInstructLabel1.Text = " Enter a password. It must be no more than";
            // 
            // castInstructLabel
            // 
            this.castInstructLabel.AutoSize = true;
            this.castInstructLabel.Location = new System.Drawing.Point(28, 248);
            this.castInstructLabel.Name = "castInstructLabel";
            this.castInstructLabel.Size = new System.Drawing.Size(93, 17);
            this.castInstructLabel.TabIndex = 13;
            this.castInstructLabel.Text = "Select a cast.";
            // 
            // nameInstructLabel1
            // 
            this.nameInstructLabel1.AutoSize = true;
            this.nameInstructLabel1.Location = new System.Drawing.Point(12, 33);
            this.nameInstructLabel1.Name = "nameInstructLabel1";
            this.nameInstructLabel1.Size = new System.Drawing.Size(199, 17);
            this.nameInstructLabel1.TabIndex = 12;
            this.nameInstructLabel1.Text = "Enter your new player\'s name.";
            // 
            // descInstructLabel2
            // 
            this.descInstructLabel2.AutoSize = true;
            this.descInstructLabel2.Location = new System.Drawing.Point(328, 50);
            this.descInstructLabel2.Name = "descInstructLabel2";
            this.descInstructLabel2.Size = new System.Drawing.Size(252, 17);
            this.descInstructLabel2.TabIndex = 26;
            this.descInstructLabel2.Text = "It must be no more than 40 characters.";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(315, 70);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(265, 22);
            this.descTextBox.TabIndex = 25;
            // 
            // descInstructLabel1
            // 
            this.descInstructLabel1.AutoSize = true;
            this.descInstructLabel1.Location = new System.Drawing.Point(312, 33);
            this.descInstructLabel1.Name = "descInstructLabel1";
            this.descInstructLabel1.Size = new System.Drawing.Size(256, 17);
            this.descInstructLabel1.TabIndex = 24;
            this.descInstructLabel1.Text = "Enter a description for your new player.";
            // 
            // castListBox
            // 
            this.castListBox.FormattingEnabled = true;
            this.castListBox.ItemHeight = 16;
            this.castListBox.Location = new System.Drawing.Point(15, 294);
            this.castListBox.Name = "castListBox";
            this.castListBox.Size = new System.Drawing.Size(230, 116);
            this.castListBox.TabIndex = 27;
            // 
            // raceListBox
            // 
            this.raceListBox.FormattingEnabled = true;
            this.raceListBox.ItemHeight = 16;
            this.raceListBox.Location = new System.Drawing.Point(350, 294);
            this.raceListBox.Name = "raceListBox";
            this.raceListBox.Size = new System.Drawing.Size(230, 116);
            this.raceListBox.TabIndex = 28;
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 421);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.castListBox);
            this.Controls.Add(this.descInstructLabel2);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descInstructLabel1);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.castComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.passInstructLabel3);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.nameInstructLabel2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.raceInstructLabel);
            this.Controls.Add(this.passInstructLabel2);
            this.Controls.Add(this.passInstructLabel1);
            this.Controls.Add(this.castInstructLabel);
            this.Controls.Add(this.nameInstructLabel1);
            this.Name = "CreatePlayerForm";
            this.Text = "CreatePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.ComboBox castComboBox;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label passInstructLabel3;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label nameInstructLabel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label raceInstructLabel;
        private System.Windows.Forms.Label passInstructLabel2;
        private System.Windows.Forms.Label passInstructLabel1;
        private System.Windows.Forms.Label castInstructLabel;
        private System.Windows.Forms.Label nameInstructLabel1;
        private System.Windows.Forms.Label descInstructLabel2;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descInstructLabel1;
        private System.Windows.Forms.ListBox castListBox;
        private System.Windows.Forms.ListBox raceListBox;
    }
}