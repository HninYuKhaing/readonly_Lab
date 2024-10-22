using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_Lab
{
    internal class readonlyPrimitive
    {
        public readonly int MaxValue;
        public readonly string Greeting = "Hello, World!";
        public readonlyPrimitive(int maxValue, string greeting)
        {
            MaxValue = maxValue; // Can be initialized in the constructor
            Greeting = greeting;
        }

        public void UpdateValue()
        {
            //MaxValue = 20;  // ❌ Error CS0191: Cannot assign to readonly field outside of constructor or variable initializer
            //Greeting = "Hi"; // ❌ Error CS0191: Cannot assign to readonly field outside of constructor or variable initializer
        }
    }
}
