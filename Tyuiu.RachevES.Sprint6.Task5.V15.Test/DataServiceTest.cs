using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint6.Task5.V15.Lib;
using System.IO;
namespace Tyuiu.RachevES.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\buratino\source\repos\Tyuiu.RachevES.Sprint6\Tyuiu.RachevES.Sprint6.Task5.V15\bin\Debug\InPutFileTask5V15.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
