using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MikhailovNS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Никитос";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Никитос", res);
        }
    }
}  
