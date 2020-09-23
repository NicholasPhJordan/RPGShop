﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        //shop constructor
        public Shop()
        {
            _inventory = new Item[3];
            _gold = 4;
        }

        //overload shop constructor
        public Shop(Item[] item)
        {
            item = _inventory;
        }

        public bool Sell(Player player, int shopIndex, int playerIndex)
        {
            if (player.Buy(_inventory[shopIndex], playerIndex))
            {
                return true;
            }
            return false;
        }

        public bool CheckPlayerFunds(Player player)
        {
            if (player.GetGold() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
