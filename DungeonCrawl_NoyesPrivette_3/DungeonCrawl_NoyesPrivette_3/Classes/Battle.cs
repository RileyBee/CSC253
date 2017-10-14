using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette_3
{
    public class Battle
    {
        private Player _battlePlayer;
        private Enemy _battleEnemy;

        public Battle(Player pl, Enemy en)
        {
            _battlePlayer = pl;
            _battleEnemy = en;
        }
    }
}
