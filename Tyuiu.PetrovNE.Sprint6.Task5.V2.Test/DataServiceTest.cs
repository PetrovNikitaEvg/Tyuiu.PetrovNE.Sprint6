using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task5.V2.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint6\Tyuiu.PetrovNE.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";
            double[] wait = { -1, -2, -3, -5, -6, -7, -8, -9, -10 };
            double[ ] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
