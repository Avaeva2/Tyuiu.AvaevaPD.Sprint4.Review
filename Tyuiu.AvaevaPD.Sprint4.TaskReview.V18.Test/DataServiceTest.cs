using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint4.TaskReview.V18.Lib;
namespace Tyuiu.AvaevaPD.Sprint4.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int rows = 5;
            int cols = 3;
            int[,] mtrx = new int[rows, cols];
            string str = "145258749635789";
            int res = ds.Calculate(rows, cols, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}
