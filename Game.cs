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
        private Item _bow;
        private Item[] _shopInventory; 
        private bool _gameOver = false;

        private void InitializeItems()
        {
            _shopInventory = new Item[3];
            _arrow.name = "Arrow";
            _arrow.cost = 1;
            _shopInventory[0] = new Item();
            _shield.name = "Shield";
            _shield.cost = 1;
            _shield = _shopInventory[1];
            _bow.name = "Bow";
            _bow.cost = 1;
            _bow = _shopInventory[2];
        }

        public void PrintInventory(Item[] inventory)
        {
            Console.Write("\n");
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + "  " + inventory[i].cost + " Gold");
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("Hello Dearie. What can I do for you today?");
            char input = ' ';
            while(input != '1' && input != '2')
            {
                Console.WriteLine("1. Buy");
                Console.WriteLine("2. Sell");
                Console.WriteLine("3. Inventory");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        Console.WriteLine("\nWhat would you like to buy Dearie?");
                        PrintInventory(_shopInventory);
                        break;
                    case '2':
                        break;
                    case '3':
                        PrintInventory(_player.GetInventory());
                        Console.WriteLine();
                        OpenShopMenu();
                        break;
                }
            }
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
            _player = new Player();
            _shop = new Shop();
            OpenShopMenu();
            _gameOver = true;
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
