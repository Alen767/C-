1.

Create a function that takes voltage and current and returns the calculated power.

public class Program 
{
    public static int CircuitPower(int voltage, int current) 
    {
			int answer = (voltage * current);
			return answer;
    }
}


2.

Create a function that takes the age in years and returns the age in days.

public class Program 
{
    public static int CalcAge(int age) 
    {
			int agetodays = (age * 365);
				return agetodays;
    }
}

3.

Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).

public class Program {
	public static int SumPolygon(int num)
	{
		if (num < 3)
			return 0;
		return ((num - 2) * 180);
	}
}


4.

Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

function inchesToFeet(inches) {
	
	const feet = inches / 12;
		if(inches < 12){
		return 0;
	}
	return feet;
	
}

5.

In this challenge, you must verify the equality of two different values given the parameters a and b.

using System.Reflection;

public class Program
{
	public static bool CheckEquality(object a, object b)
	{
		if (a.Equals(b))
      {
        return true;
      }
		  return false;
	}
}


6.

Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

using System;
public class Program 
{
    public static int CounterpartCharCode(char symbol) 
    {
			if (Char.IsUpper(symbol))
				return (int)Char.ToLower(symbol);
			return (int)Char.ToUpper(symbol);
    }
}


7.

Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.


using System;
using System.Linq;
public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
      double[] MaxNum = new double[values.Length];
      int count = 0;
				foreach(double[] array in values)
        {
          MaxNum[count] = array.Max();
          count++;
        }
      return MaxNum;
    }
}


8.

Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bomb
{
	class Program
	{
		static void Main(string[] args)
		{
			// ввод данных пользователя

            string sentence = Console.ReadLine();

            sentence = sentence.ToLower();

            bomb(sentence);
		}

        static void bomb(string txt){
// разделите входные слова на другие слова

            char[] seperate = {' ', ':', ',', '.', '?', '!'};

            string[] check = txt.Split(seperate);

            for (int n = 0; n < check.Length; n++){

                if (check[n] == "bomb"){

                    Console.WriteLine("Duck!!!");

                    break;

                } else if (check[n] != "bomb" && n == check.Length-1){ // проверяет, что текущее слово не является "бомбой" и что это конец массива

                    Console.WriteLine("There is no bomb, you are safe.");

                    break;
                }
            }
        }
	}
}


9.

Count the amount of ones in the binary representation of an integer. For example, since 12 is 1100 in binary, the return value should be 2.

using System;
using System.Linq;
public class Program
{
    public static int CountOnes(int num)
    {
			string binary = Convert.ToString(num, 2);
			return binary.Where(x => x == '1').Count();
    }
}

10.

ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
using System.Linq;

public class Program 
{
    public static bool ValidatePIN(string pin) =>
      (pin.Length == 4 || pin.Length == 6)
			&&pin.All(char.IsDigit);
}

11.

Create a function that takes a string and returns the middle character(s). If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.
using System;
public class Program 
{
    public static string GetMiddle(string str) 
    {
      if(str.Length % 2 == 0) { //is even
				return str[(str.Length / 2) -1]
					.ToString() + str[str.Length / 2].ToString();
			} else {
				return str[str.Length/2].ToString();//is odd
			}
    }
}

12.

A tetrahedron is a pyramid with a triangular base and three sides. A tetrahedral number is a number of items within a tetrahedron.

Create a function that takes an integer n and returns the nth tetrahedral number.

public class Program {
	public static int Tetra(int n) {
		return n * (n + 1) * (n + 2) / 6;
	}
}


13.
сложно
Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.

To illustrate:

using System;
using System.Linq;
public class Program {
  public static string ReverseAndNot(int i) {

    return String.Join("", i.ToString().Reverse()) + i.ToString();

  }
}

14.
эксперт

using System;
public class Program
{
  	public static int TrailingZeroes(int n) 
	  {
		   int b = 1;
       int a = 0;
       while (Math.Pow(5, b) < n)
       {
           a += n / (int)Math.Pow(5, b);
           b++;
       }
       return a;
	  }
}
