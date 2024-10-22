using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_Lab.readonlyObject1
{
    internal class readonlyObject1
    {

        public readonly Person person = new Person();

        public void ModifyObject()
        {
            // Modifying properties of the object is allowed:
            person.Name = "Jane";  // ✔️ Allowed: Modifying the object's property
            person.Age = 35;       // ✔️ Allowed: Modifying the object's property

            // person = new Person(); // ❌ Error: Cannot reassign readonly object reference
        }
    }
    public class Person
    {
        public string Name { get; set; } = "John";
        public int Age { get; set; } = 30;
    }

}
