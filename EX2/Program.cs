    const int N = 4;

    int i = 0, j = 0, k = N - 1;
    int tmp;

    int[,] array = new int[N, N]
    {
                {2, 3, 6, 7},
                {3, 3, 12, 9},
                {6, 6, 34, 12},
                {2, 2, 3, 7},
    };

    for (int z = 0; z < N; z++)
    {
        for (int l = 0; l < N; l++)
        {
            Console.Write("{0} ", array[z, l]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    while (i < 4)
    {
        tmp = array[i, j];
        array[i, j] = array[i, k];
        array[i, k] = tmp;
        i++; j++; k--;
    }

    for (int z = 0; z < N; z++)
    {
        for (int l = 0; l < N; l++)
        {
            Console.Write("{0} ", array[z, l]);
        }
        Console.WriteLine();
    }