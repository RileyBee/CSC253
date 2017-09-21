namespace DungeonCrawl_NoyesPrivette
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
            this.exitButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.treasureButton = new System.Windows.Forms.Button();
            this.potionsButton = new System.Windows.Forms.Button();
            this.weaponsButton = new System.Windows.Forms.Button();
            this.mobsButton = new System.Windows.Forms.Button();
            this.roomDescLabel = new System.Windows.Forms.Label();
            this.roomStatusLabel = new System.Windows.Forms.Label();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.playerFormButton = new System.Windows.Forms.Button();
            this.currentPlayerListBox = new System.Windows.Forms.ListBox();
            this.playerDescLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.loadPlayerButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(296, 182);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 30);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(203, 148);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(84, 28);
            this.itemsButton.TabIndex = 22;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // southButton
            // 
            this.southButton.Enabled = false;
            this.southButton.Location = new System.Drawing.Point(295, 136);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(93, 40);
            this.southButton.TabIndex = 21;
            this.southButton.Text = "SOUTH";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(295, 92);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(93, 38);
            this.northButton.TabIndex = 20;
            this.northButton.Text = "NORTH";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // treasureButton
            // 
            this.treasureButton.Location = new System.Drawing.Point(203, 114);
            this.treasureButton.Name = "treasureButton";
            this.treasureButton.Size = new System.Drawing.Size(84, 28);
            this.treasureButton.TabIndex = 19;
            this.treasureButton.Text = "Treasure";
            this.treasureButton.UseVisualStyleBackColor = true;
            this.treasureButton.Click += new System.EventHandler(this.treasureButton_Click);
            // 
            // potionsButton
            // 
            this.potionsButton.Location = new System.Drawing.Point(203, 80);
            this.potionsButton.Name = "potionsButton";
            this.potionsButton.Size = new System.Drawing.Size(84, 28);
            this.potionsButton.TabIndex = 18;
            this.potionsButton.Text = "Potions";
            this.potionsButton.UseVisualStyleBackColor = true;
            this.potionsButton.Click += new System.EventHandler(this.potionsButton_Click);
            // 
            // weaponsButton
            // 
            this.weaponsButton.Location = new System.Drawing.Point(203, 46);
            this.weaponsButton.Name = "weaponsButton";
            this.weaponsButton.Size = new System.Drawing.Size(84, 28);
            this.weaponsButton.TabIndex = 17;
            this.weaponsButton.Text = "Weapons";
            this.weaponsButton.UseVisualStyleBackColor = true;
            this.weaponsButton.Click += new System.EventHandler(this.weaponsButton_Click);
            // 
            // mobsButton
            // 
            this.mobsButton.Location = new System.Drawing.Point(203, 12);
            this.mobsButton.Name = "mobsButton";
            this.mobsButton.Size = new System.Drawing.Size(84, 28);
            this.mobsButton.TabIndex = 16;
            this.mobsButton.Text = "Mobs";
            this.mobsButton.UseVisualStyleBackColor = true;
            this.mobsButton.Click += new System.EventHandler(this.mobsButton_Click);
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Location = new System.Drawing.Point(293, 9);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(96, 17);
            this.roomDescLabel.TabIndex = 15;
            this.roomDescLabel.Text = "Current Room";
            // 
            // roomStatusLabel
            // 
            this.roomStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomStatusLabel.Location = new System.Drawing.Point(293, 26);
            this.roomStatusLabel.Name = "roomStatusLabel";
            this.roomStatusLabel.Size = new System.Drawing.Size(95, 63);
            this.roomStatusLabel.TabIndex = 14;
            this.roomStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 16;
            this.displayListBox.Location = new System.Drawing.Point(12, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(185, 164);
            this.displayListBox.TabIndex = 13;
            // 
            // playerFormButton
            // 
            this.playerFormButton.Location = new System.Drawing.Point(293, 218);
            this.playerFormButton.Name = "playerFormButton";
            this.playerFormButton.Size = new System.Drawing.Size(95, 44);
            this.playerFormButton.TabIndex = 24;
            this.playerFormButton.Text = "Create New Player";
            this.playerFormButton.UseVisualStyleBackColor = true;
            this.playerFormButton.Click += new System.EventHandler(this.playerFormButton_Click);
            // 
            // currentPlayerListBox
            // 
            this.currentPlayerListBox.FormattingEnabled = true;
            this.currentPlayerListBox.ItemHeight = 16;
            this.currentPlayerListBox.Location = new System.Drawing.Point(12, 265);
            this.currentPlayerListBox.Name = "currentPlayerListBox";
            this.currentPlayerListBox.Size = new System.Drawing.Size(185, 164);
            this.currentPlayerListBox.TabIndex = 25;
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.Location = new System.Drawing.Point(52, 201);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(99, 17);
            this.playerDescLabel.TabIndex = 27;
            this.playerDescLabel.Text = "Current Player";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(12, 218);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(185, 44);
            this.playerNameLabel.TabIndex = 26;
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(203, 265);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(185, 164);
            this.playersListBox.TabIndex = 28;
            // 
            // loadPlayerButton
            // 
            this.loadPlayerButton.Location = new System.Drawing.Point(203, 182);
            this.loadPlayerButton.Name = "loadPlayerButton";
            this.loadPlayerButton.Size = new System.Drawing.Size(84, 44);
            this.loadPlayerButton.TabIndex = 29;
            this.loadPlayerButton.Text = "Load Player";
            this.loadPlayerButton.UseVisualStyleBackColor = true;
            this.loadPlayerButton.Click += new System.EventHandler(this.loadPlayerButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(203, 232);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(84, 30);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 441);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loadPlayerButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.playerDescLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.currentPlayerListBox);
            this.Controls.Add(this.playerFormButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.treasureButton);
            this.Controls.Add(this.potionsButton);
            this.Controls.Add(this.weaponsButton);
            this.Controls.Add(this.mobsButton);
            this.Controls.Add(this.roomDescLabel);
            this.Controls.Add(this.roomStatusLabel);
            this.Controls.Add(this.displayListBox);
            this.Name = "Form1";
            this.Text = "Dungeon Crawl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button treasureButton;
        private System.Windows.Forms.Button potionsButton;
        private System.Windows.Forms.Button weaponsButton;
        private System.Windows.Forms.Button mobsButton;
        private System.Windows.Forms.Label roomDescLabel;
        private System.Windows.Forms.Label roomStatusLabel;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button playerFormButton;
        private System.Windows.Forms.ListBox currentPlayerListBox;
        private System.Windows.Forms.Label playerDescLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button loadPlayerButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

