using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs.MenuItems
{
    public abstract class MenuItemCore
    {
        public abstract string Title { get; }

        public abstract void Execute(IOUtils IOClass);
    }
}
