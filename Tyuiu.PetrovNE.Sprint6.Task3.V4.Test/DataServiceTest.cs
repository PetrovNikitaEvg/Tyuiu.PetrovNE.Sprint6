using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint6.Task3.V4.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] Array = new int[5, 5] { { -14,  -7,  18,  12, -20 }, {   -2, -15, -19, -19,  -3 },
                {  -18,  -5, -10,  14, -17 }, {   -1,   2, -10,   0,  11 }, {   6, -18,   0,  19,  16, } };

            int[,] wait = new int[5, 5] { { -14,  -7,  18,  12, -20 }, {   0, -15, -19, -19,  -3 },
                {  -18,  -5, -10,  14, -17 }, {   -1,   2, -10,   0,  11 }, {   6, -18,   0,  19,  16, } };
            int[,] res = ds.Calculate(Array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
