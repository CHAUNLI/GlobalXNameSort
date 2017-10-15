using System;
using System.IO;

namespace GlobalXNameSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(Constants.greeting);
            Console.WriteLine(Constants.instructionInfo);
            //string pathOfDirectory = Path.Combine(Environment.CurrentDirectory);
            string filePath = Console.ReadLine();
            Console.WriteLine(filePath);
            //ReadFile readNameList = new ReadFile(filePath);
        }
    }
}
