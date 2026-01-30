//1️⃣ **Задание: Расчет формы**

//Создайте класс под названием Shape со следующими свойствами и методами:

//— Абстрактный метод: «CalculateArea()» — вычисляет и возвращает площадь фигуры.
//- Виртуальный метод: `PrintDescription()` — распечатывает описание фигуры.

//Реализуйте два дочерних класса: Rectangle и Circle, которые наследуются от класса Shape.
//Переопределите методы CalculateArea() и PrintDescription() в каждом дочернем классе, чтобы обеспечить их конкретную реализацию.

using Domain.Models;
using Infrastructure;
using Infrastructure.Infrastructure;

Shape shapeCircle = new CircleServices(4);
Shape shapeRectangle = new RectangleServices(4, 5);

shapeCircle.PrintDescription();
Console.WriteLine("Площадь: " + shapeCircle.CalculateArea());

shapeRectangle.PrintDescription();
Console.WriteLine("Площадь: " + shapeRectangle.CalculateArea());