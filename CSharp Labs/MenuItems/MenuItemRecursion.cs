using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs.MenuItems
{
    public class MenuItemRecursion : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            IOUtils.WriteString("Enter two time Segments.");
            IOUtils.WriteString("First Segment: ");
            List<DateTime> aFirstSegment = IOUtils.ReadDataSegment();
            IOUtils.WriteString("Second Segment: ");
            List<DateTime> aSecondSegment = IOUtils.ReadDataSegment();

            int iDays = IntervalDaysInSegments(aFirstSegment, aSecondSegment);
            if (iDays > 4000)
            {
                IOUtils.WriteString("Number of days is greater than 4000 and can't be calculated in the allotted time");
            }
            else
            {

                IOUtils.WriteString(string.Format("Is {0} prime number:", iDays));
                IsPrimeNumber(iDays);
            }
        }

        private static int IntervalDaysInSegments(List<DateTime> FirstSegment, List<DateTime> SecondSegment)
        {
            int iDays = 0;

            if (FirstSegment[0] <= SecondSegment[0] &&
                SecondSegment[0] <= FirstSegment[1] &&
                FirstSegment[1] <= SecondSegment[1])
            {
                iDays = Convert.ToInt32((FirstSegment[1] - SecondSegment[0]).TotalDays) + 1;
            }
            else if (SecondSegment[0] <= FirstSegment[0] &&
                     FirstSegment[0] <= SecondSegment[1] &&
                     SecondSegment[1] <= FirstSegment[1])
            {
                iDays = Convert.ToInt32((SecondSegment[1] - FirstSegment[0]).TotalDays) + 1;
            }
            else if (FirstSegment[0] <= SecondSegment[0] &&
                     SecondSegment[0] <= SecondSegment[1] &&
                     SecondSegment[1] <= FirstSegment[1])
            {
                iDays = Convert.ToInt32((SecondSegment[1] - SecondSegment[0]).TotalDays) + 1;
            }
            else if (SecondSegment[0] <= FirstSegment[0] &&
                     FirstSegment[0] <= FirstSegment[1] &&
                     FirstSegment[1] <= SecondSegment[1])
            {
                iDays = Convert.ToInt32((FirstSegment[1] - FirstSegment[0]).TotalDays) + 1;
            }

            return iDays;
        }

        private static void IsPrimeNumber(int iNumber)
        {
            bool result = true;
            if (iNumber > 1)
            {
                for (int i = 2; i < iNumber; i++)
                {
                    if (iNumber % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            if (result == true)
            {
                IOUtils.WriteString("YES");
            }
            else { IOUtils.WriteString("NO"); }
        }
    }
}

