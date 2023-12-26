using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class ChildClass:ParentClass
    {
        public ChildClass(string name, int age) : base(name, age) { 

        }
        public override void MyMethod()
        {
            Console.WriteLine("MyMethod in Child");
        }

        public void ChildMethod()
        {
            Console.WriteLine("Child only method");
        }
    }
}
