using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl_NoyesPrivette_3
{
    public partial class BattleForm : Form
    {
        private Battle _currentBattle;
        private Roll roll = new Roll();
        private Weapon wpn = new Weapon();


        public BattleForm()
        {
            InitializeComponent();
        }               
                          
                        
        public Battle currentBattle
        {
            set { _currentBattle = value; }
        }



        private void BattleForm_Load(object sender, EventArgs e)
        {
            //Display starting information.
            enemyNameLabel.Text = _currentBattle.battleEnemy.name;
            enemyHealthLabel.Text = _currentBattle.battleEnemy.health.ToString();
            playerNameLabel.Text = _currentBattle.battlePlayer.name;
            playerHealthLabel.Text = _currentBattle.battlePlayer.health.ToString();                                  
                                    
        }

        private void attackButton_Click(object sender, EventArgs e)
        {

            //Player Variables
            string playName = _currentBattle.battlePlayer.name;
            int playHealth = Int32.Parse(playerHealthLabel.Text);
            int playAtk = _currentBattle.battlePlayer.attack;
            int playDef = _currentBattle.battlePlayer.defense;

            //Enemy Variables
            string enemyName = _currentBattle.battleEnemy.name;
            int enemyHealth = Int32.Parse(enemyHealthLabel.Text);
            int enAtk = _currentBattle.battleEnemy.attack;
            int enDef = _currentBattle.battleEnemy.defense;

            
            //Random objects for rolls.
            int rand1 = Roll.GenerateRandomNumber();
            int rand2 = Roll.GenerateRandomNumber();

            //Game round. 
            if (playAtk > enDef)
            {
                enemyHealth = enemyHealth -= playAtk;
                combatOutputLabel.Text += (playName + " " + "hits" + " " + enemyName + " " + "for " + " " + playAtk + " " + System.Environment.NewLine);
                enemyHealthLabel.Text = enemyHealth.ToString();
                if (enemyHealth < 1)
                {
                    MessageBox.Show(enemyName + " has been defeated by " + playName);
                    _currentBattle.battleEnemy.health = 0;
                    //close the form.
                    this.Close();
                }

            }
            else
            {
                enemyHealth = enemyHealth -= rand1;
                combatOutputLabel.Text += (playName + " " + "hits" + " " + enemyName + " " + "for " + " " + rand1 + System.Environment.NewLine);
                enemyHealthLabel.Text = enemyHealth.ToString();
                if (enemyHealth < 1)
                {
                    MessageBox.Show(enemyName + " has been defeated by " + playName);
                    _currentBattle.battleEnemy.health = 0;

                    //close the form.
                    this.Close();
                }
            }

            if (enAtk > playDef)
            {
                playHealth = playHealth -= enAtk;
                combatOutputLabel.Text += (enemyName + " " + "hits" + " " + playName + " " + "for " + " " + enAtk + " " + System.Environment.NewLine);
                playerHealthLabel.Text = playHealth.ToString();
                if (playHealth < 1)
                {
                    MessageBox.Show(playName + " has been defeated by " + enemyName);

                    //close the form.
                    this.Close();
                }

            }
            else
            {
                playHealth = playHealth -= rand2;
                combatOutputLabel.Text += (enemyName + " " + "hits" + " " + playName + " " + "for " + " " + rand2 + " " + System.Environment.NewLine);
                playerHealthLabel.Text = playHealth.ToString();
                if (playHealth < 1)
                {
                    MessageBox.Show(playName + " has been defeated by " + enemyName);
                    //close the form.
                    this.Close();
                }
            }

        }





    }

            






        }
    

