
// Напишите программу на C# Sharp для отображения n-ных верхних записей.

var listNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(listNumber[i]);
}

Console.WriteLine();
// vtoroi sposob 
var newList = listNumber.Take(n);

foreach (int i in newList)
{
    Console.WriteLine(i);
}