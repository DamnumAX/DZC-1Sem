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