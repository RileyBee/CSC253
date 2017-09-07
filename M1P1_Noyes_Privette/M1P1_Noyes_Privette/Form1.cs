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
        public Form1()
        {
            InitializeComponent();
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
    }
    }

