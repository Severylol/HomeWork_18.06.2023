// Console.Clear();
//         int N = 5; // Значение N

//         Console.WriteLine("Результат: " + PrintNumbers(N));

//     static string PrintNumbers(int N)
//     {
//         if (N == 1)
//         {
//             return "1";
//         }
//         else
//         {
//             return N + ", " + PrintNumbers(N - 1);
//         }
//     }

Console.Clear();
        int N = 8; // Значение N

        Console.WriteLine("Результат: " + PrintNumbers(N));

    static string PrintNumbers(int N)
    {
        if (N == 1)
        {
            return "1";
        }
        else
        {
            return N + ", " + PrintNumbers(N - 1);
        }
    }