
//Напишите программу, которая запрашивает у пользователя номер месяца (от 1 до 12) и выводит название месяца с помощью перечисления (enum).

Console.Write("Input number : ");
int n = Convert.ToInt32(Console.ReadLine());

if( n >= 1 && n <= 12)
{
    Month month = (Month)n;
    Console.WriteLine(month);
}

enum Month
{
    January = 1,
    February ,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
