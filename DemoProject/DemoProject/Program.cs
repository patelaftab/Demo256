using DemoProject;
using System;


namespace Demo
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("Welcome to Demo");
            Console.WriteLine("======================================================");
            UCs.FirstUcs();
            UCs uCs=new UCs();
            uCs.SecondUc(); 
            Console.ReadLine();
        }
    }
}