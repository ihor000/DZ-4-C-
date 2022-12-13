int n = Convert.ToInt32(Console.ReadLine());
     int sum = 0;
        for (int i = 1; i <= n; ++i)
        {
            if (n % i == 0) sum += i;
        }
        Console.WriteLine(sum);