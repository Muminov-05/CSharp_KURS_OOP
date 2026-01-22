
// Напишите программу C# Sharp для удаления элемента в нужной позиции из массива.

var listNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

listNumber.RemoveAt(5);
listNumber.RemoveRange(1, 2);

foreach (var item in listNumber)
{
    Console.WriteLine(item);
}