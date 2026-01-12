
//Создайте Mетод **int Divisors(int x)**, который принимает натуральное число x. Метод показывает все     
//делители x и должна вернуть количество делителей. Выведите все натуральные делители x в порядке           
//возрастания (включая 1 и само число), а также количество делителей.


int Divisors(int x)
{
    int kol = 0;
    Console.WriteLine(" Делители x : ");
    for(int i = 1; i <= x; i++)
    {
        if ( x % i == 0)
        {
            Console.WriteLine(i);
            kol++;
        }
    }
    return kol;
}

Console.WriteLine(" Input : ");
Console.Write(" x : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Их количество :{Divisors(x)}");