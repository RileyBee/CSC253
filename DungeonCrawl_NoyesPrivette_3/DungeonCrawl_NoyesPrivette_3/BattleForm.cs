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

        public BattleForm()
        {
            InitializeComponent();
        }

        public Battle currentBattle
        {
            set { _currentBattle = value; }
        }
    }
}
