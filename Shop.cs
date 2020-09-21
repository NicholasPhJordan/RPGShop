using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public int cost;
        public string name;
    }

    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        public Shop()
        {
            _inventory = new Item[3];
            _gold = 4;
        }

        public Shop(Item[] item)
        {
            item = _inventory;
        }

        public bool Sell(Player player, int shopIndex, int playerIndex)
        {
            return player.Buy(_inventory[shopIndex], playerIndex);
        }

        public void CheckPlayerFunds(Player player)
        {
            Console.WriteLine("You have " + player.GetGold() + " gold.");
        }
    }
}
