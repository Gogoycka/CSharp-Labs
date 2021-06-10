using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        public override string Title { get { return "Hello world!"; } }

        public override void Execute(IOUtils IOClass)
        {
            IOUtils.WriteString(string.Format("Hello world! {0}", Environment.NewLine));
        }
    }
}
