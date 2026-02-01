//### Home Task 5: Counter
//The `Counter` class represents a counter that can be incremented and decremented.

//Класс Counter представляет счетчик, который можно увеличивать и уменьшать.
//#### Fields
//-value` (int): текущее значение счетчика.
//#### Constructor
//Класс Counter имеет конструктор, принимающий один параметр:
//- `value` (int): начальное значение счетчика.
//#### Methods
//Метод Decrement() уменьшает значение счетчика на 1. Если значение счетчика уже равно 0, он ничего не делает.
//Метод Reset() сбрасывает значение счетчика на 0.
//```mermaid
//classDiagram
//    class Counter
//{
//        - value:int
//          Decrement()
//          Reset()
//          PrintValue()
//    }
//```

using Infrastructure.Services;

CounterServices counter = new CounterServices(5);

counter.PrintValue();

counter.Decrement();
counter.PrintValue();

counter.Reset();
counter.PrintValue();