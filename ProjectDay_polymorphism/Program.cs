using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_polymorphism
{
    class Program
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> things = new List<string> { "Book", "DVD", "Magazine","Exit" };
            int x = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the number ya want: ");
                int counter = 1;
                foreach (string thing in things)
                {
                    Console.WriteLine($"{counter}.  {thing}");
                    counter++;
                }
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Book book = new Book();
                        book.AddTitle();
                        book.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you check out a book:");
                        book.CheckOut();
                        book.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you return a book:");
                        book.CheckIn();
                        book.ViewTitle();
                        Console.Read();
                        break;
                    case "2":
                        DVD dvd = new DVD();
                        dvd.AddTitle();
                        dvd.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you check out a DVD:");
                        dvd.CheckOut();
                        dvd.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you return a DVD:");
                        dvd.CheckIn();
                        dvd.ViewTitle();
                        Console.Read();
                        break;
                    case "3":
                        Magazine magazine = new Magazine();
                        magazine.AddTitle();
                        magazine.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you check out a magazine:");
                        magazine.CheckOut();
                        magazine.ViewTitle();
                        Console.WriteLine("\nThis is what it looks like when you check out a magazine:");
                        magazine.CheckIn();
                        magazine.ViewTitle();
                        Console.Read();
                        break;
                    case "4":
                        x = 0;
                        return;
                    default:
                        break;
                }
            }
            while (x == 1);


            Console.Read();
        }
    }
}
