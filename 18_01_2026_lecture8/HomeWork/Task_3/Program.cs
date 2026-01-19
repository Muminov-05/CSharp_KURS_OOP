
//Класс `Date` моделирует календарную дату с днем, месяцем и годом.
//### Члены класса
//- 3 частные переменные экземпляра: `day`, `month` и `year`.
//- Конструкторы, публичные геттеры и сеттеры для частных переменных экземпляра.
//- Метод `SetDate()`, который устанавливает день, месяц и год.
//- Методы `GetMonth()`, `GetYear()` и `GetDay()` для получения соответствующих значений.
//- Метод `ToString()`, который возвращает дату в формате "DD/MM/YYYY" с ведущим нулем для `DD` и `MM`, если применимо.

Date date = new Date();
Console.Write("date : ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("month : ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("Year : ");
int  year = Convert.ToInt32(Console.ReadLine());

date.SetDate(day, month, year);
Console.WriteLine(date.toString());

Date date1 = new Date(15,12,2025);
Console.WriteLine(date1.toString());


class Date
{
    private int Day;
    private int Month;
    private int Year;

    public Date() {}
    public Date(int day, int month, int year)
    {
        Day = day; Month = month; Year = year;
    }
    public void SetDate(int day , int month, int year)
    {
        Day = day; Month = month; Year = year;
    }
    public int GetDay()
    {
        return Day;
    }
    public int GetMonth()
    {
        return Month;
    }
    public int GetYear()
    {
        return Year;
    }
    public string toString()
    {
        if( Day < 10 && Month < 10)
            return $"0{Day}/0{Month}/{Year}";
        if( Day < 10 )
            return $"0{Day}/{Month}/{Year}";
        if (Month < 10)
            return $"{Day}/0{Month}/{Year}";
        return $"{Day}/{Month}/{Year}";
    }
}