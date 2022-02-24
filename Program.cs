// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();
Random rnd = new Random();
Console.Write("Задайте размер по Х: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте размер по Y: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Задайте число, которое необходимо найти: ");
int num = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] == num)
        {
             Console.WriteLine($"Число {num} находится на позиции {i},{j}.");
             count++;
        }
    }    
}
if (count == 0) Console.WriteLine("Такого числа в массиве нет.");