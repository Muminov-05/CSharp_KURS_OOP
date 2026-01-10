
// Это коментария для одной строки.

/*
 * Это коментария для 
 * несколких строк
 */

//  Output
Console.WriteLine("Hello Sabriddin !");
Console.Write("Hello");
Console.WriteLine("Amirjon");
// Отличие : у Console.WriteLine() в конец ест переход на следующем строке, а у Console.Write() нету.


//  Input 
Console.WriteLine("Введите имю :");
string name = Console.ReadLine();
Console.WriteLine($"Меня зовут {name}");
// Замечние : Console.ReadLine() всегда сохранит данные в виде строк.

// Convert 
int number = 25;
string str = "152";
float number2 = 25.36f;
Console.WriteLine(Convert.ToString(number));
Console.WriteLine(Convert.ToInt32(str));
Console.WriteLine(Convert.ToDouble(number));


//  Zadacha_1
//Console.WriteLine("Введите вашу имя");
//string firstName =  Console.ReadLine();
//Console.WriteLine("Введите вашу фамилю");
//string lastName = Console.ReadLine();
//Console.WriteLine("Введите ваш возраст");
//int age = Convert.ToInt32(Console.ReadLine();
//Console.WriteLine($"Меня зовут {firstName} {lastName}. Мне {age} лет");


//   if ... else 
//int new_number = 18;
//if (number > 18)
//{
//    Console.WriteLine("Совершиналетен.");
//}
//else if (number == 18)
//{
//    Console.WriteLine("Тебе 18.");
//}
//else
//{
//    Console.WriteLine("Несовершиналетен.");
//}


//     SWITCH
//int num = 2;
//switch (num)
//{
//    case 1:
//        Console.WriteLine(" Good morning.");
//        break;
//    case 2:
//        Console.WriteLine(" Good afternoon.");
//        break;
//    case 3:
//        Console.WriteLine(" Good night");
//        break;
//    default:
//        Console.WriteLine("neverniy vubor");
//        break;
//}


//Console.WriteLine();
//char symwol = 'a';
//var result = symwol switch
//{
//    'a' => "Akbar",
//    'b' => "Bahrom",
//    'c' => "Calom",
//    'd' => "Davron",
//    _ => "None"
//};
//Console.WriteLine(result);



// for 

//int sum = 0;
//for(  int i = 1; i <= 20; i++)
//{
//    if( i % 4 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine($" Сумма чисел кратный 4 между отрезком [1,20]  равно ; {sum}");



// while

//int chislo = 20;
//while (chislo > 0)
//{
//    Console.WriteLine(chislo);
//    chislo-=6;
//}



// do while 

//int i = 0;
//do
//{
//    i++;
//    Console.WriteLine(i);
//}while (i < 5);



// break 

//for( int i=1;i<20;i++)
//{
//    if ( i%5 ==0 )
//    {
//        Console.WriteLine(i);
//        break;
//    }
//}



// continue 

//for ( int i = 1; i < 10; i++)
//{
//    if( i / 2 == 0)
//    {
//        continue
//    }
//    Console.Write(i);
//}



//  massiv

//int[] numbers = { 1, 3, 5, 7, 9 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int students[] = { "Alex" , " John",  "Ali" , "Bob"};
//foreach(var student in students) {
//    Console.WriteLine(student);
//}


//int summa()
//{
//    int sum = 0;
//    for(int i=1; i<25; i++)
//    {
//        sum += i;
//    }
//    return sum;
//}
//Console.WriteLine($"Сумму чисел от 1 до 25 равно : {summa()}");


void DaysOfWeek()
{
    string[] days =
    {
        "Понедельник",
        "Вторник",
        "Среда",
        "Четверг",
        "Пятница",
        "Суббота",
        "Воскресенье"
    };

    foreach (string day in days)
    {
        Console.WriteLine(day);
    }
}

DaysOfWeek();
