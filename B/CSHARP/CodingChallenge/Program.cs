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
        Console.WriteLine(Test.safeCheck(N,A));
/*
int i;
    int b = 8, a = 32;
    for (i = 0; i <= 10; i++)
    {
        if ((a / b * 2) == 2)
            Console.Write(i + " ");
        else if (i != 4)
            Console.Write(i + " ");
        else
            break;
    }

*/