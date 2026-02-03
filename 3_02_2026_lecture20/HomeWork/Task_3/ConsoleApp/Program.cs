
//Создайте класс **Gauge**. Датчик имеет переменную **public int value**и * *конструктор без параметров.**
//Конструктор устанавливает начальное значение переменной счетчика равным 0.
//Класс имеет следующие три метода.
//Во-первых, **public void Enhance()**увеличивает значение переменной экземпляра значения на единицу. Значение не превышает пяти.
//Во-вторых, **public void Decrease()**уменьшает значение переменной экземпляра значения на единицу.
//Это не уменьшает значение до отрицательных значений.
//В-третьих, **public bool Full()**возвращает * *True * *, если значение переменной экземпляра имеет значение пять.
//В противном случае возвращается **False**.
//Предоставьте возможность значения для get и set: **Сделайте значение общедоступным, а не частным, и добавьте { get; набор; } в объявляющих строках!**

using Infrastructure.Services;

GaugeServices gaugeServices = new GaugeServices(3);

gaugeServices.Enhance();
Console.WriteLine(gaugeServices.Value);

gaugeServices.Decrease();
Console.WriteLine(gaugeServices.Value);

Console.WriteLine(gaugeServices.Full());