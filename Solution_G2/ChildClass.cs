using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_G2
{
    public class ChildClass: ParentClass
    {
        public int childInt = 67;

        public override void TestMethod() 
        {
            Console.WriteLine("Child class");
        }
    }
}
