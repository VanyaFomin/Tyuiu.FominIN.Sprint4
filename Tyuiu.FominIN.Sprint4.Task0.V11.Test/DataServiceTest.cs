using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint4.Task0.V11.Lib;

namespace Tyuiu.FominIN.Sprint4.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            DataService ds = new DataService();
            int result = ds.GetMultOddArrEl(array);
        }
    }
}
