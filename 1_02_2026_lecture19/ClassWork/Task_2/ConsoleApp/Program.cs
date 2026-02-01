//### Домашнее задание 2: Долг

//using Domain.Models;

//Класс «Долг» представляет собой долг с остатком и процентной ставкой.
//#### Характеристики
//- `баланс` (двойной): текущий баланс долга.
//- `interestRate` (double): процентная ставка по долгу.
//#### Конструктор
//Класс Debt имеет конструктор, принимающий два параметра:
//- `initialBalance` (double): начальный баланс долга.
//- `initialInterestRate` (double): начальная процентная ставка по долгу.
//#### Методы
//##### ПечатьБаланс()
//Метод PrintBalance() печатает текущий баланс долга.
//##### WaitOneYear()
//Метод WaitOneYear() увеличивает сумму долга путем умножения баланса на процентную ставку.
//## Пример использования
//```csharp
//Debt mortgage = new Debt(100000, 0.01);
//mortgage.PrintBalance(); // Output: 100000
//mortgage.WaitOneYear();
//mortgage.PrintBalance(); // Output: 101000
//mortgage.WaitOneYear();
//mortgage.PrintBalance(); // Output: 102010
//```
//В приведенном выше примере создается новый объект «Долг» с начальным балансом 100000 и начальной процентной ставкой 0,01.
//Метод PrintBalance() вызывается для печати текущего баланса долга, который равен 100000.
//Затем дважды вызывается метод WaitOneYear(), который увеличивает сумму долга путем умножения баланса на процентную ставку.
//После первого звонка баланс 101000, а после второго звонка баланс 102010.
using Domain.Models;
using Infrastructure.Services;

DebtServices mortgage = new DebtServices(100000, 0.01);

mortgage.PrintBalance(); 
mortgage.WaitOneYear();
mortgage.PrintBalance(); 
mortgage.WaitOneYear();
mortgage.PrintBalance(); 