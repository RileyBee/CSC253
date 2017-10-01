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
            this.mobListBox = new System.Windows.Forms.ListBox();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 274);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 24);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(185, 246);
            this.itemsButton.Margin = new System.Windows.Forms.Padding(2);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(63, 23);
            this.itemsButton.TabIndex = 22;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // southButton
            // 
            this.southButton.Enabled = false;
            this.southButton.Location = new System.Drawing.Point(254, 236);
            this.southButton.Margin = new System.Windows.Forms.Padding(2);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(70, 32);
            this.southButton.TabIndex = 21;
            this.southButton.Text = "SOUTH";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(254, 201);
            this.northButton.Margin = new System.Windows.Forms.Padding(2);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(70, 31);
            this.northButton.TabIndex = 20;
            this.northButton.Text = "NORTH";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // treasureButton
            // 
            this.treasureButton.Location = new System.Drawing.Point(185, 219);
            this.treasureButton.Margin = new System.Windows.Forms.Padding(2);
            this.treasureButton.Name = "treasureButton";
            this.treasureButton.Size = new System.Drawing.Size(63, 23);
            this.treasureButton.TabIndex = 19;
            this.treasureButton.Text = "Treasure";
            this.treasureButton.UseVisualStyleBackColor = true;
            this.treasureButton.Click += new System.EventHandler(this.treasureButton_Click);
            // 
            // potionsButton
            // 
            this.potionsButton.Location = new System.Drawing.Point(185, 191);
            this.potionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.potionsButton.Name = "potionsButton";
            this.potionsButton.Size = new System.Drawing.Size(63, 23);
            this.potionsButton.TabIndex = 18;
            this.potionsButton.Text = "Potions";
            this.potionsButton.UseVisualStyleBackColor = true;
            this.potionsButton.Click += new System.EventHandler(this.potionsButton_Click);
            // 
            // weaponsButton
            // 
            this.weaponsButton.Location = new System.Drawing.Point(185, 163);
            this.weaponsButton.Margin = new System.Windows.Forms.Padding(2);
            this.weaponsButton.Name = "weaponsButton";
            this.weaponsButton.Size = new System.Drawing.Size(63, 23);
            this.weaponsButton.TabIndex = 17;
            this.weaponsButton.Text = "Weapons";
            this.weaponsButton.UseVisualStyleBackColor = true;
            this.weaponsButton.Click += new System.EventHandler(this.weaponsButton_Click);
            // 
            // mobsButton
            // 
            this.mobsButton.Location = new System.Drawing.Point(185, 136);
            this.mobsButton.Margin = new System.Windows.Forms.Padding(2);
            this.mobsButton.Name = "mobsButton";
            this.mobsButton.Size = new System.Drawing.Size(63, 23);
            this.mobsButton.TabIndex = 16;
            this.mobsButton.Text = "Mobs";
            this.mobsButton.UseVisualStyleBackColor = true;
            this.mobsButton.Click += new System.EventHandler(this.mobsButton_Click);
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Location = new System.Drawing.Point(253, 133);
            this.roomDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(72, 13);
            this.roomDescLabel.TabIndex = 15;
            this.roomDescLabel.Text = "Current Room";
            // 
            // roomStatusLabel
            // 
            this.roomStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomStatusLabel.Location = new System.Drawing.Point(253, 147);
            this.roomStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomStatusLabel.Name = "roomStatusLabel";
            this.roomStatusLabel.Size = new System.Drawing.Size(72, 52);
            this.roomStatusLabel.TabIndex = 14;
            this.roomStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(9, 10);
            this.displayListBox.Margin = new System.Windows.Forms.Padding(2);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(163, 160);
            this.displayListBox.TabIndex = 13;
            // 
            // playerFormButton
            // 
            this.playerFormButton.Location = new System.Drawing.Point(253, 303);
            this.playerFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.playerFormButton.Name = "playerFormButton";
            this.playerFormButton.Size = new System.Drawing.Size(71, 36);
            this.playerFormButton.TabIndex = 24;
            this.playerFormButton.Text = "Create New Player";
            this.playerFormButton.UseVisualStyleBackColor = true;
            this.playerFormButton.Click += new System.EventHandler(this.playerFormButton_Click);
            // 
            // currentPlayerListBox
            // 
            this.currentPlayerListBox.FormattingEnabled = true;
            this.currentPlayerListBox.Location = new System.Drawing.Point(185, 66);
            this.currentPlayerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentPlayerListBox.Name = "currentPlayerListBox";
            this.currentPlayerListBox.Size = new System.Drawing.Size(139, 56);
            this.currentPlayerListBox.TabIndex = 25;
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.Location = new System.Drawing.Point(217, 9);
            this.playerDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(73, 13);
            this.playerDescLabel.TabIndex = 27;
            this.playerDescLabel.Text = "Current Player";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(185, 25);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(139, 36);
            this.playerNameLabel.TabIndex = 26;
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(342, 9);
            this.playersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(161, 160);
            this.playersListBox.TabIndex = 28;
            // 
            // loadPlayerButton
            // 
            this.loadPlayerButton.Location = new System.Drawing.Point(185, 274);
            this.loadPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadPlayerButton.Name = "loadPlayerButton";
            this.loadPlayerButton.Size = new System.Drawing.Size(63, 36);
            this.loadPlayerButton.TabIndex = 29;
            this.loadPlayerButton.Text = "Load Player";
            this.loadPlayerButton.UseVisualStyleBackColor = true;
            this.loadPlayerButton.Click += new System.EventHandler(this.loadPlayerButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(185, 314);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(63, 24);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // mobListBox
            // 
            this.mobListBox.FormattingEnabled = true;
            this.mobListBox.Items.AddRange(new object[] {
            "Kobold",
            "Drow",
            "Orc",
            "Lich"});
            this.mobListBox.Location = new System.Drawing.Point(9, 191);
            this.mobListBox.Name = "mobListBox";
            this.mobListBox.Size = new System.Drawing.Size(163, 147);
            this.mobListBox.TabIndex = 31;
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(342, 178);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(161, 160);
            this.InventoryListBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 353);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.mobListBox);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox mobListBox;
        private System.Windows.Forms.ListBox InventoryListBox;
    }
}

