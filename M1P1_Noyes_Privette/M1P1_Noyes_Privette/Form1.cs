using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 9/10/2017
* CSC 253
* Chris Noyes & Stephen Privette
* Dungeon Crawler - Allows players to navigate dungeons via 
* directional buttons, view inventory, mobs, and current room.
*/
namespace M1P1_Noyes_Privette
{
    public partial class Form1 : Form
    {
        // field to allow current room to be selected by multiple buttons
        int currentRoom = 0;

        public Form1()
        {
            InitializeComponent();

            // initializing label with first room
            roomStatusLabel.Text = RoomFinder(0);
        }                                
                     
        // method to return correct room to different the North and South button click events
        private string RoomFinder(int index)
        {
            // Create and initializle weapons array.
            const int SIZE = 5;
            string[] rooms = new string[SIZE] {"Crypt", "Armory", "Forge", "Prison", "Laboratory"};

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
            foreach(string tmp in weapons )
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
            foreach(string tmp in potions)
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
            List <string> mobs = new List <string> {"Orcs", "Trolls", "Drow", "Undead", "Vermin"};

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
    }
    }

