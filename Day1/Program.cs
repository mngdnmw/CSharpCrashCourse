using System;

namespace Day1
{
class MainClass
	{
		public static void Main(string[] args)
		{
			//Ex1();
			//Ex. 2, 3: Performs opertation between a random number and another number of the person's choosing
			//Operation("What is your favourite number?", "Summation");
			//Operation("Choose a number to divide", "Division");

			//Ex4();
			//Ex5();
			//Ex6();
			//Ex7();
			//Ex8();
			//Ex9();
			//Ex10();
			//Ex11();
			//Ex12();
			//Ex13();
			//Ex14();
			//Ex15();
			//Ex16();
		}

		static void Ex16()
		{
			Console.WriteLine("Choose a word fool!");
			string input = Console.ReadLine().Trim();

			char[] chara = input.ToCharArray();

			char first = chara[0];
			char last = chara[input.Length - 1];

			chara[0] = last;
			chara[input.Length - 1] = first;

			string s = new string(chara);

			Console.WriteLine(s);


		}
		static void Ex15()
		{

			Console.WriteLine("What is the longest word you know?");
			string input = Console.ReadLine();
			int charLeng = input.Length;
			if (charLeng >= 3)
			{
				Console.WriteLine(remove_char(input, charLeng - 1) + "\n" +
								  remove_char(input, charLeng - 2) + "\n" +
								  remove_char(input, charLeng - 3));
			}
			else
			{
				Console.WriteLine("Come on, you must know a longer word than that!");
				Ex15();
			}

		}

		static string remove_char(string input, int n)
		{
			return input.Remove(n, 1);
		}

		static void Ex14()
		{

			Console.WriteLine("Enter temperature in celsius you want to convert:");
			string input = Console.ReadLine();
			int inputInt;

			if (int.TryParse(input, out inputInt))
			{
				Double fahrenheit = (Convert.ToDouble(input)) * 9 / 5 + 32;
				Double kelvin = Convert.ToDouble(input) + 273.15;

				Console.WriteLine(input + "°C = " + fahrenheit + "°F = " + kelvin + "K");

			}
			else
			{
				Console.WriteLine("Please input a valid number!");
				Ex14();
			}

		}

		static void Ex13()
		{

			Console.WriteLine("How many toads do you know?");
			string input = Console.ReadLine();

			string format1 = String.Format("{0}{0}{0}", input);
			string format2 = String.Format("{0} {0}", input);


			Console.WriteLine(format1 + "\n" +
							 format2 + "\n" +
							 format2 + "\n" +
							 format2 + "\n" +
							 format1);
		}

		static void Ex12()
		{

			Console.WriteLine("How many friends do you have?");
			string input = Console.ReadLine();

			string format1 = String.Format("{0} {0} {0} {0}", input);
			string format2 = String.Format("{0}{0}{0}{0}", input);


			Console.WriteLine(format1 + "\n" +
							 format2 + "\n" +
							 format1 + "\n" +
							 format2);
		}
		static void Ex11()
		{
			Console.WriteLine("How many hairs do you have on your head?");
			string numbers = Console.ReadLine();
			int hairs = Convert.ToInt32(numbers);
			Console.WriteLine("In " + hairs + " days (or less), you will have no more hair on your head!");

		}

		static void Ex10()
		{
			Console.WriteLine("Please choose three numbers and separate them by commas.");
			string numbers = Console.ReadLine();

			int[] valuesInt = StringToIntArray(numbers, 2);

			if (valuesInt == null)
			{
				Console.WriteLine("You did something wrong, start again!");
				Ex10();
			}
			else
			{
				double x = valuesInt[0];
				double y = valuesInt[1];
				double z = valuesInt[2];

				double caseOne = (x + y) * z;
				double caseTwo = x * y + y * z;

				Console.WriteLine("(" + x + "+" + y + ")*" + z + "= " + caseOne + "\n" +
								  x + "*" + y + "+" + y + "*" + z + "= " + caseTwo);
			}
		}
		static void Ex9()
		{

			Console.WriteLine("Please choose four numbers and separate them by commas.");
			string numbers = Console.ReadLine();

			int[] intArr = StringToIntArray(numbers, 3);

			if (intArr == null)
			{
				Console.WriteLine("You did something wrong, start again!");
				Ex9();
			}
			else
			{
				double sum = 0;
				for (int j = 0; j < intArr.Length; j++)
				{
					sum = sum + intArr[j];
				}
				Console.WriteLine("The average of the four numbers you inputted is " + sum / 4);

			}
		}

		static void Ex8()
		{
			Console.WriteLine("Please choose a number!");
			string inputNum = Console.ReadLine();
			int num = Convert.ToInt32(inputNum);

			for (int i = 0; i < 16; i++)
			{
				Console.WriteLine(i + " x " + num + " = " + i * num);
			}

		}


