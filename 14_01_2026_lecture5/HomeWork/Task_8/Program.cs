
// Напишите программу на C#, которая запрашивает у пользователя два числа и одну операцию (+, -, *, /),          
// а затем вычисляет операции и отобразить результат на экране. 

double sum( double a, double b)
{
    return a + b;
}

double Subtract( double a, double b)
{
    return a - b;
}

double Multiplication(double a, double b)
{
    return a * b;
}
double Division(double a, double b)
{
    return a / b;
}

Console.Write(" a = ");
double a =Convert.ToDouble(Console.ReadLine());
Console.Write(" b = ");
double b = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.WriteLine(" 1.Sum()    2.Subtract()  3.Multiplication()   4.Division()");
    int choise = Convert.ToInt32(Console.ReadLine());
    switch( choise)
    {
        case 1: Console.WriteLine($" {a} + {b} = {sum(a, b)}"); break;
        case 2: Console.WriteLine($" {a} - {b} = {Subtract(a, b)}"); break;
        case 3: Console.WriteLine($" {a} * {b} = {Multiplication(a, b)}"); break;
        case 4: Console.WriteLine($" {a} / {b} = {Division(a, b)}"); break;
        case 0: return;
    }
}