using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop
{
    class Adidas
    {
        String[] items = {"    Sneakers     ",
                          "    T-Shirt      ",
                          "    Trousers     ",
                          "    Back         "};

        int[] itemsPrice = {17890,
                            11990,
                            9990,
                            0};

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
                            if (selectedItem > ItemsCount) { selectedItem = 0; }
                            break;
                        }

                    case ConsoleKey.Enter:
                        {
                            switch (selectedItem)
                            {
                                    case 0:

                                    case 1:
                                    {
                                        if (Product.Money >= itemsPrice[selectedItem])
                                        {
                                            Product.Show(items[selectedItem]);
                                            Product.Money -= itemsPrice[selectedItem];
                                            Product.Basket++;
                                        }

                                        else
                                        {
                                            Product.CannotBuy();
                                        }
                                        break;
                                    }

                                    case 2:
                                    
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

        void Draw()
        {
            Console.SetCursorPosition(60, 2);
            Console.Write("Your current budget is " + Product.Money + " KZT");

            Console.SetCursorPosition(75, 3);
            Console.Write("Basket: " + Product.Basket + " items");

            int posX = 40, posY = 10;
            Console.SetCursorPosition(posX, posY);

            for (int i = 0; i < ItemsCount; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                Console.Write("|");

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
                Console.Write("|");
                if (itemsPrice[i] != 0)
                {
                    Console.Write("   " + itemsPrice[i] + " KZT    ");
                }
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
