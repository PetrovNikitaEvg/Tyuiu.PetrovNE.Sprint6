using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task6.V23.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint6\Tyuiu.PetrovNE.Sprint6.Task6.V23\bin\Debug\InPutFileTask6V23.txt";
            DataService ds = new DataService();

            string wait = "iKDOjtfsPmw JnYbSEpE SZSxXxQbANuka EzAqSCaJNt ";
            string res = ds.CollectTextFromFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}
