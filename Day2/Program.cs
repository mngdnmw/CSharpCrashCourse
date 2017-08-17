using System;

namespace Day2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5(); //Similiar to Ex6, Ex7, Ex9, Ex10 so skipped
            //Ex8(); 

        }

 


			static void Ex8()
        {
            Console.WriteLine("Choose three numbers and separate them by a comma.");

            string numbers = Console.ReadLine();

            //Checks there are three numbers inputted
            int[] valuesInt = StringToIntArray(numbers, 2);


            if (valuesInt == null)
            {
                Console.WriteLine("You did something wrong, start again!");
                Ex8();
            }

            else
            {
                int largest = 0;

                for (int i = 0; i < valuesInt.Length; i++)
                {
                    if (largest < valuesInt[i])
                    {
                        largest = valuesInt[i];
                    }

                }
                Console.WriteLine(largest + " is the largest number amongst the three!");

            }

        }

        static void Ex5()
        {
            Console.WriteLine("How old are you?");

            string inputNum = Console.ReadLine();
            int votingAge = 18;
            int inputNumInt;

            if (int.TryParse(inputNum, out inputNumInt))
            {

                if (inputNumInt >= votingAge)
                {
                    Console.WriteLine("YAY! You're old enough to vote!");
                }
                else
                {
                    Console.WriteLine("Boo, you're too young to vote. But see you in " + (votingAge - inputNumInt) + " years!");
                }

            }
            else
            {
                Console.WriteLine("You did not enter a valid year, start again!");
                Ex5();
            }

        }
        static void Ex4()
        {
            Console.WriteLine("What year do you want to check to see if it's a leap year?");

            string inputNum = Console.ReadLine();
            int inputNumInt;

            if (int.TryParse(inputNum, out inputNumInt))
            {

                if (inputNumInt % 4 == 0)
                {
                    Console.WriteLine(inputNumInt + " is a leap year! Yay!");
                }
                else
                {
                    Console.WriteLine(inputNumInt + " is not a leap year! Boohoo :(");
                }

            }
            else
            {
                Console.WriteLine("You did not enter a valid year, start again!");
                Ex4();
            }

        }

        static void Ex3()
        {
            Console.WriteLine("Choose your number!");

            string inputNum = Console.ReadLine();
            int inputNumInt;

            if (int.TryParse(inputNum, out inputNumInt))
            {

                if (inputNumInt == 0)
                    Console.WriteLine(inputNumInt + " is zero");
                if (inputNumInt > 0)
                    Console.WriteLine(inputNumInt + " is a positive number");
                if (inputNumInt < 0)
                    Console.WriteLine(inputNumInt + " is a negative number");

            }
            else
            {
                Console.WriteLine("You screwed up, start again!");
                Ex3();
            }
        }

        static void Ex2()
        {
            Console.WriteLine("Choose a magic number!");

            string inputNum = Console.ReadLine();
            int inputNumInt;

            if (int.TryParse(inputNum, out inputNumInt))
            {

                if (inputNumInt % 2 == 0)
                {
                    Console.WriteLine("Your magic number " + inputNumInt + " is even!");
                }
                else
                {
                    Console.WriteLine("Your magic number " + inputNumInt + " is odd!");
                }

            }
            else
            {
                Console.WriteLine("You screwed up, start again!");
                Ex2();
            }
        }

        static void Ex1()
        {

            Console.WriteLine("Choose two numbers and separate them by a comma.");

            string numbers = Console.ReadLine();

            //Checks there are two numbers inputted
            int[] valuesInt = StringToIntArray(numbers, 1);


            if (valuesInt == null)
            {
                Console.WriteLine("You did something wrong, start again!");
                Ex1();
            }

            else
            {

                int intOne = valuesInt[0];
                int intTwo = valuesInt[1];

                if (intOne == intTwo)
                {
                    Console.WriteLine(intOne + " is the same as " + intTwo);
                }
                else
                {
                    Console.WriteLine(intOne + " is not the same as " + intTwo);
                }
            }


        }

        static int[] StringToIntArray(string inputString, int desiredCommas)
        {
            int count = 0;
            int[] valuesInt = new int[desiredCommas + 1];


            //Checks there are 3 number inputs
            foreach (char c in inputString)
            {
                if (c == ',') count++;
            }

            if (count == desiredCommas)
            {

                string[] values = inputString.Split(',');

                //Checks all values are numbers
                for (int i = 0; i < values.Length; i++)
                {

                    if (IsInteger(values[i]) == false)
                    {
                        return null;
                    }

                    else
                    {
                        //Adds the numbers to an int array
                        int temp;
                        temp = Convert.ToInt32(values[i]);
                        valuesInt[i] = temp;
                    }

                }

            }
            else
                return null;

            return valuesInt;
        }

        static Boolean IsInteger(string s)
        {
            int inputNumInt;
            if (int.TryParse(s, out inputNumInt))
                return true;
            else
                return false;

        }
    }



}


