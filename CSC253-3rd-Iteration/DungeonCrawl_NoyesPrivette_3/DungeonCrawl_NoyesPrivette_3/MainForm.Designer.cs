namespace DungeonCrawl_NoyesPrivette_3
{
    partial class MainForm
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
            this.playerDescLabel = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryDescLabel = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.roomDescLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treasureChestListBox = new System.Windows.Forms.ListBox();
            this.enemyListBox = new System.Windows.Forms.ListBox();
            this.enemyDescLabel = new System.Windows.Forms.Label();
            this.treasureBoxDescLabel = new System.Windows.Forms.Label();
            this.southButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.fightButton = new System.Windows.Forms.Button();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.infoDescLabel = new System.Windows.Forms.Label();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDescLabel.Location = new System.Drawing.Point(107, 17);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(68, 27);
            this.playerDescLabel.TabIndex = 0;
            this.playerDescLabel.Text = "Player";
            this.playerDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 16;
            this.playerListBox.Location = new System.Drawing.Point(51, 47);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(200, 196);
            this.playerListBox.TabIndex = 1;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(51, 294);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(200, 244);
            this.inventoryListBox.TabIndex = 3;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // inventoryDescLabel
            // 
            this.inventoryDescLabel.AutoSize = true;
            this.inventoryDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDescLabel.Location = new System.Drawing.Point(93, 264);
            this.inventoryDescLabel.Name = "inventoryDescLabel";
            this.inventoryDescLabel.Size = new System.Drawing.Size(102, 27);
            this.inventoryDescLabel.TabIndex = 2;
            this.inventoryDescLabel.Text = "Inventory";
            this.inventoryDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventListBox
            // 
            this.eventListBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 24;
            this.eventListBox.Location = new System.Drawing.Point(304, 462);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(400, 76);
            this.eventListBox.TabIndex = 4;
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescLabel.Location = new System.Drawing.Point(472, 17);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(66, 27);
            this.roomDescLabel.TabIndex = 6;
            this.roomDescLabel.Text = "Room";
            this.roomDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treasureChestListBox);
            this.groupBox1.Controls.Add(this.enemyListBox);
            this.groupBox1.Controls.Add(this.enemyDescLabel);
            this.groupBox1.Controls.Add(this.treasureBoxDescLabel);
            this.groupBox1.Location = new System.Drawing.Point(304, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // treasureChestListBox
            // 
            this.treasureChestListBox.FormattingEnabled = true;
            this.treasureChestListBox.ItemHeight = 16;
            this.treasureChestListBox.Location = new System.Drawing.Point(206, 38);
            this.treasureChestListBox.Name = "treasureChestListBox";
            this.treasureChestListBox.Size = new System.Drawing.Size(188, 148);
            this.treasureChestListBox.TabIndex = 10;
            this.treasureChestListBox.SelectedIndexChanged += new System.EventHandler(this.treasureChestListBox_SelectedIndexChanged);
            // 
            // enemyListBox
            // 
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.ItemHeight = 16;
            this.enemyListBox.Location = new System.Drawing.Point(6, 38);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(188, 148);
            this.enemyListBox.TabIndex = 9;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.enemyListBox_SelectedIndexChanged);
            // 
            // enemyDescLabel
            // 
            this.enemyDescLabel.AutoSize = true;
            this.enemyDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyDescLabel.Location = new System.Drawing.Point(63, 15);
            this.enemyDescLabel.Name = "enemyDescLabel";
            this.enemyDescLabel.Size = new System.Drawing.Size(65, 20);
            this.enemyDescLabel.TabIndex = 8;
            this.enemyDescLabel.Text = "Enemies";
            this.enemyDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treasureBoxDescLabel
            // 
            this.treasureBoxDescLabel.AutoSize = true;
            this.treasureBoxDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureBoxDescLabel.Location = new System.Drawing.Point(245, 15);
            this.treasureBoxDescLabel.Name = "treasureBoxDescLabel";
            this.treasureBoxDescLabel.Size = new System.Drawing.Size(108, 20);
            this.treasureBoxDescLabel.TabIndex = 12;
            this.treasureBoxDescLabel.Text = "Treasure Chest";
            this.treasureBoxDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(620, 345);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(84, 45);
            this.southButton.TabIndex = 20;
            this.southButton.Text = "Move South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(620, 294);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(84, 45);
            this.northButton.TabIndex = 18;
            this.northButton.Text = "Move North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(530, 294);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(84, 96);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight Enemy";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 16;
            this.infoListBox.Location = new System.Drawing.Point(304, 294);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(188, 148);
            this.infoListBox.TabIndex = 13;
            // 
            // infoDescLabel
            // 
            this.infoDescLabel.AutoSize = true;
            this.infoDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDescLabel.Location = new System.Drawing.Point(340, 264);
            this.infoDescLabel.Name = "infoDescLabel";
            this.infoDescLabel.Size = new System.Drawing.Size(123, 27);
            this.infoDescLabel.TabIndex = 22;
            this.infoDescLabel.Text = "Information";
            this.infoDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescLabel.Location = new System.Drawing.Point(515, 432);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(73, 27);
            this.eventDescLabel.TabIndex = 23;
            this.eventDescLabel.Text = "Events";
            this.eventDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 585);
            this.Controls.Add(this.eventDescLabel);
            this.Controls.Add(this.infoDescLabel);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.roomDescLabel);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.inventoryDescLabel);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerDescLabel);
            this.Name = "MainForm";
            this.Text = "Dungeon Crawl";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerDescLabel;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label inventoryDescLabel;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Label roomDescLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox treasureChestListBox;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Label enemyDescLabel;
        private System.Windows.Forms.Label treasureBoxDescLabel;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Label infoDescLabel;
        private System.Windows.Forms.Label eventDescLabel;
    }
}

