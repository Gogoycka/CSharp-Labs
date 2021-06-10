using System;
using CSharp_Labs.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title { get { return "Calc: X/Z+Y^2"; } }


        public override void Execute(IOUtils IOClass)
        {
            double x, y, z;
            x = IOClass.SafeReadDouble("X", "Enter X:", true);
            y = IOClass.SafeReadDouble("Y", "Enter Y", true);
            z = IOClass.SafeReadDouble("Z", "Enter Z", false);

            IOUtils.WriteString(string.Format("X/Z+Y^2 = {0:F3}{1}", Calculate(x, y, z), Environment.NewLine));
        }

        public static double Calculate(double x, double y, double z)
        {
            return x / z + y * y;
        }
    }
}
