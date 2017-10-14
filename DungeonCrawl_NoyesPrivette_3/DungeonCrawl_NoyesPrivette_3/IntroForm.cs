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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            loadPlayers();
        }

        // loads saved players from file into list box
        private void loadPlayers()
        {
            // streamreader object to read file
            StreamReader playersInFile;
            playersInFile = File.OpenText("../../Text Files/playerList.txt");

            // list to hold each player in its own element
            List<string> players = new List<string>();

            while (playersInFile.EndOfStream == false)
            {
                // each line is a player 
                players.Add(playersInFile.ReadLine());
            }

            playerComboBox.DataSource = players;
            playersInFile.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createPlayerForm1 = new CreatePlayerForm(); // displays new player creation form
            createPlayerForm1.ShowDialog();

            loadPlayers(); // after form closes this refreshes players in combo box
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            StreamReader startingPlayerInFile; // loads selected player from file
            startingPlayerInFile = File.OpenText("../../Text Files/player" + playerComboBox.SelectedItem + ".txt");

            List<string> startingPlayerList = new List<string>(); // list to hold player attributes

            while (startingPlayerInFile.EndOfStream == false)
            {
                startingPlayerList.Add(startingPlayerInFile.ReadLine()); //adds each attribute in file to list
            }

            if (passwordTextBox.Text == startingPlayerList[2]) // checking password
            {
                MainForm mainForm2 = new MainForm(); // creating main form
                mainForm2.startingPlayerName = startingPlayerList[0]; // adding starting player to main form field before displaying form
                mainForm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again."); // if password does not match main form does not load
            }

            startingPlayerInFile.Close(); // closing streamreader
        }
    }
}
