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

        // validates password
        private string PassVal(string password)
        {
            return password;
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

            // second file to hold attributes of player
            StreamWriter playerCreationFile;
            // name of file is name of player
            playerCreationFile = File.CreateText(playName + ".txt");

            // each attribute is on its own line in the file
            playerCreationFile.WriteLine(playName);
            playerCreationFile.WriteLine(PassVal(passTextBox.Text));
            playerCreationFile.WriteLine(classComboBox.SelectedIndex.ToString());
            playerCreationFile.WriteLine(raceComboBox.SelectedIndex.ToString());

            MessageBox.Show("You have created a new character!");

            playerCreationFile.Close();

            this.Close();
        }
    }
}
