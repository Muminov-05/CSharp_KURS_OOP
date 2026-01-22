
// Смешивание элементов списка в случайном порядке. 
var listINT = new List<int> { 1, 22, 4 , 33, 14, 5 };
Random random = new Random();

var newList = listINT.OrderBy(x => random.Next()).ToList();

foreach (var item in newList)
{
    Console.WriteLine(item);
}