
// Создайте список и заполните его случайными числами. Распечатайте все числа. 

List<int> numbers = new List<int>();
Random rnd = new Random();

for (int i = 0; i < 15; i++)
{
    numbers.Add(rnd.Next(1, 101)); // числа от 1 до 100
}
Console.WriteLine("Spisok radomnukh chisel :");
foreach (int n in numbers)
{
    Console.Write(n + "  ");
}