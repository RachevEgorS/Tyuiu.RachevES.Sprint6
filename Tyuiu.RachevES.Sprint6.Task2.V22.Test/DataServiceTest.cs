using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint6.Task2.V22.Lib;
namespace Tyuiu.RachevES.Sprint6.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] WaitArray;
            WaitArray = new double[len];
            WaitArray[0] = 7.76;
            WaitArray[1] = 7.36;
            WaitArray[2] = 7.26;
            WaitArray[3] = 7.90;
            WaitArray[4] = 15.88;
            WaitArray[5] = 2.00;
            WaitArray[6] = 4.35;
            WaitArray[7] = 5.63;
            WaitArray[8] = 6.49;
            WaitArray[9] = 6.49;
            WaitArray[10] = 6.32;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(WaitArray, res);
        }
    }
}
