namespace MyProgramWithDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        // Menu
        static void Main(string[] args)
        {
            bool fExit = false;
            const string Border = "=============================";
            int num = 0;

            do
            {
                try
                {
                    // Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(Border + "Welcome to my program!" + Border);
                    Console.WriteLine("To play with some data structure press the number.");
                    Console.WriteLine("1. Stack");
                    Console.WriteLine("2. Queue");
                    Console.WriteLine("3. List");
                    Console.WriteLine("4. Array List");
                    Console.WriteLine("5. Linked List");
                    Console.WriteLine("6. Dictionary");
                    Console.WriteLine("7. Hashtable");
                    Console.WriteLine("8. Exit");
                    Console.WriteLine("Press here: ");
                    num = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (num < 1 || num > 8)
                    {
                        num = 0;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Do you see the range??");
                    }

                    if (num == 1)
                    {

                    }

                    if (num == 2)
                    {

                    }

                    if (num == 3)
                    {

                    }

                    if (num == 4)
                    {

                    }

                    if (num == 5)
                    {

                    }

                    if (num == 6)
                    {

                    }

                    if (num == 7)
                    {

                    }

                    if (num == 8)
                    {
                        Environment.Exit(1);
                    }
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("From 1 to 8. Nothing hard.");
                }

                

            } while (!fExit);
            Console.ReadLine();
        }
    }
}
