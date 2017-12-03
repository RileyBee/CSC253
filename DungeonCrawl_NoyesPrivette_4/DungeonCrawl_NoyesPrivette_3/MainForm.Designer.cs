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
            this.components = new System.ComponentModel.Container();
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
            this.objectsDataSet = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSet();
            this.castsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.castsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.CastsTableAdapter();
            this.tableAdapterManager = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager();
            this.enemiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enemiesTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.EnemiesTableAdapter();
            this.lootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lootTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.LootTableAdapter();
            this.potionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potionsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PotionsTableAdapter();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RacesTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RoomsTableAdapter();
            this.trinketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinketsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TrinketsTableAdapter();
            this.weaponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weaponsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.WeaponsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.playerDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.playerDescLabel.Location = new System.Drawing.Point(80, 14);
            this.playerDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(56, 22);
            this.playerDescLabel.TabIndex = 0;
            this.playerDescLabel.Text = "Player";
            this.playerDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerListBox
            // 
            this.playerListBox.BackColor = System.Drawing.Color.Black;
            this.playerListBox.ForeColor = System.Drawing.Color.Beige;
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(38, 38);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(151, 160);
            this.playerListBox.TabIndex = 1;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.BackColor = System.Drawing.Color.Black;
            this.inventoryListBox.ForeColor = System.Drawing.Color.Beige;
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(38, 239);
            this.inventoryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(151, 199);
            this.inventoryListBox.TabIndex = 3;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // inventoryDescLabel
            // 
            this.inventoryDescLabel.AutoSize = true;
            this.inventoryDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.inventoryDescLabel.Location = new System.Drawing.Point(70, 214);
            this.inventoryDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryDescLabel.Name = "inventoryDescLabel";
            this.inventoryDescLabel.Size = new System.Drawing.Size(84, 22);
            this.inventoryDescLabel.TabIndex = 2;
            this.inventoryDescLabel.Text = "Inventory";
            this.inventoryDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventListBox
            // 
            this.eventListBox.BackColor = System.Drawing.Color.Black;
            this.eventListBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListBox.ForeColor = System.Drawing.Color.Beige;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 18;
            this.eventListBox.Location = new System.Drawing.Point(228, 375);
            this.eventListBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(301, 40);
            this.eventListBox.TabIndex = 4;
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescLabel.ForeColor = System.Drawing.Color.Red;
            this.roomDescLabel.Location = new System.Drawing.Point(344, 8);
            this.roomDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(70, 28);
            this.roomDescLabel.TabIndex = 6;
            this.roomDescLabel.Text = "Room";
            this.roomDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.treasureChestListBox);
            this.groupBox1.Controls.Add(this.enemyListBox);
            this.groupBox1.Controls.Add(this.enemyDescLabel);
            this.groupBox1.Controls.Add(this.treasureBoxDescLabel);
            this.groupBox1.Location = new System.Drawing.Point(228, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // treasureChestListBox
            // 
            this.treasureChestListBox.BackColor = System.Drawing.Color.Black;
            this.treasureChestListBox.ForeColor = System.Drawing.Color.Beige;
            this.treasureChestListBox.FormattingEnabled = true;
            this.treasureChestListBox.Location = new System.Drawing.Point(154, 31);
            this.treasureChestListBox.Margin = new System.Windows.Forms.Padding(2);
            this.treasureChestListBox.Name = "treasureChestListBox";
            this.treasureChestListBox.Size = new System.Drawing.Size(142, 121);
            this.treasureChestListBox.TabIndex = 10;
            this.treasureChestListBox.SelectedIndexChanged += new System.EventHandler(this.treasureChestListBox_SelectedIndexChanged);
            // 
            // enemyListBox
            // 
            this.enemyListBox.BackColor = System.Drawing.Color.Black;
            this.enemyListBox.ForeColor = System.Drawing.Color.Beige;
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.Location = new System.Drawing.Point(4, 31);
            this.enemyListBox.Margin = new System.Windows.Forms.Padding(2);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(142, 121);
            this.enemyListBox.TabIndex = 9;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.enemyListBox_SelectedIndexChanged);
            // 
            // enemyDescLabel
            // 
            this.enemyDescLabel.AutoSize = true;
            this.enemyDescLabel.BackColor = System.Drawing.Color.DarkRed;
            this.enemyDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyDescLabel.ForeColor = System.Drawing.Color.Beige;
            this.enemyDescLabel.Location = new System.Drawing.Point(47, 12);
            this.enemyDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyDescLabel.Name = "enemyDescLabel";
            this.enemyDescLabel.Size = new System.Drawing.Size(56, 17);
            this.enemyDescLabel.TabIndex = 8;
            this.enemyDescLabel.Text = "Enemies";
            this.enemyDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treasureBoxDescLabel
            // 
            this.treasureBoxDescLabel.AutoSize = true;
            this.treasureBoxDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureBoxDescLabel.ForeColor = System.Drawing.Color.Beige;
            this.treasureBoxDescLabel.Location = new System.Drawing.Point(184, 12);
            this.treasureBoxDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treasureBoxDescLabel.Name = "treasureBoxDescLabel";
            this.treasureBoxDescLabel.Size = new System.Drawing.Size(95, 17);
            this.treasureBoxDescLabel.TabIndex = 12;
            this.treasureBoxDescLabel.Text = "Treasure Chest";
            this.treasureBoxDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // southButton
            // 
            this.southButton.BackColor = System.Drawing.Color.DarkRed;
            this.southButton.ForeColor = System.Drawing.Color.Beige;
            this.southButton.Location = new System.Drawing.Point(465, 280);
            this.southButton.Margin = new System.Windows.Forms.Padding(2);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(63, 37);
            this.southButton.TabIndex = 20;
            this.southButton.Text = "Move South";
            this.southButton.UseVisualStyleBackColor = false;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.BackColor = System.Drawing.Color.DarkRed;
            this.northButton.ForeColor = System.Drawing.Color.Beige;
            this.northButton.Location = new System.Drawing.Point(465, 239);
            this.northButton.Margin = new System.Windows.Forms.Padding(2);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(63, 37);
            this.northButton.TabIndex = 18;
            this.northButton.Text = "Move North";
            this.northButton.UseVisualStyleBackColor = false;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.Color.DarkRed;
            this.fightButton.ForeColor = System.Drawing.Color.Beige;
            this.fightButton.Location = new System.Drawing.Point(398, 239);
            this.fightButton.Margin = new System.Windows.Forms.Padding(2);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(63, 78);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight Enemy";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.BackColor = System.Drawing.Color.Black;
            this.infoListBox.ForeColor = System.Drawing.Color.Beige;
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.Location = new System.Drawing.Point(228, 239);
            this.infoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(142, 121);
            this.infoListBox.TabIndex = 13;
            // 
            // infoDescLabel
            // 
            this.infoDescLabel.AutoSize = true;
            this.infoDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.infoDescLabel.Location = new System.Drawing.Point(255, 214);
            this.infoDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoDescLabel.Name = "infoDescLabel";
            this.infoDescLabel.Size = new System.Drawing.Size(101, 22);
            this.infoDescLabel.TabIndex = 22;
            this.infoDescLabel.Text = "Information";
            this.infoDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.eventDescLabel.Location = new System.Drawing.Point(386, 351);
            this.eventDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(60, 22);
            this.eventDescLabel.TabIndex = 23;
            this.eventDescLabel.Text = "Events";
            this.eventDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectsDataSet
            // 
            this.objectsDataSet.DataSetName = "ObjectsDataSet";
            this.objectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // castsBindingSource
            // 
            this.castsBindingSource.DataMember = "Casts";
            this.castsBindingSource.DataSource = this.objectsDataSet;
            // 
            // castsTableAdapter
            // 
            this.castsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CastsTableAdapter = this.castsTableAdapter;
            this.tableAdapterManager.EnemiesTableAdapter = null;
            this.tableAdapterManager.LootTableAdapter = null;
            this.tableAdapterManager.PotionsTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.TrinketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeaponsTableAdapter = null;
            // 
            // enemiesBindingSource
            // 
            this.enemiesBindingSource.DataMember = "Enemies";
            this.enemiesBindingSource.DataSource = this.objectsDataSet;
            // 
            // enemiesTableAdapter
            // 
            this.enemiesTableAdapter.ClearBeforeFill = true;
            // 
            // lootBindingSource
            // 
            this.lootBindingSource.DataMember = "Loot";
            this.lootBindingSource.DataSource = this.objectsDataSet;
            // 
            // lootTableAdapter
            // 
            this.lootTableAdapter.ClearBeforeFill = true;
            // 
            // potionsBindingSource
            // 
            this.potionsBindingSource.DataMember = "Potions";
            this.potionsBindingSource.DataSource = this.objectsDataSet;
            // 
            // potionsTableAdapter
            // 
            this.potionsTableAdapter.ClearBeforeFill = true;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.objectsDataSet;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.objectsDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // trinketsBindingSource
            // 
            this.trinketsBindingSource.DataMember = "Trinkets";
            this.trinketsBindingSource.DataSource = this.objectsDataSet;
            // 
            // trinketsTableAdapter
            // 
            this.trinketsTableAdapter.ClearBeforeFill = true;
            // 
            // weaponsBindingSource
            // 
            this.weaponsBindingSource.DataMember = "Weapons";
            this.weaponsBindingSource.DataSource = this.objectsDataSet;
            // 
            // weaponsTableAdapter
            // 
            this.weaponsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(548, 467);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Broadmantle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).EndInit();
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
        private ObjectsDataSet objectsDataSet;
        private System.Windows.Forms.BindingSource castsBindingSource;
        private ObjectsDataSetTableAdapters.CastsTableAdapter castsTableAdapter;
        private ObjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource enemiesBindingSource;
        private ObjectsDataSetTableAdapters.EnemiesTableAdapter enemiesTableAdapter;
        private System.Windows.Forms.BindingSource lootBindingSource;
        private ObjectsDataSetTableAdapters.LootTableAdapter lootTableAdapter;
        private System.Windows.Forms.BindingSource potionsBindingSource;
        private ObjectsDataSetTableAdapters.PotionsTableAdapter potionsTableAdapter;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private ObjectsDataSetTableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private ObjectsDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource trinketsBindingSource;
        private ObjectsDataSetTableAdapters.TrinketsTableAdapter trinketsTableAdapter;
        private System.Windows.Forms.BindingSource weaponsBindingSource;
        private ObjectsDataSetTableAdapters.WeaponsTableAdapter weaponsTableAdapter;
    }
}

