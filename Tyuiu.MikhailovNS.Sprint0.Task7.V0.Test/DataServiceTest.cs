using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MikhailovNS.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] sums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] sums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] sums3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(sums1, sums2);
            CollectionAssert.AreEqual(sums3, res);
        }
    }
}
