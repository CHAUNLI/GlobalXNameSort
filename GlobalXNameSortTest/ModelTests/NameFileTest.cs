using System;
using NUnit.Framework;
using GlobalXNameSort.Model;
using System.Collections.Generic;
using System.IO;

namespace GlobalXNameSortTest.ModelTests
{
    [TestFixture()]
    public class NameFileTest
    {
        
        [Test]
        public void VerifyItCanReadFileCorrectly()
        {
           
            NameFile newFile = new NameFile("TestResource/name_read_test.txt");
            newFile.ReadFile();
            List<string> actualResult = new List<string>();
            actualResult = newFile.content;

            List<string> expectResult = new List<string>(new string[] 
            { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer","Shelby Nathan Yoder","Marin Alvarez" });

            Assert.AreEqual(expectResult, actualResult);
        }

        [Test]
        public void VerifyItCanWriteToFileSuccessfully()
        {
            String testPath = "TestResource/name_write_test.txt";
            List<string> testContent = new List<string>(new string[]
           { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer","Shelby Nathan Yoder","Marin Alvarez" });

            NameFile newFile = new NameFile(testPath,testContent);
            newFile.WriteFileTo(testPath);
            Assert.AreEqual(false,File.Exists(testPath));
        }
    }
}
