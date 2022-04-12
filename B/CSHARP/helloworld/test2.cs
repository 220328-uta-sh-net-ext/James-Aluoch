static void Main(string[] args)
{
    int i;
    for (i = 0; i < 5; i++)
    {
        int j = 0;
        j += i;
        Console.WriteLine(j);
    }
    Console.WriteLine(i * j);
}