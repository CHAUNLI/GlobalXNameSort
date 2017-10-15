using System;
using NUnit.Framework;
using GlobalXNameSort.Model;
using System.Collections.Generic;
using System.IO;
using GlobalXNameSort;
namespace GlobalXNameSortTest.ModelTests
{
    [TestFixture()]
    public class FullNameTest
    {
        //FullName Init tests
        [Test]
        public void Given_FullNameString_When_ItHasLongFirstName_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet Hunter Uriah Mathew Mathew");
            FullName fullNameStartFromSpace = new FullName("   Janet");
            FullName fullNameEndWithSpace = new FullName("Janet    ");

            Assert.AreEqual(false, fullName.isValid());
            Assert.AreEqual(false, fullNameStartFromSpace.isValid());
            Assert.AreEqual(false, fullNameEndWithSpace.isValid());
        }
        [Test]
        public void Given_FullNameString_When_ItHasValidName_Then_validFullName()
        {

            FullName fullName3 = new FullName("Janet Hunter Uriah");
            FullName fullName2 = new FullName(" Mathew Mathew");
            FullName fullName4 = new FullName("Janet Janet Hunter Uriah");

            Assert.AreEqual(true, fullName3.isValid());
            Assert.AreEqual(true, fullName2.isValid());
            Assert.AreEqual(true, fullName4.isValid());
        }
        [Test]
        public void Given_FullNameString_When_ItHasNoLastNameOrFirstName_Then_InvalidFullName()
        {

            FullName fullName = new FullName("Janet");
            FullName fullNameStartFromSpace = new FullName("   Janet");
            FullName fullNameEndWithSpace= new FullName("Janet    ");

            Assert.AreEqual(false, fullName.isValid());
            Assert.AreEqual(false, fullNameStartFromSpace.isValid());
            Assert.AreEqual(false, fullNameEndWithSpace.isValid());
        }

        [Test]
        public void Given_FullNameString_When_ItIsSpace_Then_InvalidFullName()
        {

            FullName fullName = new FullName(" ");

            Assert.AreEqual(false, fullName.isValid());
            Assert.AreEqual(Constants.nullFullNamePlaceHolder, fullName.ToString());
        }


        //CompareTo method
        [Test]
        public void Given_TwoFullNames_When_FirstOneIsInValid_Then_CompareToShouldReturn1()
        {

            FullName fullName = new FullName("ARitter");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 1;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }
        public void Given_TwoFullNames_When_SecondOneIsInValid_Then_CompareToShouldReturn1()
        {

            FullName fullName = new FullName("ARitter");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = -1;
            int actualResult = anotherFullName.CompareTo(fullName);

            Assert.AreEqual(expectResult, actualResult);
        }

        [Test]
        public void Given_TwoFullNames_When_FirstOneIsGreater_Then_CompareToShouldReturn1()
        {
           
            FullName fullName = new FullName("Janet Parsons");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 1;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }
        [Test]
        public void Given_TwoFullNames_When_LastOneIsGreater_Then_CompareToShouldReturnLess0()
        {
          
            FullName fullName = new FullName("Vaughn Lewis");
            FullName anotherFullName = new FullName("Janet Parsons");

            int expectResult = -1;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }
        [Test]
        public void Given_TwoFullNames_When_TheyAreEqual_Then_CompareToShouldReturn0()
        {

            FullName fullName = new FullName("Vaughn Lewis");
            FullName anotherFullName = new FullName("Vaughn Lewis");

            int expectResult = 0;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }

        [Test]
        public void Given_TwoFullNames_When_TheyAreInValid_Then_CompareToShouldReturn0()
        {

            FullName fullName = new FullName("Vaughn");
            FullName anotherFullName = new FullName(" ");

            int expectResult = 0;
            int actualResult = fullName.CompareTo(anotherFullName);

            Assert.AreEqual(expectResult, actualResult);
        }


    }
}
