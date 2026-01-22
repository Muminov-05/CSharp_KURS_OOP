
// Напишите программу на C# Sharp для удаления диапазона элементов из списка, передав начальный индекс и количество удаляемых элементов.

var listInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
listInt.RemoveRange(4, 4);

foreach (var item in listInt)
{
    Console.WriteLine(item);
}
