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
        public void Given_FullNameString_When_ItHasNoLastNameOrFirstName_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet");

            Assert.AreEqual(false, fullName.isValid());
        }
        [Test]
        public void Given_FullNameString_When_ItContainsNumber_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet123");

            Assert.AreEqual(false, fullName.isValid());
        }
        [Test]
        public void Given_FullNameString_When_ItContainsSpecialCharts_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet123");

            Assert.AreEqual(false, fullName.isValid());
        }


        [Test]
        public void Given_FullNameString_When_ItContainsLessThanTwoParts_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet");

            Assert.AreEqual(false, fullName.isValid());
        }



        //CompareTo
        [Test]
        public void Given_TwoFullNames_When_FirstOneIsGreater_Then_CompareToReturn1()
        {
           
            FullName fullName = new FullName("Janet Parsons");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 1;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }
        [Test]
        public void Given_TwoFullNames_When_LastOneIsGreater_Then_CompareToReturnLess0()
        {
          
            FullName fullName = new FullName("Vaughn Lewis");
            FullName anotherFullName = new FullName("Janet Parsons");

            int expectResult = -1;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }
        [Test]
        public void Given_TwoFullNames_When_TheyAreEqual_Then_CompareToReturn0()
        {

            FullName fullName = new FullName("Vaughn Lewis");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 0;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }


    }
}
