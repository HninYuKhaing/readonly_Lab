using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_Lab
{
    internal class readonlyArray
    {
        public readonly int[] numbers = { 1, 2, 3, 4 };

        public void ModifyArray()
        {
            // Modifying the elements is allowed:
            numbers[0] = 10;  // ✔️ Allowed: Modifying array elements
            numbers[1] = 20;  // ✔️ Allowed: Modifying array elements

            //numbers = new int[] { 5, 6, 7 }; // ❌ Error: Cannot reassign readonly array
        }
    }
}
