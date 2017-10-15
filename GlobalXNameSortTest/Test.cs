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
            string[] expectResult = new string[] {
                "Marin Alvarez",
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };
            Assert.AreEqual(expectResult[0], input[0].ToString());
            Assert.AreEqual(expectResult[4], input[4].ToString());
            Assert.AreEqual(expectResult[6], input[6].ToString());
            Assert.AreEqual(expectResult[7], input[7].ToString());
            
        }

    }
}
