using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace DungeonCrawl_NoyesPrivette_3
{
    public partial class MainForm : Form
    {
        string connectionString;
        
        SqlConnection connection;
        

        // fields to hold lists of a arrays of each objects attributes. originally read from file.
        // this info will be used to create objects from each class except for casts and races,
        // those two lists will be used to fill in player objects attributes.
        private List<string[]> _castsList;
        private List<string[]> _enemiesList;
        private List<string[]> _trinketsList;
        private List<string[]> _lootList;
        private List<string[]> _potionsList;
        private List<string[]> _racesList;
        private List<string[]> _roomsList;
        private List<string[]> _weaponsList;

        // field to hold the name of active player brought over from intro form
        private string _startingPlayerName;
        

        // creating objects for player
        // objects for other classes will be created by createObject method
        // and added to appropriate list
        private Player player;

        private List<Room> roomObjectsList; //list to hold all rooms for easier manipualtion

        public MainForm()
        {
            InitializeComponent();

            
            
            
            // initializing these object attribute lists in constructor so that they may also be used
            // by create player form when it creates an instance of this form.
            // if put in form load event entire form would have to be displayed in order for them to be accessed.
            // calling method to load object attributes from file into lists of arrays
            _castsList = loadClassFile("casts"); 
            _enemiesList = loadClassFile("enemies");
            _trinketsList = loadClassFile("trinkets");
            _lootList = loadClassFile("loot");
            _potionsList = loadClassFile("potions");
            _racesList = loadClassFile("races");
            _roomsList = loadClassFile("rooms");
            _weaponsList = loadClassFile("weapons");

            _startingPlayerName = "";
        }

        private void InitialData()
        {
            connection = new SqlConnection(connectionString);
        }
                
        
        private void MainForm_Load(object sender, EventArgs e)
        {
                       
            // initializing objects and displaying things here in load event so they will not
            // load when instance of this form is used elsewhere

            player = new Player();
            // creates active player object straight from file as oppossed to using a list intermediary
            createPlayerFromFile();
            //displays states of inventory and player in list boxes
            displayPlayer();
            displayInventory();

            // initializing all rooms
            roomObjectsList = new List<Room>();

            roomObjectsList.Add((Room)createObject("Room", "Armory"));
            roomObjectsList[0].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[0].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[0].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[0].addTreasureToChest((Trinket)createObject("Trinket", "Map"));
            roomObjectsList[0].addTreasureToChest((Weapon)createObject("Weapon", "Spear"));

            roomObjectsList.Add((Room)createObject("Room", "Crypt"));
            roomObjectsList[1].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[1].addEnemyToRoom((Enemy)createObject("Enemy", "Hydra"));
            roomObjectsList[1].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[1].addTreasureToChest((Potion)createObject("Potion", "Magic"));
            roomObjectsList[1].addTreasureToChest((Trinket)createObject("Trinket", "Compass"));
            roomObjectsList[1].addTreasureToChest((Weapon)createObject("Weapon", "Axe"));
            roomObjectsList[1].addTreasureToChest((Loot)createObject("Loot", "Ruby"));

            roomObjectsList.Add((Room)createObject("Room", "Forge"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Kobold"));
            roomObjectsList[2].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[2].addTreasureToChest((Trinket)createObject("Trinket", "Lantern"));
            roomObjectsList[2].addTreasureToChest((Weapon)createObject("Weapon", "Club"));
            roomObjectsList[2].addTreasureToChest((Loot)createObject("Loot", "Gold"));

            roomObjectsList.Add((Room)createObject("Room", "Laboratory"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Hydra"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Kobold"));
            roomObjectsList[3].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[3].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[3].addTreasureToChest((Potion)createObject("Potion", "Magic"));
            roomObjectsList[3].addTreasureToChest((Trinket)createObject("Trinket", "Key"));
            roomObjectsList[3].addTreasureToChest((Weapon)createObject("Weapon", "Sword"));
            roomObjectsList[3].addTreasureToChest((Loot)createObject("Loot", "Ruby"));
            roomObjectsList[3].addTreasureToChest((Loot)createObject("Loot", "Gold"));
            roomObjectsList[3].addTreasureToChest((Loot)createObject("Loot", "Gold"));

            roomObjectsList.Add((Room)createObject("Room", "Prison"));
            roomObjectsList[4].addEnemyToRoom((Enemy)createObject("Enemy", "Lich"));
            roomObjectsList[4].addTreasureToChest((Loot)createObject("Loot", "Trophy"));

            displayRoom(0); // displays armory to start game
        }

        // so starting player field can be set from intro form
        public string startingPlayerName
        {
            set { _startingPlayerName = value; }
        }

        // so create player form can retrieve info
        public List<string[]> castsList
        {
            get { return _castsList; }
        }

        // so create player form can retrieve info
        public List<string[]> racesList
        {
            get { return _racesList; }
        }


        // creates active player object from file
        private void createPlayerFromFile()
        {
            // creates stream reader from starting player name field
            StreamReader inFile = File.OpenText("../../Text Files/player" + _startingPlayerName + ".txt");
            List<string> playerAttributesList = new List<string>();

            // adds each line of player file to list
            while (inFile.EndOfStream == false)
            {
                playerAttributesList.Add(inFile.ReadLine());
            }
            // adding each attribute from file to corresponding field in object
            player.name = playerAttributesList[0];
            player.description = playerAttributesList[1];
            player.cast = playerAttributesList[3];
            player.race = playerAttributesList[4];

            inFile.Close(); // closing file

            // each array in list is attributes for a certain object
            foreach (string[] cast in _castsList)
            {
                // if the cast type in player matches the name of the cast in array
                if (cast[0] == player.cast)
                {
                    // adds attribues to player
                    player.attack = int.Parse(cast[2]);
                    player.defense = int.Parse(cast[3]);
                    player.dexterity = int.Parse(cast[4]);
                    player.intelligence = int.Parse(cast[5]);
                    player.wisdom = int.Parse(cast[6]);
                    break; // might as well break so doesn't iterate unneccessarily
                }
            }

            // each array in list is attributes for a certain object
            foreach (string[] race in _racesList)
            {
                // if the race type in player matches the name of the race in array
                if (race[0] == player.race)
                {
                    // adds attributes to player
                    player.attack += int.Parse(race[2]);
                    player.defense += int.Parse(race[3]);
                    player.dexterity += int.Parse(race[4]);
                    player.intelligence += int.Parse(race[5]);
                    player.wisdom += int.Parse(race[6]);
                    break; // might as well break so doesn't iterate unneccessarily
                }
            }
        }


        // displays active player attributes to label and player list box
        private void displayPlayer()
        {
            playerDescLabel.Text = player.name;

            playerListBox.Items.Clear();

            playerListBox.Items.Add("Description: " + player.description);
            playerListBox.Items.Add("Class: " + player.cast);
            playerListBox.Items.Add("Race: " + player.race);
            playerListBox.Items.Add("Health: " + player.health);
            playerListBox.Items.Add("Mana: " + player.mana);
            playerListBox.Items.Add("Attack: " + player.attack.ToString());
            playerListBox.Items.Add("Defense: " + player.defense);
            playerListBox.Items.Add("Dexterity: " + player.dexterity);
            playerListBox.Items.Add("Intelligence: " + player.intelligence);
            playerListBox.Items.Add("Wisdom: " + player.wisdom);
        }


        // displays player inventory to inventory list box
        private void displayInventory()
        {
            inventoryListBox.Items.Clear();

            // if inventory empty
            if (player.inventory.Count < 1)
            {
                inventoryListBox.Items.Add("You currently have no items :(");
            }
            else
            {
                // for each item in inventory list add it to inventory list box
                foreach (Thing i in player.inventory)
                {
                    inventoryListBox.Items.Add(i.name);
                }
            }
        }

        
        // takes filename argument and returns a list of arrays.
        // this will take all info for a certain class file and
        // create a list containing arrays of each objects attributes
        private List<string []> loadClassFile(string fileName)
        {
            // using paramter to open correct file
            StreamReader inFile = File.OpenText("../../Text Files/" + fileName + ".txt");
            string line; // needed to capture each line of file
            List<string []> instanceStats = new List<string []>(); // initializing list of arrays
            char[] delim = { ',' }; // delimiter
            // takes each line and splits it into an array which is then added to the list
            while (inFile.EndOfStream == false)
            {
                line = inFile.ReadLine();
                string [] stats = line.Split(delim);
                instanceStats.Add(stats);
            }
            inFile.Close(); // closing reader
            return instanceStats; // returning list of arrays
        }


        // takes a room object parameter and displays its contents
        private void displayRoom(int index)
        {
            // changing current room to the room passed in
            foreach (Room i in roomObjectsList)
            {
                i.currentRoom = false;
            }

            roomObjectsList[index].currentRoom = true;

            roomDescLabel.Text = roomObjectsList[index].name; // room header
            enemyListBox.Items.Clear(); 
            treasureChestListBox.Items.Clear();
            // for every enemy in the rooms enemylist add it to list box
            foreach(Enemy i in roomObjectsList[index].enemiesList)
            {
                enemyListBox.Items.Add(i.name);
            }
            foreach (Thing i in roomObjectsList[index].treasureChestList)
            {
                treasureChestListBox.Items.Add(i.name);
            }
        }



        // creates object instances
        private Thing createObject(string className, string objectName)
        {
            // the class name determines which object to create and which attributes to define
            switch (className)
            {
                case "Enemy":
                    Enemy enemy1 = new Enemy();
                    // for each arrray in the enemieslist field
                    foreach (string[] i in _enemiesList)
                    {
                        // if the name passed in and the .name of the array match we have found our object
                        if (objectName == i[0])
                        {
                            enemy1.name = i[0];
                            enemy1.description = i[1];
                            enemy1.attack = int.Parse(i[2]);
                            enemy1.defense = int.Parse(i[3]);
                            enemy1.dexterity = int.Parse(i[4]);
                            enemy1.intelligence = int.Parse(i[5]);
                            enemy1.wisdom = int.Parse(i[6]);
                        }
                    }
                    // returns the correct new object
                    return enemy1;

                case "Loot":
                    Loot loot1 = new Loot();
                    foreach (string[] i in _lootList)
                    {
                        if (objectName == i[0])
                        {
                            loot1.name = i[0];
                            loot1.description = i[1];
                        }
                    }
                    return loot1;

                case "Potion":
                    Potion potion1 = new Potion();

                    foreach (string[] i in _potionsList)
                    {
                        if (objectName == i[0])
                        {
                            potion1.name = i[0];
                            potion1.description = i[1];
                            potion1.type = i[2];
                        }
                    }
                    return potion1;


                case "Room":
                    Room room1 = new Room();
                    foreach (string[] i in _roomsList)
                    {
                        if (objectName == i[0])
                        {
                            room1.name = i[0];
                            room1.description = i[1];
                        }
                    }
                    return room1;

                case "Trinket":
                    Trinket trinket1 = new Trinket();
                    foreach (string[] i in _trinketsList)
                    {
                        if (objectName == i[0])
                        {
                            trinket1.name = i[0];
                            trinket1.description = i[1];
                        }
                    }
                    return trinket1;

                case "Weapon":
                    Weapon weapon1 = new Weapon();
                    foreach (string[] i in _weaponsList)
                    {
                        if (objectName == i[0])
                        {
                            weapon1.name = i[0];
                            weapon1.description = i[1];
                            weapon1.attack = int.Parse(i[2]);
                        }
                    }
                    return weapon1;

                // must have a default case for switch so makes a blank Thing and returns it
                // will never be used
                default:
                    Thing thing1 = new Thing();
                    return thing1;
            }
        }



        // advances player north to the next room
        private void northButton_Click(object sender, EventArgs e)
        {
            if(roomObjectsList[4].currentRoom == true)
            {
                MessageBox.Show("You have reached the end of the dungeon.");
            }
            else
            {
                int index = 0;
                bool flag = false;
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom == true)
                    {
                        index = roomObjectsList.IndexOf(i) + 1;
                        if (i.enemiesList.Count < 1)
                        {
                            flag = true;
                        }
                        else
                        {
                            MessageBox.Show("You must first defeat the enemies in this room.");
                        }
                    }
                }
                if (flag == true)
                {
                    displayRoom(index);
                }
            }
        }

        // moves player south to previous room
        private void southButton_Click(object sender, EventArgs e)
        {
            if (roomObjectsList[0].currentRoom == true)
            {
                MessageBox.Show("There are no rooms south of this one.");
            }
            else
            {
                int index = 0;
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom == true)
                    {
                        index = roomObjectsList.IndexOf(i) - 1;
                    }
                }
                displayRoom(index);
            }
        }

        // gets current state of whatever object's name that is passed in
        private void getObjectInfo(string item)
        {
            infoListBox.Items.Clear();

            foreach(Room room in roomObjectsList)
            {
                // finding current room
                if(room.currentRoom == true)
                {
                    // first searching enemies in current room
                    foreach(Enemy enemy in room.enemiesList)
                    {
                        // if the name passed in matches the enemy in the current room
                        if(item == enemy.name)
                        {
                            // adds enemy info to list box 
                            infoListBox.Items.Add(enemy.name);
                            infoListBox.Items.Add(enemy.description);
                            break;
                        }
                    }

                    // next searching treasure chest of current room
                    foreach(Thing thing in room.treasureChestList)
                    {
                        // if the name passed in matches the item in the current room's chest
                        if(item == thing.name)
                        {
                            // adds info
                            infoListBox.Items.Add(thing.name);
                            infoListBox.Items.Add(thing.description);
                            break;
                        }
                    }
                }
            }

            // lastly searching player's inventory
            foreach(Thing thing in player.inventory)
            {
                // if name passed in matches item in inventory
                if(item == thing.name)
                {
                    // adds info to box
                    infoListBox.Items.Add(thing.name);
                    infoListBox.Items.Add(thing.description);
                    break;
                }
            }
        }

        private void enemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // passing the selected item to get info
            if(enemyListBox.SelectedItem != null)
            {
                getObjectInfo(enemyListBox.SelectedItem.ToString());
            }
        }

        private void treasureChestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // passing the selected item to get info
            if (treasureChestListBox.SelectedItem != null)
            {
                getObjectInfo(treasureChestListBox.SelectedItem.ToString());
            }   
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // passing the selected item to get info
            if (inventoryListBox.SelectedItem != null)
            {
                getObjectInfo(inventoryListBox.SelectedItem.ToString());
            }
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            // making sure an enemy was selected
            if(enemyListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected an enemy to fight.");
            }
            else
            {
                int roomIndex = 0;
                int enemyIndex = 0;

                // finding current room and recording the index where it exists in roomObjectsList to roomIndex
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom)
                    {
                        roomIndex = roomObjectsList.IndexOf(i);
                        // finding the selected enemy to fight in enemyListBox and
                        // recording the index of where it exists in the current room's
                        // enemiesList to enemyIndex
                        foreach (Enemy enem in i.enemiesList)
                        {
                            if (enemyListBox.SelectedItem.ToString() == enem.name)
                            {
                                enemyIndex = i.enemiesList.IndexOf(enem);
                            }
                        }
                    }
                }

                // creating new battle object and using roomIndex and enemyIndex to pass correct enemy
                Battle battle1 = new Battle(player, roomObjectsList[roomIndex].enemiesList[enemyIndex]);
                BattleForm battleForm1 = new BattleForm();

                // passing just created battle object to just created battle form's currentBattle field
                battleForm1.currentBattle = battle1;
                battleForm1.ShowDialog(); // showing battle field

                // upon conclusion of battle updating stats everywhere                
                if (roomObjectsList[roomIndex].enemiesList[enemyIndex].health < 1)
                {
                    roomObjectsList[roomIndex].removeEnemyFromRoom(roomObjectsList[roomIndex].enemiesList[enemyIndex]);   
                }

                if (roomObjectsList[roomIndex].enemiesList.Count < 1)
                {
                    while(roomObjectsList[roomIndex].treasureChestList.Count > 0)
                    {
                        player.pickUpItem(roomObjectsList[roomIndex].treasureChestList[0]);
                        roomObjectsList[roomIndex].removeTreasureFromChest(roomObjectsList[roomIndex].treasureChestList[0]);
                    }

                    MessageBox.Show("The treasure chest in this room is yours!");
                }

                displayPlayer();
                displayInventory();
                displayRoom(roomIndex);

                infoListBox.Items.Clear(); //clearing out info box 
            }
        }
    }
}
