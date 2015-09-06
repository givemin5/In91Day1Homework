using Microsoft.VisualStudio.TestTools.UnitTesting;
using In91Day1Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In91Day1Homework.Tests
{
    [TestClass()]
    public class ProductsTests
    {
        [TestMethod()]
        public void GetSum_Test_Group_3_Cost()
        {
            //Arrange
            Products target = new Products();

            List<int> expected = new List<int>() {6,15,24,21 };

            //Act
            List<int> actual = target.GetSum(3, "Cost");

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetSum_Test_Group_4_Revenue()
        {
            //Arrange
            Products target = new Products();

            List<int> expected = new List<int>() { 50, 66, 60 };

            //Act
            List<int> actual = target.GetSum(4, "Revenue");

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}