using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Labs;
using CSharp_Labs.MenuItems;

namespace Tests.Labs.MenuItemsTests
{
    class MenuItemRecursionTests
    {
        [TestCase("06.03.2020", "25.03.2020", "15.03.2020", "20.03.2020", ExpectedResult = 6)]
        [TestCase("11.05.2021", "26.06.2020", "20.07.2020", "30.07.2020", ExpectedResult = 0)]
        [TestCase("12.07.2019", "30.07.2019", "22.07.2019", "22.07.2021", ExpectedResult = 9)]
        [TestCase("01.01.2000", "02.02.2000", "01.01.2000", "15.01.2021", ExpectedResult = 33)]
        public int MenuItemRecursionDate_IntervalDaysInSegmentsTest(string First, string Second, string Third, string Fourth)
        {
            List<DateTime> FirstSegment = new List<DateTime>();
            List<DateTime> SecondSegment = new List<DateTime>();
            DateTime.TryParseExact(First, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime tmp1);
            DateTime.TryParseExact(Second, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime tmp2);
            DateTime.TryParseExact(Third, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime tmp3);
            DateTime.TryParseExact(Fourth, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime tmp4);

            FirstSegment.Add(tmp1);
            FirstSegment.Add(tmp2);
            SecondSegment.Add(tmp3);
            SecondSegment.Add(tmp4);

            return MenuItemRecursion.IntervalDaysInSegments(FirstSegment, SecondSegment);
        }
    }
}
