using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette_3
{
    public class Player : Thing
    {
        private int _health, _mana, _attack, _defense, _dexterity, _intelligence, _wisdom;
        private string _password, _cast, _race;
        private List<Thing> _inventory;

        public Player()
        {
            _password = "";

            _cast = "Warrior";
            _race = "Human";

            _health = 10;
            _mana = 10;

            _attack = 0;
            _defense = 0;
            _dexterity = 0;
            _intelligence = 0;
            _wisdom = 0;

            _inventory = new List<Thing>();
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string cast
        {
            get { return _cast; }
            set { _cast = value; }
        }

        public string race
        {
            get { return _race; }
            set { _race = value; }
        }

        public int health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        public int attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        public int intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public int wisdom
        {
            get { return _wisdom; }
            set { _wisdom = value; }
        }

        public List<Thing> inventory
        {
            get { return _inventory; }
        }

        public void pickUpItem (Thing item)
        {
            _inventory.Add(item);
        }

        public void dropItem (Thing item)
        {
            _inventory.Remove(item);
        }
    }
}
