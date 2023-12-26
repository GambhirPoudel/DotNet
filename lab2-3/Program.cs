class indexer
{
    a[] arr = new a[50];
    public a this[int i]
    {
        get { return arr[]; }
        set { arr[]= value; }
    }

}

class program
{
    static void main()
    {
        var coll = new Coll<string>();
        coll[0] = "tatakae";
        Console.WriteLine(coll[0]);
    }
}