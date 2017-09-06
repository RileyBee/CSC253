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

        // Rooms Method
        private void Rooms(string[] strArray)
        {
            const int SIZE = 4;
            string[] rooms = new string[SIZE];
            rooms[0] = "Armory";
            rooms[1] = "Forge";
            rooms[2] = "Prison";
            rooms[3] = "Labratory";                    
                        
        }

        // Weapons Method
        private void Weapons(string[] strArray)
        {
            const int SIZE = 4;
            string[] weapons = new string[SIZE];
            weapons[0] = "Axe";
            weapons[1] = "Sword";
            weapons[2] = "Club";
            weapons[3] = "Spear";
            
        }

        // Potions Method
        private void Potions(string[] strArray)
        {
            const int SIZE = 2;
            string[] potions = new string[SIZE];
            potions[0] = "Mana";
            potions[1] = "Health";
            

        }

        // Treasure Method
        private void Treasure(string[] strArray)
        {
            const int SIZE = 3;
            string[] treasure = new string[SIZE];
            treasure[0] = "Gold";
            treasure[1] = "Rubies";
            treasure[2] = "Emeralds";
            

        }







    }
}
