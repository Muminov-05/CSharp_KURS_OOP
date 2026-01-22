
// - Проверка, содержит ли список все элементы другого списка.  

var list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var list2 = new List<int> { 4, 5, 6, 7, 8 };

bool chaked = list2.All(p => list1.Contains(p));
Console.WriteLine(chaked);
