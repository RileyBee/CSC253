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

namespace DungeonCrawl_NoyesPrivette_3
{
    public partial class CreatePlayerForm : Form
    {
        // lists to hold cast and race attributes from files
        private List<string[]> castsList;
        private List<string[]> racesList;

        public CreatePlayerForm()
        {
            InitializeComponent();

            // creating a mainform object to retrieve casts and races lists from it
            MainForm mainForm1 = new MainForm();
            castsList = mainForm1.castsList;
            racesList = mainForm1.racesList;
        }

        // if password is valid returns true
        private bool passVal (string password)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password length
            if (password.Length < 3 || password.Length > 10)
            {
                return false;
            }
            else
            {
                // for every char in password check to see if it meets each condition. if so that flag is true
                foreach (char ch in password)
                {
                    if (Char.IsUpper(ch))
                    {
                        upper = true;
                    }

                    if (Char.IsLower(ch))
                    {
                        lower = true;
                    }

                    if (!Char.IsLetterOrDigit(ch))
                    {
                        special = true;
                    }
                }

                // if all conditions are met then password is valid and method returns true
                if (upper == true && lower == true && special == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            // Password input and validation.
            if (passVal(passTextBox.Text))
            {
                string password = passTextBox.Text;

                // capturing user entered name to variable so it can be written to two different files
                string playName = nameTextBox.Text;

                // first file to hold list of all saved players
                StreamWriter playerList;
                // appends name to list
                playerList = File.AppendText("../../Text Files/playerList.txt");
                playerList.WriteLine(playName);
                playerList.Close();

                // Create streamwrite object for player file.
                StreamWriter playerCreationFile;

                /* 
                 *  Write player attributes and inform player  
                 *  character creation was successful.
                 */
                playerCreationFile = File.CreateText("../../Text Files/player" + playName + ".txt");
                playerCreationFile.WriteLine(playName);
                playerCreationFile.WriteLine(descTextBox.Text);
                playerCreationFile.WriteLine(password);
                playerCreationFile.WriteLine(castComboBox.SelectedItem);
                playerCreationFile.WriteLine(raceComboBox.SelectedItem);

                MessageBox.Show("You have created a new character!");

                //Close player file.
                playerCreationFile.Close();
                this.Close(); // closing form to return to intro form
            }
            else
            {
                MessageBox.Show("Please make sure password meets criteria");
            }
        }

        private void castComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displaying each cast attribute when user changes selection
            // uses the information originally brought over from a main form instance
            castListBox.Items.Clear();
            
            castListBox.Items.Add("Name: " + castsList[castComboBox.SelectedIndex][0]);
            castListBox.Items.Add("Description: " + castsList[castComboBox.SelectedIndex][1]);
            castListBox.Items.Add("Attack: " + castsList[castComboBox.SelectedIndex][2]);
            castListBox.Items.Add("Defense: " + castsList[castComboBox.SelectedIndex][3]);
            castListBox.Items.Add("Dexterity: " + castsList[castComboBox.SelectedIndex][4]);
            castListBox.Items.Add("Intelligence: " + castsList[castComboBox.SelectedIndex][5]);
            castListBox.Items.Add("Wisdom: " + castsList[castComboBox.SelectedIndex][6]);
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displaying each race attribute when user changes selection
            // uses the information originally brought over from a main form instance
            raceListBox.Items.Clear();

            raceListBox.Items.Add("Name: " + racesList[raceComboBox.SelectedIndex][0]);
            raceListBox.Items.Add("Description: " + racesList[raceComboBox.SelectedIndex][1]);
            raceListBox.Items.Add("Attack: " + racesList[raceComboBox.SelectedIndex][2]);
            raceListBox.Items.Add("Defense: " + racesList[raceComboBox.SelectedIndex][3]);
            raceListBox.Items.Add("Dexterity: " + racesList[raceComboBox.SelectedIndex][4]);
            raceListBox.Items.Add("Intelligence: " + racesList[raceComboBox.SelectedIndex][5]);
            raceListBox.Items.Add("Wisdom: " + racesList[raceComboBox.SelectedIndex][6]);
        }
    }
}