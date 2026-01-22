
// Напишите программу C# Sharp для создания списка из заданного списка целых чисел, в котором каждый элемент умножается на 3.    

var listInt = new List<int> { 1, 2, 3, 4, 5, 6 };
var newList = new List<int>();
foreach(var item in listInt)
{
    newList.Add(item*3);
}

foreach (var item in newList)
{
    Console.WriteLine(item);
}
