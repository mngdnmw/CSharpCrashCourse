using System;

namespace Day4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Introduction();
            string[] menuItems=new string[4];
            AddItems(ref menuItems);
            ShowMenu(menuItems);

        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.Clear();

            Console.WriteLine("Select what you want to do:\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i+1)+":"+menuItems[i]);
            }

			Console.WriteLine( "");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)|| selection<1 || selection>5)
            {
                Console.WriteLine("You need to select one of the menu items by typing in the menu item nummber");
            }

            Console.WriteLine("Selection: " + selection);
            return selection;

        }

        private static void AddItems(ref string[] menuItems)
        {
           menuItems. = {
                "Create video",
                "Read video",
                "Update video",
                "Delete video",
                "Exit"
            };     
        }

        private static void Introduction()
        {
            Console.WriteLine("Welcome to the world's best video application\xB2a \n\n\xB2aJust better than Jeppe's");
        }


    }

}
