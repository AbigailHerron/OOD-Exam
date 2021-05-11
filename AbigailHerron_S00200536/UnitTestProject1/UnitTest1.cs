/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/05/21
 GitHub Repository: https://github.com/AbigailHerron/OOD-Exam
 
 Description: Is a test class made specifically to test the methods of the Game class
                 contained in the AbigailHerron_S00200536 project
 Methods: Test_DecreasePrice
 ##########################################################################################################################*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AbigailHerron_S00200536;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_DecreasePrice()
        {
            //ARRANGE
            Game g1 = new Game();
            g1.Price = 100m;
            decimal expectedPrice = 75m;

            //ACT
            g1.DecreasePrice(0.25);

            //ASSERT
            Assert.AreEqual(expectedPrice, g1.Price);

        }// end Test_DecreasePrice()
    }// end Test class
}// end namespace
