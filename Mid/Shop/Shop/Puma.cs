using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Puma
    {
        string[] items = {"    Adidas   ",
                          "    Nike     ",
                          "    Puma     ",
                          "    Quit     "};

        int ItemsCount = 4;
        int selectedItem = 0;
        ConsoleColor selectedColor = ConsoleColor.Red;
        ConsoleColor unselectedColor = ConsoleColor.Yellow;

        public void Start()
        {
            Console.ForegroundColor = unselectedColor;
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo button = new ConsoleKeyInfo();
            bool quit = false;
            while (!quit)
            {
                Draw();
                button = Console.ReadKey(true);

                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            selectedItem--;
                            if (selectedItem < 0) { selectedItem = ItemsCount - 1; }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            selectedItem++;
                            if (selectedItem >= ItemsCount) { selectedItem = 0; }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            switch (selectedItem)
                            {
                                case 0:
                                    {
                                        Adidas();
                                        break;
                                    }
                                case 1:
                                    {
                                        Nike();
                                        break;
                                    }
                                case 2:
                                    {
                                        Puma();
                                        break;
                                    }
                                case 3:
                                    {
                                        quit = true;
                                        Console.Clear();
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        break;
                }


            }
        }

        private void Puma()
        {

        }

        private void Nike()
        {
            throw new NotImplementedException();
        }

        private void Adidas()
        {
            throw new NotImplementedException();
        }

        void Draw()
        {
            Console.SetCursorPosition(60, 2);
            Console.Write("Your curren budget is: " + Budget.Money);
            int posX = 40, posY = 10;
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < ItemsCount; i++)
            {

                Console.SetCursorPosition(posX, posY + i);
                Console.Write("│");
                if (selectedItem == i)
                {
                    Console.ForegroundColor = selectedColor;
                }
                else
                {
                    Console.ForegroundColor = unselectedColor;
                }

                Console.Write(items[i]);
                Console.ForegroundColor = unselectedColor;
                Console.Write("│");

                if (selectedItem == i)
                {
                    Console.ForegroundColor = selectedColor;
                    Console.SetCursorPosition(posX + 2, posY + i);
                    Console.Write(">>");
                    Console.ForegroundColor = unselectedColor;
                }
            }
        }
    }
}
