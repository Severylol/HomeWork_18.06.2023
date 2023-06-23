// Console.Clear();
//         int M = 1; // Значение M
//         int N = 15; // Значение N

//         int sum = CalculateSum(M, N);

//         Console.WriteLine("Сумма натуральных элементов: " + sum);

//     static int CalculateSum(int M, int N)
//     {
//         int sum = 0;

//         for (int i = M; i <= N; i++)
//         {
//             sum += i;
//         }

//         return sum;
//     }

Console.Clear();
        int M = 4; // Значение M
        int N = 8; // Значение N

        int sum = CalculateSum(M, N);

        Console.WriteLine("Сумма натуральных элементов: " + sum);

    static int CalculateSum(int M, int N)
    {
        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        return sum;
    }