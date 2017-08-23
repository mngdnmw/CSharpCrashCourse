using System;
using System.Collections.Generic;

namespace Day4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Introduction();

            List<string> menuItems = new List<string> { "Create video", "Read video", "Update video", "Delete video", "Exit" };

            var selection = 0; 

            while (selection !=5){
                selection=ShowMenu(menuItems);
				PrintSelection(selection);
            }

            Console.WriteLine("Hej hej!");

        }

        private static int ShowMenu(List<string> menuItems)
        {
            //Console.Clear();

            Console.WriteLine("Select what you want to do:\n");
            for (int i = 0; i < menuItems.Count; i++)
            {
                //Less memory heavy than the + signs
                Console.WriteLine($"{ (i + 1)}:{ menuItems[i]}");
            }

            Console.WriteLine("");

            int selection;

            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("You need to select one of the menu items by typing in the menu item number (between 1-5)\n");
            }

            return selection;

        }

        private static void PrintSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Create video\n");
                    break;
                case 2:
                    Console.WriteLine("Read video\n");
                    break;
                case 3:
                    Console.WriteLine("Update video\n");
                    break;
                case 4:
                    Console.WriteLine("Delete video\n");
                    break;
                default:
                    break;
            };

        }

        //ref works similiarly to out, but it requires initialisation before use 
        private static void AddItems(ref List<string> menuItems, string item)
        {
            menuItems.Add(item);

        }

        private static void Introduction()
        {
            Console.WriteLine("Welcome to the world's best video application\xB2a \n\xB2aJust better than Jeppe's\n");
        }


    }

}
