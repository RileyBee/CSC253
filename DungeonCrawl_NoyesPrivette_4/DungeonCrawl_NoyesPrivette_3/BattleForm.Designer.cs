﻿namespace DungeonCrawl_NoyesPrivette_3
{
    partial class BattleForm
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
            this.enemyIDLabel = new System.Windows.Forms.Label();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerIDLabel = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.combatOutputLabel = new System.Windows.Forms.Label();
            this.playerDescLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enemyIDLabel
            // 
            this.enemyIDLabel.AutoSize = true;
            this.enemyIDLabel.ForeColor = System.Drawing.Color.Silver;
            this.enemyIDLabel.Location = new System.Drawing.Point(12, 59);
            this.enemyIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyIDLabel.Name = "enemyIDLabel";
            this.enemyIDLabel.Size = new System.Drawing.Size(59, 17);
            this.enemyIDLabel.TabIndex = 0;
            this.enemyIDLabel.Text = "Enemy: ";
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyNameLabel.ForeColor = System.Drawing.Color.Beige;
            this.enemyNameLabel.Location = new System.Drawing.Point(71, 54);
            this.enemyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(133, 28);
            this.enemyNameLabel.TabIndex = 1;
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHealthLabel.ForeColor = System.Drawing.Color.Beige;
            this.enemyHealthLabel.Location = new System.Drawing.Point(71, 95);
            this.enemyHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(133, 28);
            this.enemyHealthLabel.TabIndex = 3;
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.AutoSize = true;
            this.enemyHPLabel.ForeColor = System.Drawing.Color.Silver;
            this.enemyHPLabel.Location = new System.Drawing.Point(12, 101);
            this.enemyHPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(53, 17);
            this.enemyHPLabel.TabIndex = 2;
            this.enemyHPLabel.Text = "Health:";
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthLabel.ForeColor = System.Drawing.Color.Beige;
            this.playerHealthLabel.Location = new System.Drawing.Point(392, 96);
            this.playerHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(133, 28);
            this.playerHealthLabel.TabIndex = 7;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.AutoSize = true;
            this.playerHPLabel.ForeColor = System.Drawing.Color.Silver;
            this.playerHPLabel.Location = new System.Drawing.Point(329, 102);
            this.playerHPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(53, 17);
            this.playerHPLabel.TabIndex = 6;
            this.playerHPLabel.Text = "Health:";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerNameLabel.ForeColor = System.Drawing.Color.Beige;
            this.playerNameLabel.Location = new System.Drawing.Point(392, 55);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(133, 28);
            this.playerNameLabel.TabIndex = 5;
            // 
            // playerIDLabel
            // 
            this.playerIDLabel.AutoSize = true;
            this.playerIDLabel.ForeColor = System.Drawing.Color.Silver;
            this.playerIDLabel.Location = new System.Drawing.Point(333, 62);
            this.playerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerIDLabel.Name = "playerIDLabel";
            this.playerIDLabel.Size = new System.Drawing.Size(56, 17);
            this.playerIDLabel.TabIndex = 4;
            this.playerIDLabel.Text = "Player: ";
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.DarkRed;
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.ForeColor = System.Drawing.Color.Beige;
            this.attackButton.Location = new System.Drawing.Point(223, 55);
            this.attackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(93, 68);
            this.attackButton.TabIndex = 8;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // combatOutputLabel
            // 
            this.combatOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatOutputLabel.ForeColor = System.Drawing.Color.Beige;
            this.combatOutputLabel.Location = new System.Drawing.Point(109, 171);
            this.combatOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatOutputLabel.Name = "combatOutputLabel";
            this.combatOutputLabel.Size = new System.Drawing.Size(346, 80);
            this.combatOutputLabel.TabIndex = 9;
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.playerDescLabel.Location = new System.Drawing.Point(217, 139);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(123, 27);
            this.playerDescLabel.TabIndex = 10;
            this.playerDescLabel.Text = "Combat Log";
            this.playerDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Click Attack to Begin Battle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(541, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerDescLabel);
            this.Controls.Add(this.combatOutputLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.playerHPLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerIDLabel);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.enemyHPLabel);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.enemyIDLabel);
            this.Controls.Add(this.attackButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BattleForm";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enemyIDLabel;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.Label enemyHPLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerIDLabel;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label combatOutputLabel;
        private System.Windows.Forms.Label playerDescLabel;
        private System.Windows.Forms.Label label1;
    }
}