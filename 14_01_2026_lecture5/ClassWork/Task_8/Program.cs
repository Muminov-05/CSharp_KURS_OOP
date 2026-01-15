
//Создайте программу C#, реализующую рекурсивную функцию под названием «Умножение», которая получает      
//два целых числа, запрошенные пользователем, и возвращает результат их умножения.  

int Multiply(int a , int b)
{
    if(b==0) return 0;
    return a + Multiply(a, --b);
}

Console.Write(" Vvedite pervoe chislo = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Vvedite vtoroe chislo = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} * {b} = {Multiply(a, b)}");