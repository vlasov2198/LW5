int[] arr = { 2, 35, 7, 233, 7, 4, 7, 3, 32, 228, 2, 12, 32, 32, 43 };
Console.WriteLine("Вывод элементов массива: ");
foreach (int i in arr)
{
    Console.WriteLine(i);
}

Console.WriteLine("Введите число, количество которых в массиве хотите посчитать. Чтобы выйти из программы введите 0. ");
int K = int.Parse(Console.ReadLine()); 
while(K != 0)
{
    int count = arr.Where(x => x % K == 0).Count();
    Console.WriteLine($"Чисел кратных {K}: {count}");
    Console.WriteLine("Введите число, количество которых в массиве хотите посчитать. Чтобы выйти из программы введите 0. ");
    K = int.Parse(Console.ReadLine());
}

