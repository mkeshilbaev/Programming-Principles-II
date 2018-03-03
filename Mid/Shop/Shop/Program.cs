using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Budget
    {
        public static int Money { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Budget.Money = 5000;
            Menu menu = new Menu();
            menu.Start();
        }
    }
}
