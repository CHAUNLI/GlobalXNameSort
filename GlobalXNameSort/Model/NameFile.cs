using System;
using System.Collections.Generic;

namespace GlobalXNameSort.Model
{
    public class NameFile
    {
        //FilePath
        public string filePath;
        //This is the name list in the target file.
        public List<string> content;
        
        public NameFile()
        {
            filePath = @"";
            //TODO think about if no file path, should be able to create file or not? 
        }
        public NameFile(string newFilePath)
        {
            this.filePath = newFilePath;
            //this.content = nil;
            //TODO think about how to init file content? 
        }
        public NameFile(string newFilePath,List<string> newContent)
        {
            this.filePath = newFilePath;
            this.content = newContent;
            //TODO think about if no file path, should be able to create file or not? 
        }

        // Method
        public void ReadFiileFrom(string filePath)
        {
            try
            {
                //should read file from path ,and load content into object.
                List<string> newContent = new List<string>();
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    //TODO we need a name class init from one line string
                    Console.WriteLine("\t" + line);
                    newContent.Add(line);
                }
            }
            catch
            {
                Console.WriteLine("Check your path");
            }

        }
        public void WriteFileTo(string filePath)
        {
            //should write content to file of path 
            //TODO 
            try
            {
                System.IO.File.WriteAllLines(filePath, this.content);
            }
            catch
            {
                Console.WriteLine("Check your path");
            }
        }
    
  
    }
}
