using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void ByeScreen()
        {
            Console.Clear();
            Console.WriteLine("That's enough for today!");
            Console.WriteLine("Push any key if you want to restart the program and write additional data to today's register.");

            Console.ReadKey();
        }
        static void Introduction()
        {
            Console.WriteLine("We're going to build a journal today. The author will be you.");
            Console.WriteLine("To begin writing, type 'start'");
            Console.WriteLine("Type 'stop' to finish writing and save the txt file with the date of today.");
        }
        static void Main(string[] args)
        {
            string Date = DateTime.Today.ToString("D");
            string data;
            Introduction();
            while (true)
            {
                data = Console.ReadLine();
                if (data == "start" || data == "Start") break;
            }
            using (StreamWriter Journal = new StreamWriter(Date + ".txt", true))
            {
                Console.Clear();
                Console.WriteLine("Start Writing");
                while (true)
                {
                    data = Console.ReadLine();
                    if (data == "stop" || data == "Stop") break;
                    Journal.WriteLine(data);
                    Journal.Flush();
                }
            }
            ByeScreen();


        }
       
       
    }
}