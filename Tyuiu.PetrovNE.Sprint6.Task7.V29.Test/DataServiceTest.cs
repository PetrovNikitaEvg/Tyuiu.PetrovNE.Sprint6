using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PetrovNE.Sprint6.Task7.V29.Lib;

namespace Tyuiu.PetrovNE.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint6\Tyuiu.PetrovNE.Sprint6.Task7.V29\bin\Debug\InPutFileTask7V29.csv";
            int[,] array = new int[10, 10] { { 5, -10, 2, -4, 13, -8, -7, 20, 2, -20},
                                          {- 3, -12, 5, 14, 14, 9, -5, -3, -12, 11},
                                          {- 15, -6, 2, 18, -4, 13, -14, 6, -20, 12},
                                          { 1, -9, -9, -10, -6, -4, -11, 9, 0, 1},
                                          {- 3, -19, 20, 17, -12, 0, -9, 19, -5, -15},
                                          {- 15, -1, 3, -18, 7, -12, 4, -1, -8, -1},
                                          {- 10, -4, -8, 19, 18, 0, -1, 15, -10, -15},
                                          {  7, -17, -1, 3, -10, -8, 4, 16, -8, 8},
                                          {  18, 17, -20, 1, 2, 9, 13, -9, 7, -7},
                                          { 15, 13, -17, 20, -6, -18, 15, 14, 8, -5}};

            int[,] wait = new int[10, 10] { { 5, -10, 2, -4, 13, -8, -7, 20, 2, -20},
                                          {- 3, -12, 5, 14, 14, 9, -5, -3, -12, 11},
                                          {- 15, -6, 2, 18, -4, 13, -14, 6, -20, 12},
                                          { 1, -9, -9, -10, -6, -4, -11, 9, 0, 1},
                                          {99, -19, 20, 17, -12, 99, -9, 19, 99, -15},
                                          {- 15, -1, 3, -18, 7, -12, 4, -1, -8, -1},
                                          {- 10, -4, -8, 19, 18, 0, -1, 15, -10, -15},
                                          {  7, -17, -1, 3, -10, -8, 4, 16, -8, 8},
                                          {  18, 17, -20, 1, 2, 9, 13, -9, 7, -7},
                                          { 15, 13, -17, 20, -6, -18, 15, 14, 8, -5}};

            int[,] res = ds.GetMatrix(array);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
