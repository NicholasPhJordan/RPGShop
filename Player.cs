using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
            _gold = 4;
        }

        public bool Buy(Item[] index, int item)
        {
            if (GetGold() > 0)
            {

            }
        }  

        public int GetGold()
        {
            return _gold;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }
    }
}
