namespace M1P1_Noyes_Privette
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
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.roomStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mobsButton = new System.Windows.Forms.Button();
            this.weaponsButton = new System.Windows.Forms.Button();
            this.potionsButton = new System.Windows.Forms.Button();
            this.treasureButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 15;
            this.displayListBox.Location = new System.Drawing.Point(12, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(185, 169);
            this.displayListBox.TabIndex = 0;
            // 
            // roomStatusLabel
            // 
            this.roomStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomStatusLabel.Location = new System.Drawing.Point(326, 27);
            this.roomStatusLabel.Name = "roomStatusLabel";
            this.roomStatusLabel.Size = new System.Drawing.Size(89, 28);
            this.roomStatusLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Room";
            // 
            // mobsButton
            // 
            this.mobsButton.Location = new System.Drawing.Point(218, 12);
            this.mobsButton.Name = "mobsButton";
            this.mobsButton.Size = new System.Drawing.Size(84, 28);
            this.mobsButton.TabIndex = 5;
            this.mobsButton.Text = "Mobs";
            this.mobsButton.UseVisualStyleBackColor = true;
            // 
            // weaponsButton
            // 
            this.weaponsButton.Location = new System.Drawing.Point(218, 47);
            this.weaponsButton.Name = "weaponsButton";
            this.weaponsButton.Size = new System.Drawing.Size(84, 28);
            this.weaponsButton.TabIndex = 6;
            this.weaponsButton.Text = "Weapons";
            this.weaponsButton.UseVisualStyleBackColor = true;
            this.weaponsButton.Click += new System.EventHandler(this.weaponsButton_Click);
            // 
            // potionsButton
            // 
            this.potionsButton.Location = new System.Drawing.Point(218, 84);
            this.potionsButton.Name = "potionsButton";
            this.potionsButton.Size = new System.Drawing.Size(84, 28);
            this.potionsButton.TabIndex = 7;
            this.potionsButton.Text = "Potions";
            this.potionsButton.UseVisualStyleBackColor = true;
            this.potionsButton.Click += new System.EventHandler(this.potionsButton_Click);
            // 
            // treasureButton
            // 
            this.treasureButton.Location = new System.Drawing.Point(218, 118);
            this.treasureButton.Name = "treasureButton";
            this.treasureButton.Size = new System.Drawing.Size(84, 28);
            this.treasureButton.TabIndex = 8;
            this.treasureButton.Text = "Treasure";
            this.treasureButton.UseVisualStyleBackColor = true;
            this.treasureButton.Click += new System.EventHandler(this.treasureButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(338, 62);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(59, 38);
            this.northButton.TabIndex = 9;
            this.northButton.Text = "NORTH";
            this.northButton.UseVisualStyleBackColor = true;
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(339, 106);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(58, 40);
            this.southButton.TabIndex = 10;
            this.southButton.Text = "SOUTH";
            this.southButton.UseVisualStyleBackColor = true;
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(218, 153);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(84, 28);
            this.itemsButton.TabIndex = 11;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(330, 158);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 200);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.treasureButton);
            this.Controls.Add(this.potionsButton);
            this.Controls.Add(this.weaponsButton);
            this.Controls.Add(this.mobsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomStatusLabel);
            this.Controls.Add(this.displayListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Dungeon Crawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Label roomStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mobsButton;
        private System.Windows.Forms.Button weaponsButton;
        private System.Windows.Forms.Button potionsButton;
        private System.Windows.Forms.Button treasureButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

