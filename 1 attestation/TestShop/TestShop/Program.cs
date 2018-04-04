using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop
{
    public class Product
            {
            public static int Money { get; set; }
            public static int Basket { get; set; }

    public static void Show(string s)
    {
        Console.Clear();
        Console.SetCursorPosition(40, 10);
        Console.Write("This produc t wass successfully bought!");
        Console.SetCursorPosition(40, 12);
        Console.Write("It will be delivered within the 3 days");
        Console.ReadKey();
        Console.Clear();
    }

    public static void CannotBuy()
    {
        Console.Clear();
        Console.SetCursorPosition(40, 10);
        Console.Write("You don't have enough money to buy this product!");
        Console.ReadKey();
        Console.Clear();
    }
}

    class Program
    {   

        static void Main(string[] args)
        {
        Console.CursorVisible = false;
        Product.Money = 50000;
        Product.Basket = 0;
        Menu menu = new Menu();
        menu.Start();
        }
    }
}
