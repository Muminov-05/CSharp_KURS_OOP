
Console.WriteLine(" Введите сумму вклада :");
double vklad = Convert.ToDouble(Console.ReadLine());
if (vklad < 100) 
{
    Console.WriteLine($"Общая сумма вклада по 5% : {vklad + vklad * 0.05}");
} 
else if ( vklad >= 100 && vklad <= 200) 
{
    Console.WriteLine($"Общая сумма вклада по 10% : {vklad + vklad * 0.07}");
}
else
{
    Console.WriteLine($"Общая сумма вклада по 10% : {vklad + vklad * 0.1}");
}

