class D
{
    public int Mem1;
}

class Program
{
    static void Main()
    {
        D d1 = new D();
        D d2 = new D();
        d1.Mem1 = 1;d2.Mem1 = 2;
        Console.WriteLine(d1.Mem1);
        Console.WriteLine(d2.Mem1);
    }
}