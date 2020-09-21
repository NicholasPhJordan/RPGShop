using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        private Player _player;
        private Shop _shop;
        private Item _arrow;
        private Item _shield;
        private Item _gem;
        private Item[] _shopInventory; 
        private bool _gameOver = false;

        private void InitializeItems()
        {
            _arrow.name = "Arrow";
            _arrow.cost = 1;
            _arrow = _shopInventory[0];
            _shield.name = "Shield";
            _shield.cost = 1;
            _arrow = _shopInventory[1];
            _gem.name = "Gem";
            _gem.cost = 1;
            _arrow = _shopInventory[2];
        }

        public Item PrintInventory(Item[] index)
        {
            for(int i = 0; i < index.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + index[i].name + "  " + index[i].cost + " Gold");
            }
            return index;
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("Hello Dearie. What can I get you today?");
            PrintInventory(_shopInventory);
        }

        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            InitializeItems();
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
