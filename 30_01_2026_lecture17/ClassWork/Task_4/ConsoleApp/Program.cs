
//using System.Xml.Linq;

//4️⃣ **Задача: Расчет премии сотрудникам**

//Создайте класс с именем «Сотрудник» со следующими свойствами и методами:

//Характеристики:
//- `Name` (строка) — представляет имя сотрудника.
//- `EmployeeId` (строка) — представляет идентификатор сотрудника.
//- «Зарплата» (десятичная) — представляет собой зарплату сотрудника.

//Методы:
//- `CalculateBonus()` — рассчитывает сумму бонуса на основе определенных условий, таких как годы службы и рейтинг производительности.

//Создайте дочерние классы, такие как «Менеджер» и «Разработчик», которые наследуются от класса «Сотрудник».
//Переопределите метод CalculateBonus() в каждом дочернем классе, чтобы обеспечить свою конкретную логику расчета бонуса.

using Domain.Models;
using Infrastructure.Services;

Employee manager = new Meneger(1, "Alex", 3000m, 2);
Employee developer = new Developer(2, "John", 5000m, 3);

Console.WriteLine($"Менеджер: {manager.Name}");
Console.WriteLine($"Бонус: {manager.CalculateBonus()}");

Console.WriteLine();

Console.WriteLine($"Разработчик: {developer.Name}");
Console.WriteLine($"Бонус: {developer.CalculateBonus()}");
