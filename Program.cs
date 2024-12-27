// 1st task
// int sum = 0;
//         int number = 1;

//         while (number <= 1000)
//         {
//             if (number % 2 != 0) // Check if the number is odd
//             {
//                 sum += number;
//             }
//             number++;
//         }

//         Console.WriteLine($"1 dan 1000 gacha bo'lgan toq sonlar yig'indisi: {sum}");

//2nd task



       
        // int[] numbers = { 15, 8, 4, 9, 3, 12, 7 };

        
        // int min = numbers[0];
        // int max = numbers[0];

        
        // for (int i = 1; i < numbers.Length; i++)
        // {
        //     if (numbers[i] < min)
        //     {
        //         min = numbers[i];
        //     }
        //     else if (numbers[i] > max)
        //     {
        //         max = numbers[i];
        //     }
        // }

        
        // Console.WriteLine($"Minimum number: {min}, Maximum number: {max}");
        // Console.WriteLine($"Ko'paytma: {min * max}");


// 3rd task

        Console.Write("Butun sonni kiriting (x): ");
        if (int.TryParse(Console.ReadLine(), out int x) && x >= 0)
        {
            Console.WriteLine($"{x}! = {CalculateFactorial(x)}");
        }
        else
        {
            Console.WriteLine("Iltimos, musbat butun son kiriting.");
        }

          static long CalculateFactorial(int num)
    {
        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }