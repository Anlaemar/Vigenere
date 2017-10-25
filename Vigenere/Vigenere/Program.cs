using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vigenere
{
    class Program
    {
        static private string keyword;
        static private string message;

        static void Main(string[] args)
        {
            Console.WriteLine("This program will using the Vigenere cipher method of encrypting by\n" +
                              "changing the letters of a given string based on a alphabetic string\n" +
                              "known as the keyword.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You, the user, will first enter your key. It must not contain numerics!\n");
            Console.Write("Enter your key: ");
            keyword = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine("Now you'll enter what you want to encrypt. No numbers!");
            Console.Write("Enter your message: ");
            message = Console.ReadLine();
            Console.Write("\n");

            Console.Write("When you're ready to show your encrypted message, press any key.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Your encrypted message: ");
        }

        static void EncryptMessage()
        {
            // Still to come
        }
    }
}