
// Удаление элемента из списка.

var listName = new List<string>();
listName.Add("Alex");
listName.Add("Alijon");
listName.Add("Bob");
listName.Add("Bill");
listName.Add("John");
listName.Add("Wick");
foreach(var item in listName)
{
    Console.WriteLine(item);
}
listName.RemoveAt(0);
listName.Remove("Bob");
listName.RemoveAll(personName => personName.Length > 5 );
listName.RemoveRange(0, 2);
Console.WriteLine();
Console.WriteLine("Posle Udaleniya");
foreach (var item in listName)
{
    Console.WriteLine(item);
}