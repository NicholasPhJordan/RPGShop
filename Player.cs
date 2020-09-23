using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        //player constructor
        public Player()
        {
            _inventory = new Item[3];
            _gold = 4;
        }

        public bool Buy(Item item, int index)
        {
            if (_gold > item.cost)
            {
                _gold -= item.cost;
                _inventory[index] = item;
                return true;
            }
            return false;
        }  

        //gets the amount of gold the player has
        public int GetGold()
        {
            return _gold;
        }

        //gets the players inventory
        public Item[] GetInventory()
        {
            return _inventory;
        }
    }
}
