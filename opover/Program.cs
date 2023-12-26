class MyNumber
{
    double i, r;
    public MyNumber(double _i, double _r)
    {
        r = _r;
        i = _i;
    }

    public void Show()
    {
        Console.WriteLine(r + "+" + i + "i");
    }
    public MyNumber operator +(MyNumber n1, MyNumber n2)
    {
        return new MyNumber(n1.i + n2.i, n1.r + n2.r);
    }


}