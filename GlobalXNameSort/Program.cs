using System;
using System.IO;
using System.Collections.Generic;
using GlobalXNameSort.Model;
namespace GlobalXNameSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("\n\n" + Constants.instructionInfo +"\n\n");
                return;
            }
            Console.WriteLine(Constants.greeting);
            Console.WriteLine("\n");
            string path = args[0];
            NameFile unsortedFile = new NameFile(path);
            unsortedFile.ReadFile();

            Console.WriteLine("Unsorted name list from file " + path +":");
            List<FullName> unsortedList = new List<FullName>();
            foreach(string nameStr in unsortedFile.content){
                FullName name = new FullName(nameStr);
                if(name.isValid()){
                    unsortedList.Add(name);
                    Console.WriteLine("\t"+nameStr);
                }
            }
            Console.WriteLine("END ***************");

            Console.WriteLine("\n\n");
            List<FullName> sortedList = unsortedList;
            sortedList.Sort();

            NameFile sortedFile = new NameFile(sortedList);

            sortedFile.WriteFileTo(Constants.outputFilePath);

            Console.WriteLine("Sorted name list write to file " + Constants.outputFilePath + ":");
            //Display the sorted files
            foreach(string nameStr in sortedFile.content)
            {
                Console.WriteLine("\t"+nameStr);
            }
            Console.WriteLine("END ****************");
            Console.WriteLine("\n\n");
        }
    }
}
