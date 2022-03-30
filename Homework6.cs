/*      
 *--------------------------------------------------------------------
 * 	   File name: Homework6.cs
 * 	Project name: Homework6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Brycen Dunn; dunnbe@etsu.edu
 *          Course-Section: CSCI 1250 - 002
 *           Creation Date:	 03.24.22
 * -------------------------------------------------------------------
 */
/*
 * Method Calls:
 *
 * 1. ShowCharacter is called
 * with the parameters "New York"
 * and "2" as outlined
 * in the assignment PDF.
 * 
 * 2. CalculateRetail is called 
 * with no parameters as it is void.
 *
 * 3.Celsius is called with
 * for (var i = 80; i <= 100; i++) Console.WriteLine(Math.Round(Celsius(i), 3));
 *
 * 4. IsPrime is called with
 * the parameter 7 (prime) and 12
 * (not prime)
 *
 * Console.WriteLine(Environment.NewLine);
 * is used between each call for neatness
 * in output. 
 */

ShowCharacter("New York", 2);
Console.WriteLine(Environment.NewLine);
CalculateRetail();
Console.WriteLine(Environment.NewLine);
Console.WriteLine(Environment.NewLine);
for (var i = 80; i <= 100; i++) Console.WriteLine(Math.Round(Celsius(i), 3));
IsPrime(7);
Console.WriteLine(Environment.NewLine);
IsPrime(12);
/*
 * Method 1 - Show Character
 */

static void ShowCharacter(string name, int number)
{
 Console.Write(name[number - 1]);
}

/*
 * Method 2 - Retail Price
 */

static void CalculateRetail()
{
 Console.WriteLine("What is the wholesale cost of the item?");
 var wholesaleCost = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("What is the markup percentage of the item?");
 var markup = Convert.ToDouble(Console.ReadLine());
 var total = wholesaleCost * (markup / 100);
 Console.WriteLine($"The marked up total is {total + wholesaleCost}");
}

/*
 * Method 3 - Temperature Table
 */

static double Celsius(double f)
{
 var c = 5.0 / 9.0 * (f - 32);
 return c;
}

/*
 * Method 4 - Prime Numbers
 */

static void IsPrime(int num)
{
 var n = 0;
 for (var i = 1; i <= num; i++)
  if (num % i == 0) n++;
 if (n == 2) Console.Write($"{num} is a prime number. ");
 else Console.Write($"{num} is not a prime number. ");
}

