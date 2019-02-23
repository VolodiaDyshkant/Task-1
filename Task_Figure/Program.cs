using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public abstract class Figure
    {
        public abstract void Draw();
    }
    public class Square:Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Square!");
        }
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle!");
        }
    }

}
