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
           
            FullName fullName = new FullName("Janet Parsons");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 1;
            int actualResult = fullName.CompareTo(anotherFullName);

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
            Assert.AreEqual(true,File.Exists(testPath));
        }
    }
}
