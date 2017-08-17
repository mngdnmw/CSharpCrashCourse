using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            Ex5();


        }

        private static void Ex5()
        {
            int[] valuesArray = new int[5];

            //Number of correct numbers inputted
            int correctInput=0;

            for (int i = 0; i < 100; i++){

                if (correctInput < 100)
                {
                    Console.WriteLine("Choose a number: ");
                    string inputString = Console.ReadLine();

                    //See if the input is a number
                    try
                    {

                        valuesArray[correctInput] = int.Parse(inputString);
                        correctInput++;

                    }
                    catch
                    {
                        Console.WriteLine("Input a proper number fool!");
                    }
                }
                else{
                    Console.WriteLine("Are you stupid?!! Do you not know what numbers are? \nStart again!");
                    Ex5();
                }

			}

            int sum = 0;
            for (int j = 0; j < valuesArray.Length; j++){
                sum += valuesArray[j];
            }

            Console.WriteLine("Sum of all your numbers is: " + sum);
		}

        private static void Ex4()
        {

            Console.WriteLine("Choose your weapon...or a sentence of your choice, whichever you decide:");

			string inputString = Console.ReadLine();

            int whiteSpaces = 0;
			foreach (char c in inputString)
			{
				if (c == ' ')
					whiteSpaces++;
			}
            Console.WriteLine("There are "+whiteSpaces +" whitespaces in your sentence!");

        }

        private static void Ex3()
        {
            Console.WriteLine("Choose two numbers and separate them by a comma.");

            string inputString = Console.ReadLine();

            //Checks there is one comma in the string
            int count = 0;

            foreach (char c in inputString)
            {
                if (c == ',')
                    count++;
            }

            if (count == 1)
            {
                //Checks the comma separated string is actually numbers
                try
                {
                    string[] values = inputString.Split(',');
                    int[] valuesInt = new int[2];


                    for (int i = 0; i < values.Length; i++)
                    {
                        valuesInt[i] = int.Parse(values[i]);

                    }

                    int sum = valuesInt.Sum();

                    Console.WriteLine("Sum of your two numbers is " + sum);

                }
                catch
                {

                    Console.WriteLine("You thought you could trick me?! \nTry again with some numbers fool!");
                    Ex3();
                }

            }
            else{
                
                Console.WriteLine("You didn't input two numbers, try again!");
                Ex3();
            }

        }


        private static void Ex2()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Ex2(name);

        }

        private static void Ex2(string name)
        {
            Console.WriteLine("Welcome friend " + name + "! \nHave a nice day!");
        }

        private static void Ex1()
        {
            Console.WriteLine("Welcome Friends! \nHave a nice day!");
        }
    }


}
