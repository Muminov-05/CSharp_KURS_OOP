
//  Напишите программ для получения подсписка из основного списка.

var listInt = new List<int> { 1, 12, 3, 34, 5, 66, 7, 18, 9 };
var newList = listInt.GetRange(1, 5);
foreach (var item in newList)
{
    Console.WriteLine(item);
}