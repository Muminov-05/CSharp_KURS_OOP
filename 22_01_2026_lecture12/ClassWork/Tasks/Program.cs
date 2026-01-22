
////1.Создайте список чисел и найдите сумму всех элементов.
//var ListNuber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sum = 0;
//foreach(var num in ListNuber)
//{
//    sum += num;
//}
//Console.WriteLine(sum);


////2. Создайте список строк и отсортируйте его в порядке убывания длины строк.
//var listString = new List<string> { "john", "alex", "martin" };
//listString.Sort();
//listString.Reverse();


////3. Создайте список объектов класса Person (с полями Name и Age) и отсортируйте их по возрастанию возраста.
//Person person1 = new Person("John", 22);
//Person person2 = new Person("Wick", 20);
//Person person3 = new Person("Alex", 21);
//var listPerson = new List<Person>() { person1, person2, person3};

//listPerson.Sort((prs1,prs2) => prs1.Age.CompareTo(prs2.Age));

//foreach (var num in listPerson)
//{
//    Console.WriteLine(num.Name + "  " + num.Age);
//}
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}


////4. Создайте список чисел и удалите из него все нечетные элементы.
//var listNum = new List<int> { 1,2,3,4,5,6,7,8,9,10};
//listNum.RemoveAll(num => num % 2 == 1);
//foreach (int num in listNum)
//{
//    Console.WriteLine(num);
//}


////5. Создайте список строк и преобразуйте каждую строку в верхний регистр.
//List<string> words = new List<string> { "apple", "banana", "lemon" };
//for (int i = 0; i < words.Count; i++)
//{
//    words[i] = words[i].ToUpper(); 
//}
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}


////6. Создайте список чисел и найдите максимальное и минимальное значения.
//var newListNum = new List<int> { 1, 8, 9, 6, 3, 2, 5, 8, 0, 4, 8 };
//int maxNum = newListNum.Max();
//int minNum =  newListNum.Min();
//Console.WriteLine($"max = {maxNum}  min = {minNum}");


////7. Создайте список строк и проверьте, содержит ли каждая строка только уникальные символы.
//var uniqueString = new List<string> { "ab", "ab", "abc", "abcd" };
//bool d = true;
//foreach (var item in uniqueString)
//{
//    if( item.Distinct().Count() != item.Length)
//    {
//        d = false;
//    }
//}
//Console.WriteLine(d);


////8. Создайте список объектов и найдите средний возраст (поле Age) всех объектов.
//Student st1 = new Student("Karim", 21);
//Student st2 = new Student("Ali", 22);
//Student st3 = new Student("Vali", 20);
//var lstStudent = new List<Student> { st1, st2, st3 };
//double sum = 0;
//foreach (var s in lstStudent)
//{
//    sum += s.Age;
//}
//Console.WriteLine(" Sredniy vozrast : " + sum/lstStudent.Count());

//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Student() { }
//    public Student(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}


////9. Создайте список чисел и удалите все повторяющиеся элементы.
//var lNum = new List<int> { 1, 2, 3, 1, 2, 1, 4, 5, 5, 6 };

//var uniqNum = lNum.Distinct();
//foreach (int i in uniqNum)
//{
//    Console.WriteLine(i);
//}


////10. Создайте список строк и проверьте, является ли каждая строка палиндромом.
//List<string> liSTR = new List<string> { "asdsa", "cddc", "level" };
//bool newd = true;
//foreach(var str in liSTR)
//{
//    string newStr = new string(str.Reverse().ToArray());
//    if ( str != newStr)
//    {
//        newd =false;
//        break;
//    }
//}
//Console.WriteLine(newd);


////11.Создайте список строк и объедините его элементы в одну строку, разделяя их точкой с запятой.
//var stringList = new List<string> { "My", "name", "is", "John", "." };
//string str = string.Join(";", stringList);
//Console.WriteLine(str);


////12. Создайте список чисел и найдите сумму элементов с нечетными индексами.
//var liNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
//int sum = 0;
//for (int i = 0; i < liNum.Count; i++)
//{
//    if( i % 2 ==1  ) 
//        sum+=liNum[i];
//}
//Console.WriteLine(sum);


////13. Создайте список строк и найдите самую длинную строку.
//var lstr = new List<string> { "jhh", "1234", "123456" };
//string maxStr = lstr[0];
//for(int i=1; i< lstr.Count(); i++)
//{
//    if(lstr[i].Length > maxStr.Length)
//    {
//        maxStr = lstr[i];
//    }
//}

//Console.WriteLine(maxStr);


////14. Создайте список объектов и отсортируйте их в порядке возрастания значения поля Name.
//Person person1 = new Person("Johnson", 22);
//Person person2 = new Person("Wick", 20);
//Person person3 = new Person("Alexandr", 21);
//var listPerson = new List<Person>() { person1, person2, person3 };

//listPerson.Sort((prs1, prs2) => prs1.Name.CompareTo(prs2.Name));

//foreach (var num in listPerson)
//{
//    Console.WriteLine(num.Name + "  " + num.Age);
//}
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}


////15. Создайте список чисел и найдите все пары элементов, сумма которых равна заданному числу.
//var listNum = new List<int> { 1, 2, 3, 2, 4, 5, 6, 7, 8 };
//int chislo = 5;
//for (int i = 0; i < listNum.Count; i++)
//{
//    for(int j = i+1; j < listNum.Count-1; j++)
//    {
//        if(listNum[i] + listNum[j] == chislo )
//            Console.WriteLine(listNum[i] + "  "+listNum[j]);
//    }
//}


////16. Создайте список объектов и отфильтруйте его, оставив только объекты, у которых поле Age больше среднего значения.
//Person person1 = new Person("Johnson", 22);
//Person person2 = new Person("Wick", 20);
//Person person3 = new Person("Alexandr", 21);
//var listPerson = new List<Person>() { person1, person2, person3 };
//double sum = 0;
//foreach (var person in listPerson)
//{
//    sum += person.Age;
//}
//double averg = sum / listPerson.Count();

//var newList = listPerson.Where(p => p.Age > averg).ToList();

//foreach (var num in newList)
//{
//    Console.WriteLine(num.Name + "  " + num.Age);
//}
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}


////17. Создайте список строк и удалите из него все строки, которые содержат определенную подстроку.
//var str = new List<string> { "sa21dd", "sdcs", "sdsdc", "ds21" };
//string podstroka = "21";

//str.RemoveAll(s => s.Contains(podstroka));

//foreach (var s in str)
//{
//    Console.WriteLine(s);
//}


////18. Создайте список чисел и замените все отрицательные элементы на их абсолютные значения.
//var listChisel = new List<int> { 1, 2, -5, 4, 8, -9, 4 };
//for (int i = 0; i < listChisel.Count; i++)
//{
//    if (listChisel[i] < 0)
//        listChisel[i] = -listChisel[i]; 
//}
//foreach (var chisel in listChisel)
//{
//    Console.WriteLine(chisel);
//}


//19. Создайте список объектов и разделите его на группы по значению определенного поля.
Person person1 = new Person("Johnson", 22);
Person person2 = new Person("John", 21);
Person person3 = new Person("Mike", 22);
Person person4 = new Person("Alex", 20);

var listPerson = new List<Person>() { person1, person2, person3, person4};
  
var groups = listPerson.GroupBy(p => p.Age);

foreach (var group in groups)
{
    Console.WriteLine("Age: " + group.Key);
    foreach (var person in group)
    {
        Console.WriteLine("  " + person.Name);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
