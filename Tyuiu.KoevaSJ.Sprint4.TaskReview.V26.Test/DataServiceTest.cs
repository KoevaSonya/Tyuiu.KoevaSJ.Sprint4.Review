using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint4.TaskReview.V26.Lib;

namespace Tyuiu.KoevaSJ.Sprint4.TaskReview.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "351268459614723";

            double res = ds.Calculate(n, m, str);
            double wait = 18432;

            Assert.AreEqual(wait, res);
        }
    }
}

/// 351
/// 268
/// 459
/// 614
/// 723