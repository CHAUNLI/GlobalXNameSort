using System;
using System.IO;
using System.Text;

namespace GlobalXNameSort
{
    public class ReadFile
    {
        public ReadFile()
        {
            
        }
        public ReadFile(string path)
        {
            ReadTextFileContent(path);
        }

        private void ReadTextFileContent (string pathOfFile) {
            try{
                var fileStream = new FileStream(@pathOfFile, FileMode.Open, FileAccess.Read);
                StreamReader fileRead = new StreamReader(fileStream, Encoding.UTF8);
                string line;
                while ((line = fileRead.ReadLine()) != null)
                {
                    // process the line
                    Console.WriteLine(line);
                }
            }
            catch
            {
                Console.WriteLine("there is somethong wrong when read");
            }
        }
    }
}
