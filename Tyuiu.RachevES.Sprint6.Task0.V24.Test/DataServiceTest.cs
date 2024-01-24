using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint6.Task0.V24.Lib;
namespace Tyuiu.RachevES.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.Calculate(x);
            var wait = 1024;
            Assert.AreEqual(wait, res);
            

        }
    }
}
