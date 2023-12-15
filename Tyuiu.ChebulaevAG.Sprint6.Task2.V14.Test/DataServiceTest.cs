using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint6.Task2.V14.Lib;

namespace Tyuiu.ChebulaevAG.Sprint6.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidChecked()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 19.81;
            valueWaitArray[1] = 16.79;
            valueWaitArray[2] = 13.87;
            valueWaitArray[3] = 10.98;
            valueWaitArray[4] = 7.94;
            valueWaitArray[5] = 3.00;
            valueWaitArray[6] = 3.23;
            valueWaitArray[7] = -0.45;
            valueWaitArray[8] = -3.79;
            valueWaitArray[9] = -6.97;
            valueWaitArray[10] = -10.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
