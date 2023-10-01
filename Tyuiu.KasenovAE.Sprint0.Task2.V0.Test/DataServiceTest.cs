using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KasenovAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Айдар";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Айдар", res);
        }
    }
}
