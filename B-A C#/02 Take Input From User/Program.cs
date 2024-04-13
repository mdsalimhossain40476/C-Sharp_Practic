using System;
using static System.Console;

namespace TakeInputFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please Input your name.");

            WriteLine(ReadLine());

            ReadLine();
        }
    }
}
