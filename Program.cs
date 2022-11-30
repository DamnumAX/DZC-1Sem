// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
    
Console.WriteLine("Введите первое число: ");
int num_a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_b = int.Parse(Console.ReadLine());

if (num_a < num_b)
{
    Console.WriteLine("Первое число " + num_a + " меньше чем второе " + num_b);
}
else
{
Console.WriteLine("Второе число " + num_b + " меньше чем первое " + num_a);
}
