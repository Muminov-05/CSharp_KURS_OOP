
//  Удаление всех элементов соответствующих определенному условию.

var listStr = new List<string> { "123", "1234", "12345", "123456" };
listStr.RemoveAll(p => p.Length < 5);
foreach (var item in listStr)
{
    Console.WriteLine(item);
}