
//   Поиск элемента в списке.

var listInteger = new List<int> { 1, 12, 3, 34, 5, 56, 711, 822, 12 , 9 };

Console.WriteLine(listInteger.Contains(12));
Console.WriteLine(listInteger.Contains(2));

Console.WriteLine(listInteger.Find(num => num == 12));
Console.WriteLine(listInteger.FindLast(num => num == 12));

Console.WriteLine();
var newListInt = listInteger.FindAll(num => (Convert.ToString(num)).Length > 1);
foreach (var item in newListInt)
{
    Console.WriteLine(item);
}
