using System;
using Acc.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cale.BLL.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calc_檢查加法運算()
        {


            // arrange
            ICalc c = new Cal();
            // 期望值
            int expected = 5; //2+3=5

            // act
            // 實際結果
            int actual = c.Add(2, 3);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查加法運算_負數加負數()
        {


            // arrange
            ICalc c = new Cal();
            // 期望值
            int expected = -5; //-2-3=-5

            // act
            // 實際結果
            int actual = c.Add(-2, -3);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查減法運算()
        {
            ICalc c = new Cal();

            // arrange
            //Cal c = new Cal();  //注入測試目標
            // 期望值
            int expected = -1; //2-3=-1

            // act
            // 實際結果
            int actual = c.Sub(2, 3);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查乘法運算()
        {
            ICalc c = new Cal();

            // arrange
            //Cal c = new Cal();  //注入測試目標
            // 期望值
            int expected = 6; //2*3=6

            // act
            // 實際結果
            int actual = c.Mul(2, 3);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查乘法運算_乘以零()
        {
            ICalc c = new Cal();

            // arrange
            //Cal c = new Cal();  //注入測試目標
            // 期望值
            int expected = 0; //2*0=0

            // act
            // 實際結果
            int actual = c.Mul(2, 0);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查除法運算()
        {
            ICalc c = new Cal();

            // arrange
            //Cal c = new Cal();  //注入測試目標
            // 期望值
            int expected = 5; //10/2=5

            // act
            // 實際結果
            int actual = c.Div(10, 2);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Calc_檢查除法運算_除以零()
        {
            ICalc c = new Cal();

            // arrange
            //Cal c = new Cal();  //注入測試目標
            // 期望值
            int expected = 0; //10/0=0

            // act
            // 實際結果
            int actual = c.Div(10, 0);

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);

        }
    }
}
