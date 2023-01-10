class Program
{
    // Метод нахождения простого числа
    static bool IsPrime(int x)
    {
        for (int i = 2; i < x; i++)
            if (x % i == 0)
                return false;
        return true;
    }
    static void Main()
    {
        // Создание массивов
        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] x = new int[n];
        int k = n / 2;
        int[] y = new int[k];

        Random rand = new();
        for (int i = 0; i < x.Length; i++)
            x[i] = rand.Next(0, 20);
        //

        Console.WriteLine();

        // Запись каждого 2-го элемента массива X в массив Y
        for (int i = 0; i < k; i++)
            y[i] = x[2 * i + 1];
        //

        // Вывод массивов
        var str = string.Join(" ", x);
        Console.WriteLine(str);
        str = string.Join(" ", y);
        Console.WriteLine(str);
        //

        Console.WriteLine();

        // Вывод количества простых чисел в массивах
        int count = 0;
        for (int i = 0; i < x.Length; i++)
            if (IsPrime(x[i]) == true)
                count += 1;
        Console.WriteLine(count);

        count = 0;
        for (int i = 0; i < y.Length; i++)
            if (IsPrime(y[i]) == true)
                count += 1;
        Console.WriteLine(count);
        //

        Console.WriteLine();

        // Вывод среднего арифметического массивов
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
            sum += x[i];
        Console.WriteLine(sum / x.Length);

        sum = 0;
        for (int i = 0; i < y.Length; i++)
            sum += y[i];
        Console.WriteLine(sum / y.Length);
        //
    }
}