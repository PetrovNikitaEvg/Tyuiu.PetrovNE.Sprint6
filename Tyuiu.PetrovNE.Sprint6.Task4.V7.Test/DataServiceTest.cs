using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task4.V7.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task4.V7.Test
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

            valueWaitArray[0] = 15.19;
            valueWaitArray[1] = 11.67;
            valueWaitArray[2] = 9;
            valueWaitArray[3] = 0;
            valueWaitArray[4] = 4.08;
            valueWaitArray[5] = 1.5;
            valueWaitArray[6] = -2.28;
            valueWaitArray[7] = -6.52;
            valueWaitArray[8] = -10.19;
            valueWaitArray[9] = -12.76;
            valueWaitArray[10] = -14.68;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
