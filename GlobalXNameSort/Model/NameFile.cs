using System;
using System.Collections.Generic;
using System.IO;
namespace GlobalXNameSort.Model
{
    public class NameFile
    {
        //FilePath
        public string filePath;
        //This is the name list in the target file.
        public List<string> content = new List<string>();
        
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

        public void ReadFile(){
            ReadFileFrom( this.filePath);
            
        }


        // Method
        public void ReadFileFrom(string filePath)
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
                this.content = newContent;
            }
            catch (FileNotFoundException e)
            {
                
                Console.WriteLine("File not found: {0}", e.ToString());
                throw;  
            }
            catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

        public void WriteFileTo(string filePath)
        {
            //should write content to file of path 
            try
            {
                
                System.IO.File.WriteAllLines(filePath, this.content);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine("Argument Invalid: {0}", e.ToString());
                throw;
            }
            catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
    
  
    }
}
