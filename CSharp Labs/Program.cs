using CSharp_Labs.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ClearItems();
            Menu.AddItem(new MenuItemExit());
            Menu.AddItem(new MenuItemHelloWorld());
            Menu.AddItem(new MenuItemCalc());
            Menu.AddItem(new MenuItemRecursion());
            Menu.AddItem(new MenuItemStringsValidation());

            while (true)
            {
                Menu.Execute();
            }
        }
    }
}
