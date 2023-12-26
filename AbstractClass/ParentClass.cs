using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal abstract class ParentClass
    {
    int age;
    string name;
        
        public ParentClass(string _name , int _age ) {
            name = _name;
            age = _age;
        }
        public void show()
        {
            Console.WriteLine("Name={0}, Age={1}", name,age);
        }
    public abstract void MyMethod();
}
  

