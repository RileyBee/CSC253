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

/*
* 9/10/2017
* CSC 253
* Chris Noyes & Stephen Privette
* Dungeon Crawler - Allows players to navigate dungeons via 
* directional buttons, view inventory, mobs, and current room.
*/

namespace DungeonCrawl_NoyesPrivette
{
    // structure to hold Player Build
    struct PlayerInfo
    {
        public string name;
        public string password;
        public enum Classes {Thief,Mage,Warrior,Cleric,Barbarian}
        public enum Race {Human,Elf,Orc,Goblin,Dwarf}
    }

    public partial class Form1 : Form
    {
        // field to allow current room to be selected by multiple buttons
        int currentRoom = 0;

        public Form1()
        {
            InitializeComponent();

            // initializing label with first room
            roomStatusLabel.Text = RoomFinder(0);

            // initializing list box with list of saved players
            LoadPlayers();
        }

        // loads saved players from file into list box
        private void LoadPlayers()
        {
            // streamreader object to read file
            StreamReader playersInFile;
            playersInFile = File.OpenText("playerList.txt");

            // list to hold each player in its own element
            List<string> players = new List<string>();

            while (playersInFile.EndOfStream == false)
            {
                // each line is a player 
                players.Add(playersInFile.ReadLine());
            }

            playersListBox.DataSource = players;
            playersInFile.Close();
        }

        // method to return correct room to different the North and South button click events
        private string RoomFinder(int index)
        {
            // Create and initializle weapons array.
            const int SIZE = 5;
            string[] rooms = new string[SIZE] { "Crypt", "Armory", "Forge", "Prison", "Laboratory" };

            // using the parameter passed in to return that element from the rooms array
            if (index == 0)
            {
                return rooms[0];
            }
            else if (index == 1)
            {
                return rooms[1];
            }
            else if (index == 2)
            {
                return rooms[2];
            }
            else if (index == 3)
            {
                return rooms[3];
            }
            else
            {
                return rooms[4];
            }
        }

        private void weaponsButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Create and initializle weapons array.
            const int SIZE = 4;
            string[] weapons = new string[SIZE];
            weapons[0] = "Sword";
            weapons[1] = "Axe";
            weapons[2] = "Spear";
            weapons[3] = "Club";

            //Sort algorithm
            Array.Sort(weapons);
            foreach (string tmp in weapons)
            {
                displayListBox.Items.Add(tmp);
            }
        }

        private void potionsButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Create and initialize potions array.
            const int SIZE = 2;
            string[] potions = new string[SIZE];
            potions[0] = "Mana";
            potions[1] = "Health";

            // Add to ListBox
            foreach (string tmp in potions)
            {
                displayListBox.Items.Add(tmp);
            }
        }

        private void treasureButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Create and initialize treasure array.
            const int SIZE = 3;
            string[] treasure = new string[SIZE];
            treasure[0] = "Gold";
            treasure[1] = "Rubies";
            treasure[2] = "Emeralds";

            // Add to ListBox
            foreach (string tmp in treasure)
            {
                displayListBox.Items.Add(tmp);
            }
        }

        private void mobsButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Create and initialize mob list
            List<string> mobs = new List<string> { "Orcs", "Trolls", "Drow", "Undead", "Vermin" };

            // Add to ListBox
            foreach (string tmp in mobs)
            {
                displayListBox.Items.Add(tmp);
            }
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            // Clear ListBox
            displayListBox.Items.Clear();

            // Create and initialize mob list
            List<string> items = new List<string> { "Key", "Lantern", "Compass", "Map" };

            // Add to ListBox
            foreach (string tmp in items)
            {
                displayListBox.Items.Add(tmp);
            }
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            // add one to the current room field which will in turn be passed to the RoomFinder method
            currentRoom += 1;
            roomStatusLabel.Text = RoomFinder(currentRoom);

            // disabling button if user is in last room
            if (currentRoom == 4)
            {
                northButton.Enabled = false;
            }
            else
            {
                southButton.Enabled = true;
            }
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            // subtract one to the current room field which will in turn be passed to the RoomFinder method
            currentRoom -= 1;
            roomStatusLabel.Text = RoomFinder(currentRoom);

            // disabling button if user is in first room
            if (currentRoom == 0)
            {
                southButton.Enabled = false;
            }
            else
            {
                northButton.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closing program
            this.Close();
        }

        private void playerFormButton_Click(object sender, EventArgs e)
        {
            // opens player creation form
            Player Player = new Player();
            Player.Show();
        }

        private void loadPlayerButton_Click(object sender, EventArgs e)
        {
            // streamreader for individual player file
            StreamReader playerInFile;
            // whatever player is highlighted in text box is the name of file for that player
            playerInFile = File.OpenText(playersListBox.SelectedItem + ".txt");

            // creating player info struct instance
            PlayerInfo currentPlayer = new PlayerInfo();
            // first line of individual player file is name. second is password
            currentPlayer.name = playerInFile.ReadLine();
            currentPlayer.password = playerInFile.ReadLine();

            // third line is class. fourth is race. capturing them in variables to properly execute switch for class and race enums
            string currentPlayerClasses = playerInFile.ReadLine();
            string currentPlayerRaces = playerInFile.ReadLine();

            // 0 through 4 specifies the class type
            PlayerInfo.Classes currentPlayerClass;
            if (currentPlayerClasses == "0")
            {
                currentPlayerClass = PlayerInfo.Classes.Thief;
            }
            
            else if (currentPlayerClasses == "1")
            {
                currentPlayerClass = PlayerInfo.Classes.Mage;
            }

            else if (currentPlayerClasses == "2")
            {
                currentPlayerClass = PlayerInfo.Classes.Warrior;
            }

            else if (currentPlayerClasses == "3")
            {
                currentPlayerClass = PlayerInfo.Classes.Cleric;
            }

            else
            {
                currentPlayerClass = PlayerInfo.Classes.Barbarian;      
            }

            // 0 through 4 specifies the race type
            PlayerInfo.Race currentPlayerRace;
            if (currentPlayerRaces == "0")
            {
                currentPlayerRace = PlayerInfo.Race.Human;
            }

            else if (currentPlayerRaces == "1")
            {
                currentPlayerRace = PlayerInfo.Race.Elf;
            }

            else if (currentPlayerRaces == "2")
            {
                currentPlayerRace = PlayerInfo.Race.Orc;
            }

            else if (currentPlayerRaces == "3")
            {
                currentPlayerRace = PlayerInfo.Race.Goblin;
            }

            else
            {
                currentPlayerRace = PlayerInfo.Race.Dwarf;
            }

            // display name of player
            playerNameLabel.Text = currentPlayer.name;

            // creating a list to add class and race to to use list for list box data source
            List<string> currentPlayerList = new List<string>();
            currentPlayerList.Add("Class: " + currentPlayerClass.ToString());
            currentPlayerList.Add("Race: " + currentPlayerRace.ToString());

            currentPlayerListBox.DataSource = currentPlayerList;
        }

        // have to have this to load list of players after creating a new player
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }
    }
}
