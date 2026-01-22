
// Напишите программу C# Sharp, которая удаляет все буквы «а» из каждой строки в заданном списке строк и возвращает результирующую строку.

var listString = new List<string> { "Hasan", "BahRom", "Asadullo", "Faromarz" };
for(int i = 0; i < listString.Count; i++)
{
    listString[i] = listString[i].Replace("a", "");
}

foreach (var item in listString)
{
    Console.WriteLine(item);
}