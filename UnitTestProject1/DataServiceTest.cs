using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PlatonovaPE.Sprint0.Task2.V0.Libb;
namespace UnitTestProject1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {
            // Област создания методов тестирования, методов из библиотеки
            var name = "Полина";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Полина", res);
        }
    }
}
