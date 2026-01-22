
//Напишите программу C# Sharp для создания списка из заданного списка строк.
//Каждый элемент заменяется четырьмя копиями строки, объединенными вместе.

var listString = new List<string> { "Hasan", "BahRom", "Asadullo", "Faromarz" };
var newListString = new List<string>();

for(int i = 0; i < listString.Count; i++)
{
    string newStr = "";
    for(int j = 0; j < 4; j++)
    {
        newStr += (listString[i]+" ");
    }
    newListString.Add(newStr);
}

foreach (var item in newListString)
{
    Console.WriteLine(item);
}