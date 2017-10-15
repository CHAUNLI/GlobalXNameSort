using NUnit.Framework;
using System;
using GlobalXNameSort.Model;
using System.Collections.Generic;
namespace GlobalXNameSortTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Given_FullNameList_When_NoException_Then_GetSortedList()
        {
            List<FullName> input = new List<FullName>();

            input.Add(new FullName("Janet Parsons"));
            input.Add(new FullName("Vaughn Lewis"));
            input.Add(new FullName("Adonis Julius Archer"));
            input.Add(new FullName("Shelby Nathan Yoder"));
            input.Add(new FullName("Marin Alvarez"));
            input.Add(new FullName("London Lindsey"));
            input.Add(new FullName("Marin Alvarez"));
            input.Add(new FullName("Beau Tristan Bentley"));
            input.Add(new FullName("Leo Gardner"));
            input.Add(new FullName("Hunter Uriah Mathew Clarke"));
            input.Add(new FullName("Mikayla Lopez"));
            input.Add(new FullName("Frankie Conner Ritter"));

            input.Sort();

            foreach (FullName name in input)
            {
                if (name.isValid()) 
                { 
                    Console.WriteLine(name.ToString());
                }
            }
            List<FullName> expectResult = new List<FullName>();
            expectResult.Add(new FullName("Marin Alvarez")); 
            expectResult.Add(new FullName("Marin Alvarez")); 
            expectResult.Add(new FullName("Beau Tristan Bentley")); 
            expectResult.Add(new FullName("Hunter Uriah Mathew Clarke")); 
            expectResult.Add(new FullName("Leo Gardner")); 
            expectResult.Add(new FullName("Vaughn Lewis")); 
            expectResult.Add(new FullName("London Lindsey")); 
            expectResult.Add(new FullName("Mikayla Lopez")); 
            expectResult.Add(new FullName("Janet Parsons")); 
            expectResult.Add(new FullName("Frankie Conner Ritter")); 
            expectResult.Add(new FullName("Shelby Nathan Yoder")); 
            expectResult.Add(new FullName("Adonis Julius Archer")); 

            Assert.AreEqual(expectResult[0].ToString(), input[0].ToString());
            Assert.AreEqual(expectResult[4].ToString(), input[4].ToString());
            Assert.AreEqual(expectResult[6].ToString(), input[6].ToString());
            Assert.AreEqual(expectResult[7].ToString(), input[7].ToString());
            
        }

    }
}
