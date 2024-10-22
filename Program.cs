using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //readonlyPrimitive readonlyPrimitive = new readonlyPrimitive(100, "Hi");
            //readonlyPrimitive.MaxValue = 20;  // ❌ Error CS0191: Cannot assign to readonly field outside of constructor or variable initializer

            readonlyArray readonlyArray = new readonlyArray();
            readonlyArray.ModifyArray();
        }

    }
}
