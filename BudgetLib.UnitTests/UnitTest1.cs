using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace BudgetLib.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 日期區間無Budget()
        {
            var budgetRepository = Substitute.For<IBudgetRepository>();
            var accounting = new Accounting(budgetRepository);
            var start = new DateTime(2018, 6, 1);
            var end = new DateTime(2018, 6, 1);
            var totalAmount = accounting.TotalAmount(start, end);
            Assert.AreEqual(0m, totalAmount);
        }
    }
}