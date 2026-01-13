
//Напишите программу на C# Sharp, чтобы проверить, является ли число простым или нет, используя рекурсию. 

bool Prime(int n, int delitel = 2)
{
    if (n == 2)
        return true;
    if (delitel == n)
        return true;
    if (n % delitel == 0)
        return false;
    return Prime(n, ++delitel);
}


Console.WriteLine("Input : ");
int n = Convert.ToInt32(Console.ReadLine());

if (Prime(n))
{
    Console.WriteLine($" {n}  is Prime");
}
else
{
    Console.WriteLine($" {n} is not Prime");
}