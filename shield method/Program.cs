class Library
{
    public string Name { get; set; }
    public string Location { get; set; }

    public Library(string name, string location)
    {
        Name = name;
        Location = location;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Library: {Name}, Location: {Location}");
    }
}

class Book : Library
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string name, string location, string title, string author)
        : base(name, location)
    {
        Title = title;
        Author = author;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}