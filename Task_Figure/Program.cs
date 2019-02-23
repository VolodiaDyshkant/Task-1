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
            Square a=new Square();
            Rectangle b=new Rectangle();
            Console.WriteLine("\n--------------------------------------\n");
            a.Draw();
            Console.WriteLine("\n--------------------------------------\n");
            b.Draw();
            Console.WriteLine("\n--------------------------------------\n");
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
