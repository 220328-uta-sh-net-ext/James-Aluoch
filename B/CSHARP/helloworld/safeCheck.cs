using System;

public class Test
{
    public static int safeCheck(int N,int[] A)
    {
        //this is default OUTPUT. You can change it.
        int result = -404;
        
        //write your Logic here:


        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        
        int[] A = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            A[i] = Convert.ToInt32(tokens[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(safeCheck(N,A));
    }
}