
// Напишите программу C# Sharp для отображения свойств дня (год, месяц, день, час, минута, секунда, миллисекунда и т. д.).

using System;

DateTime dateTime = new DateTime(2026, 2, 3, 22, 33, 55, 15);

Console.WriteLine("Year : " + dateTime.Year);
Console.WriteLine("Month : " + dateTime.Month);
Console.WriteLine("Day : " + dateTime.Day);
Console.WriteLine("Hour : " + dateTime.Hour);
Console.WriteLine("Minute : " + dateTime.Minute);
Console.WriteLine("Second : " + dateTime.Second);
Console.WriteLine("Millisecond : " + dateTime.Millisecond);