		static void Ex7()
		{
			Console.WriteLine("Please choose two numbers and separate them by commas.");
			string numbers = Console.ReadLine();

			int[] intArr = StringToIntArray(numbers, 1);

			if (intArr == null)
			{
				Console.WriteLine("You did something wrong, start again!");
				Ex7();
			}
			else
			{
				double one = intArr[0];
				double two = intArr[1];

				if (CanDivide(one, two))
				{

					Console.WriteLine(one + " + " + two + " = " + Summation(one, two) + "\n" +
									  one + " - " + two + " = " + Subtraction(one, two) + "\n" +
									  one + " x " + two + " = " + Multiplication(one, two) + "\n" +
									  one + " / " + two + " = " + Division(one, two) + "\n" +
									  one + " mod " + two + " = " + Modulo(one, two));
				}

				else
				{
					Console.WriteLine("The numbers you have chosen cannot be divded, please try again!");
					Ex7();

				}
			}
		}

		static int[] StringToIntArray(string inputString, int desiredCommas)
		{
			int count = 0;
			int[] valuesInt = new int[desiredCommas + 1];


			//Checks there are x number of inputs
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

		static void Ex6()
		{

			Console.WriteLine("Please choose three numbers and separate them by commas.");
			string numbers = Console.ReadLine();

			int[] valuesInt = StringToIntArray(numbers, 2);

			if (valuesInt == null)
			{
				Console.WriteLine("You did something wrong, start again!");
				Ex6();
			}

			else
			{
				int multiple = 1;

				for (int j = 0; j < valuesInt.Length; j++)
				{
					multiple = multiple * valuesInt[j];
				}

				Console.WriteLine("Multiplying all the numbers yields = " + multiple);
			}

		}

		static Boolean IsInteger(string s)
		{
			int inputNumInt;
			if (int.TryParse(s, out inputNumInt))
				return true;
			else
				return false;

		}

		static void Ex5()
		{
			int oneInt;
			int twoInt;
			Console.WriteLine("Choose a number to swap");
			if (int.TryParse(Console.ReadLine(), out oneInt))
			{
				Console.WriteLine("Choose a second number to swap");
				if (int.TryParse(Console.ReadLine(), out twoInt))
				{
					Console.WriteLine("Before swap: " + oneInt + ":" + twoInt + "\n" +
									  "After swap: " + twoInt + ":" + oneInt);
				}
				else
				{
					Console.WriteLine("Invalid number, please start again");
					Ex5();
				}
			}
			else
			{
				Console.WriteLine("Please input a valid number");
				Ex5();
			}


		}

		static void Ex4()
		{
			double one = -1 + 4 * 6;
			double two = (35 + 5) % 7;
			double three = 14 + -4 * 6 / 11;
			double four = 2 + 15 / 6 * 1 - 7 % 2;

			Console.WriteLine("-1 + 4 * 6 = " + one + "\n" +
							  "(35 + 5) % 7 = " + two + "\n" +
							  "14 + -4 * 6 / 11 = " + three + "\n" +
							  "2 + 15 / 6 * 1 - 7 % 2 = " + four);
		}

		static void Operation(string message, string type)
		{
			Random random = new Random();
			Double randNum = random.Next(1, 100);

			Console.WriteLine(message);
			string inputNum = Console.ReadLine();
			int inputNumInt;

			if (int.TryParse(inputNum, out inputNumInt))
			{
				Double inputDouble = Convert.ToDouble(inputNum);
				switch (type)
				{
					case "Summation":
						Console.WriteLine(type + " of " + inputDouble + " and "
										  + randNum + " is equal to " + Summation(inputDouble, randNum));
						break;
					case "Division":
						if (CanDivide(inputDouble, randNum) == true)
						{
							Console.WriteLine(type + " of " + inputNumInt + " and "
										  + randNum + " is equal to " + Division(inputDouble, randNum));
						}
						else
						{
							Console.WriteLine("Cannot divide by these numbers, try again!");
							Operation(message, type);
						}

						break;
				}
			}
			else
			{
				Console.WriteLine("Please input a valid number!");
				Operation(message, type);
			}
		}

		static double Modulo(double one, double two)
		{
			return one % two;
		}

		static double Multiplication(double one, double two)
		{
			return one * two;
		}

		static double Subtraction(double one, double two)
		{
			return one - two;
		}

		static double Division(double one, double two)
		{
			return one / two;
		}

		static Boolean CanDivide(double one, double two)
		{
			double div = one / two;
			//Checks if the number is undefined or is infinity
			Boolean check = !Double.IsNaN(div) && !Double.IsInfinity(div);
			if (check)
				return true;
			else
				return false;
		}

		static double Summation(double one, double two)
		{
			return one + two;
		}

		static void Ex1()
		{
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			Console.WriteLine("Hello: " + name);
		}

	}









}
