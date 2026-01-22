
// Напишите программы для сортировки элементов списка.
var listInt = new List<int> { 1, 12, 3, 34, 5, 66, 7, 18, 9 };
listInt.Sort();
foreach (var item in listInt)
{
    Console.WriteLine(item);
}

Console.WriteLine();
var listInt1 = new List<int> { 1, 12, 3, 34, 5, 66, 7, 18, 9 };
var sortedDesc = listInt1.OrderByDescending(x => x).ToList();
foreach (var item in sortedDesc)
{
    Console.WriteLine(item);
}