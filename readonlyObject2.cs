using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_Lab.readonlyObject2
{
    internal class readonlyObject2
    {
        public readonly Person person = new Person("John", 30);

        public void ModifyObject()
        {
            //person.Name = "Jane"; // ❌ Error: Cannot modify readonly property
            //person = new Person("Jane", 35); // ❌ Error: Cannot reassign readonly object reference
        }
    }
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
