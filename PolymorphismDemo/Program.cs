namespace PolymorphismDemo
{
    class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Id={0}, Name={1}",Id,Name);
        }
    }
    class Child:Parent
    {
        public int Age { get; set; }
        override public void Show()
        {
            Console.WriteLine("Id={0}, Name={1}, Age={2}", Id, Name,Age);
        }
    }
    class GrandChild : Child
    {
        public int Height { get; set; }
        override public void Show()
        {
            Console.WriteLine("Id={0}, Name={1}, Age={2}, Height={3}", Id, Name, Age,Height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p=new Parent();
            p.Id = 1;
            p.Name = "test";
            p.Show();

            p = new Child();
            p.Id = 2;
            p.Name = "child";
            p.Show();

            p = new GrandChild();
            p.Id = 3;
            p.Name= "grand child";
            p.Show();
        }
    }
}