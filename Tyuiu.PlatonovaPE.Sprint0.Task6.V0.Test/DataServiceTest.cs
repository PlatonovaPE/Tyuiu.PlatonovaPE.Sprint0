﻿using System;

using Tyuiu.PlatonovaPE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.PlatonovaPE.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtrationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtrationArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
