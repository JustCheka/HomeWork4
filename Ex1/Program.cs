Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите степень ");
int st = int.Parse(Console.ReadLine());

int result = (int) Math.Pow(num, st);
Console.Write(result);