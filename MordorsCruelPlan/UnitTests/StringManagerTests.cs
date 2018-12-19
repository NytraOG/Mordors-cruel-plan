using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{   
    [TestClass]
    public class StringManagerTests
    {
        [TestMethod]
        public void IchGuckeObDerManagerStringsTeilt()
        {
            //Arrange
            var foodStringInput = "Banane Apfel Huhn";
            const string outputExpected1 = "Banane";
            const string outputExpected2 = "Apfel";
            const string outputExpected3 = "Huhn";

            //Act
            var stringManager = new StringManager();
            var testList = stringManager.StringTeiler(foodStringInput);

            //Assert
            Assert.AreEqual(outputExpected1, testList[0]);
            Assert.AreEqual(outputExpected2, testList[1]);
            Assert.AreEqual(outputExpected3, testList[2]);
        }
    }
}
