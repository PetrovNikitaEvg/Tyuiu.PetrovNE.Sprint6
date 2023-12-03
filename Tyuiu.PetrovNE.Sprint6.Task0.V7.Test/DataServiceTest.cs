using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task0.V7.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3), wait =0.211;
            Assert.AreEqual(res, wait);
        }
    }
}
