
//1.Создайте пустой список.
var listString = new List<int>(); 
var listInt = new List<int>();
var listDouble = new List<double>();
List<string> newListString = new List<string>();


//2.Добавьте элементы "apple", "banana" и "orange" в список.
var listFruit = new List<string>();
listFruit.Add("apple");
listFruit.Add("banana");
listFruit.Add("orange");


//3. Выведите на экран количество элементов в списке.
Console.WriteLine("Count : " + listFruit.Count);


//4. Выведите на экран все элементы списка.
Console.WriteLine(" Elements : ");
foreach (var item in listFruit)
{
    Console.WriteLine(item);
}


//5. Удалите элемент "banana" из списка.
listFruit.Remove("banana");


//6. Проверьте, содержится ли элемент "apple" в списке.
var IsAppleInFruit = listFruit.Contains("apple");
if (IsAppleInFruit)
{
    Console.WriteLine("The apple is in listFruit.");
} else
{
    Console.WriteLine("The apple is not in listFruit.");
}


//7. Очистите список, удалив все элементы.
listFruit.Clear();


//8. Создайте новый список и скопируйте все элементы из исходного списка.
listFruit.Add("apple");
listFruit.Add("banana");
listFruit.Add("orange");
listFruit.Add("pear");
listFruit.Add("cherry");
Console.WriteLine("new mass 22");
List<string> newListFruit = new List<string>();
newListFruit.AddRange(listFruit);


//9. Вставьте элемент "grape" на первую позицию в списке.
listFruit.Insert(0, "grape");


//10. Удалите элемент на позиции 2 и выведите его значение.
string secondElements = listFruit[2];
listFruit.RemoveAt(2);
Console.WriteLine("The element in 2 positions was deleted");


//11. Проверьте, пустой ли список.
if(listFruit.Count > 0)
{
    Console.WriteLine("List is not empty ");
}
else
{
    Console.WriteLine("List is empty ");
}


//12. Отсортируйте список в алфавитном порядке.
listFruit.Sort();


//13. Переверните порядок элементов в списке.
listFruit.Reverse();


//14. Создайте новый список и объедините его с исходным списком.
var newList = new List<string>();
newList.AddRange(listFruit);


//15. Определите индекс первого вхождения элемента "apple" в списке.
Console.WriteLine(listFruit.IndexOf("apple"));
// vtoroi sposob
for (int i = 0; i < listFruit.Count; i++)
{
    if (listFruit[i] == "apple")
    {
        Console.WriteLine(i);
        break;
    }
}


//16. Удалите все элементы, удовлетворяющие определенному условию (например, длина строки больше 5).
listFruit.RemoveAll(listFruit => listFruit.Length > 5);


//17. Подсчитайте количество элементов, удовлетворяющих определенному условию (например, начинающихся с буквы "a").
int kount = listFruit.Count(listFruit => listFruit[0] == 'a');
Console.WriteLine(kount);


//18. Создайте копию списка с использованием глубокого копирования (не просто ссылки на исходный список).
var listCopy =  new List<string>();
foreach (var item in listFruit)
{
    listCopy.Add(item);
}


//19. Отсортируйте список в обратном порядке.
listFruit.Sort();
listFruit.Reverse();


//20. Соедините элементы списка в одну строку, разделяя их запятой.
string str="";
foreach (var item in listCopy)
{
    str = str + item + "  ";
}
Console.WriteLine(str);