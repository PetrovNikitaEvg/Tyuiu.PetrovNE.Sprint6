using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task1.V18.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 70.14;
            valueWaitArray[1] = 55.21;
            valueWaitArray[2] = 41.05;
            valueWaitArray[3] = 27.96;
            valueWaitArray[4] = 15.48;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = -13.06;
            valueWaitArray[7] = -28.16;
            valueWaitArray[8] = -42.96;
            valueWaitArray[9] = -56.77;
            valueWaitArray[10] = -69.83;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
