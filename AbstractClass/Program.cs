namespace AbstractClass
{
    internal class Program
    {
        static void Main ()
        {
            ParentClass p = new ChildClass("Ram", 23);
            p.show();
            p.MyMethod();

          ChildClass c = new ChildClass("Sita", 21);
            c.show();
            c.MyMethod();
            c.ChildMethod();
        }   
    }
}