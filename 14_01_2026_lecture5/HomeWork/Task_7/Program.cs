
// Создайте программу на C#, которая запрашивает у пользователя диапазон чисел (x, y) и отображает таблицу умножения. от х до у.    

void print(int x,int y)
{
    if (x > y)
        return;
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{x} * {i} = { x*i }");
    }
    Console.WriteLine("--------------------------");
    print(++x,y);
}

Console.Write(" x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" y : ");
int y = Convert.ToInt32(Console.ReadLine());
print(x, y);