using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint6.Task1.V21.Lib;
namespace Tyuiu.RachevES.Sprint6.Task1.V21.Test
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
            WaitArray[0] = 20.36;
            WaitArray[1] = 15.42;
            WaitArray[2] = 10.99;
            WaitArray[3] = 7.43;
            WaitArray[4] = 4.33;
            WaitArray[5] = 1;
            WaitArray[6] = 0;
            WaitArray[7] = -8.87;
            WaitArray[8] = -13.03;
            WaitArray[9] = -16.53;
            WaitArray[10] = -19.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(WaitArray, res);
        }
    }
}
