using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_0927_Conditionals
{
    class Program
    {
        private static int greatestNumber;
        private static int leastNumber;

        static void Main(string[] args)
        {
            // #1
            //Console.WriteLine("Please enter a whole number.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a second whole number.");
            //int secondNumber = int.Parse(Console.ReadLine());

            //if(firstNumber == secondNumber)
            //    {
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number.");
            //}

            //else
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other.");
            //}

            // #2
            // Write a console application that asks the user for a number. Tell the user if that number is even or odd. 

            //Console.WriteLine("Please enter a whole number.");
            //int userNumber = int.Parse(Console.ReadLine());
            //int remainder = userNumber % 2;
            //if(remainder == 0)
            //{
            //    Console.WriteLine(userNumber + " is an even number.");
            //}

            //else
            //{
            //    Console.WriteLine(userNumber + " is an odd number.");
            //}

            // #3
            // Write a console application that asks the user for a number and tells them if that number is a positive or negative number. 
            // What happens when the user enters 0? Is it positive or negative?

            //Console.WriteLine("Please enter a number.");
            //int userNumber = int.Parse(Console.ReadLine());

            //if(userNumber > 0)
            //{
            //    Console.WriteLine("The number " + userNumber + " is a positive number.");
            //}

            //else if(userNumber < 0)
            //{
            //    Console.WriteLine("The number " + userNumber + " is a negative number.");
            //}

            //else
            //{
            //    Console.WriteLine("The number " + userNumber + " is neither positive nor negative.");
            //}

            // #4
            // Write a console application to check whether a letter is a vowel or consonant. 
            // Hint: You can do this problem using a switch or an if condition.

            //Console.WriteLine("Please enter a letter of the alphabet - use capital, please.");
            //char userLetter = char.Parse(Console.ReadLine());

            //switch (userLetter)
            //{
            //    case 'A':
            //        Console.WriteLine("The letter " + userLetter + " is a vowel.");
            //        break;
            //    case 'E':
            //        Console.WriteLine("The letter " + userLetter + " is a vowel.");
            //        break;
            //    case 'I':
            //        Console.WriteLine("The letter " + userLetter + " is a vowel.");
            //        break;
            //    case 'O':
            //        Console.WriteLine("The letter " + userLetter + " is a vowel.");
            //        break;
            //    case 'U':
            //        Console.WriteLine("The letter " + userLetter + " is a vowel.");
            //        break;
            //    case 'Y':
            //        Console.WriteLine("The letter " + userLetter + " is sometimes a vowel.");
            //        break;
            //    default:
            //        Console.WriteLine("The letter " + userLetter + " is a consonant.");
            //        break;

            //}

            // #5
            // Write a console application that prompts the user to input two integer values. 
            // Find and print the greatest value of the two integers. 

            //Console.WriteLine("Please enter an integer.");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a second integer.");
            //int secondNumber = int.Parse(Console.ReadLine());

            //if(firstNumber > secondNumber)
            //{
            //    Console.WriteLine(firstNumber + " is the number with the greater value.");
            //}
            //else if(firstNumber < secondNumber)
            //{
            //    Console.WriteLine(secondNumber + " is the number with the greater value.");
            //}
            //else
            //{
            //    Console.WriteLine(firstNumber + " and " + secondNumber + " have the same value.");
            //}

            // #6
            // Write a Console application that asks the user for 4 integers. 
            // Calculate the mean for these 4 numbers and display the result.
            // Hint: make sure to choose the correct data types.

            Console.WriteLine("Please enter an integer.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second integer.");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third integer.");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a fourth integer.");
            int fourthNumber = int.Parse(Console.ReadLine());

            double totalNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;

            double mean = totalNumber / 4;

            Console.WriteLine("The mean of these four numbers is " + mean + ".");


           





        }
    }
}
