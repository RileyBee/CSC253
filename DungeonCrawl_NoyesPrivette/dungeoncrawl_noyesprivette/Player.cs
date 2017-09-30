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

namespace DungeonCrawl_NoyesPrivette
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }
               

        // Method to count upperCase characters.
        private int UpperCaseCount(string str)
        {
            int upperCase = 0;  // Initialize counter 

            // Count uppercase characters.
            foreach (char ch in str)
            {
                if (Char.IsUpper (ch))
                {
                    upperCase++;
                }
            }

            //Return count
            return upperCase;
        }

        // Method to count lowercase characters.
        private int LowerCaseCount(string str)
        {
            int lowerCase = 0;  // Initialize counter 

            // Count lowercase characters.
            foreach (char ch in str)
            {
                if (Char.IsUpper(ch))
                {
                    lowerCase++;
                }
            }

            //Return count
            return lowerCase;
        }

        // Method to count special characters
        private int SpecialCharCount(string str)
        {
            int specialChar = 0; // Initialize counter

            //Count special characters.
            foreach (char ch in str)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    specialChar++;
                }
            }

            //Return count
            return specialChar;
                                    
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            // capturing user entered name to variable so it can be written to two different files
            string playName = nameTextBox.Text;
                        
            // first file to hold list of all saved players
            StreamWriter playerList;
            // appends name to list
            playerList = File.AppendText("playerList.txt");
            playerList.WriteLine(playName);
            playerList.Close();                                                

            // Password Evaluation method.
            string password = passTextBox.Text;

            //Validate password.
            if (UpperCaseCount(password) >= 1 &&
                LowerCaseCount(password) >= 1 &&
                SpecialCharCount(password) >= 1)
            {

                //Write out file.
                
                // Create streamwrite object for player file.
                StreamWriter playerCreationFile;

                // Player attributes.
                playerCreationFile = File.CreateText(playName + ".txt");
                playerCreationFile.WriteLine(playName);
                playerCreationFile.WriteLine(password);
                playerCreationFile.WriteLine(classComboBox.SelectedIndex.ToString());
                playerCreationFile.WriteLine(raceComboBox.SelectedIndex.ToString());

                MessageBox.Show("You have created a new character!");

                //Close player file.
                playerCreationFile.Close();
            }
            else
            {
                MessageBox.Show("Please make sure password meets criteria");
            }
                                                          
            

            this.Close();
        }
    }
}
