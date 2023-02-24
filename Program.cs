//Task 8; Программа, которая на вход принимает число (N) а на выходе показывает все четные числа в диапазоне от 1 до N
Console.WriteLine("Task 8; Программа, которая на вход принимает число (N) а на выходе показывает все четные числа в диапазоне от 1 до N");

int i = 1;
bool not = true;
Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные числа от 1 до {num}: "); 
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write($"{i}, "); 
        not = false;
    }
i++;
}

if (not)
{
    Console.Write("Четные числа отсутствуют. Проверьте вводимые данные.");
}