// Console.Clear();
//         int m = 4;
//         int n = 8;
//         int sum = SumNaturalNumbers(m, n);
//         Console.WriteLine("Сумма натур. чисел от " + m + " до " + n + " = " + sum);

//     static int SumNaturalNumbers(int m, int n)
//     {
//         if (m > n)
//         {
//             return 0;
//         }
//         else
//         {
//             return m + SumNaturalNumbers(m + 1, n);
//         }
//     }

Console.Clear();
        int m = 1;
        int n = 15;
        int sum = SumNaturalNumbers(m, n);
        Console.WriteLine("Сумма натур. чисел от " + m + " до " + n + " = " + sum);

    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else
        {
            return m + SumNaturalNumbers(m + 1, n);
        }
    }