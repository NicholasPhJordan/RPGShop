using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public string name;
        public int cost;
    }

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
            _arrow.name = "Arrow";
            _arrow.cost = 1;
            _shield.name = "Shield";
            _shield.cost = 1;
            _bow.name = "Bow";
            _bow.cost = 1;
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
            _player = new Player();
            InitializeItems();
            _shopInventory = new Item[]{ _arrow, _shield, _bow };
            _shop = new Shop(_shopInventory);
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
            _gameOver = true;
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
