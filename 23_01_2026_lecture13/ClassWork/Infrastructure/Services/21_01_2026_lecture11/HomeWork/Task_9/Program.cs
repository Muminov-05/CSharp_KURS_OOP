
// Добавление элементов в список и их отображение.  

var listName = new List<string> { "Amir", "Umar" };
listName.Add("Salim");
listName.Insert(0, "John");
listName.InsertRange(2, new string[] { "Mike", "Sten" });
listName.AddRange(new string[] { "Karim", "Fayzali" });

foreach(var item in listName)
{
    Console.WriteLine(item);
}