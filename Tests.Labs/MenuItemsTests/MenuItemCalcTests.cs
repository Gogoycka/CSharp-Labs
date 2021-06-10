using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Labs;
using CSharp_Labs.MenuItems;

namespace Tests.Labs.MenuItemsTests
{
    class MenuItemCalcTests
    {
        [TestCase(5, 5, 5, ExpectedResult = 26)]
        [TestCase(34, 16, 17, ExpectedResult = 258)]
        public double MenuItemCalc_Test(double value1, double value2, double value3)
        {
            return (double)MenuItemCalc.Calculate(value1, value2, value3);
        }
    }
}
