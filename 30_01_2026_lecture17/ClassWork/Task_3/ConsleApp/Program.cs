//**Задание: Банковские операции**
//Создайте класс BankAccount со следующими свойствами и методами:
//Характеристики:
//- `AccountNumber` (строка) — представляет номер счета.
//- «Баланс» (десятичный) — представляет текущий баланс.
//- `Owner` (строка) — представляет имя владельца учетной записи.
//Методы:
//- `Депозит(десятичная сумма)` -Вносит указанную сумму на счет.
//- `Withdraw(decimal sum)` - Выводит указанную сумму со счета.
//- `PrintStatement()` — печатает выписку с данными счета и текущим балансом.
//Добавьте абстрактный метод CalculateInterest(), который рассчитывает проценты по счету.

//Создайте два дочерних класса: SavingsAccount и CheckingAccount, которые наследуются от класса BankAccount.
//Каждый дочерний класс должен переопределить метод CalculateInterest(), чтобы обеспечить свою конкретную логику расчета процентов.

using System;
using Infrastructure.Services;

BankAccountServices checkingAccount = new CheckingAccountServices( "Amir","SSSS-001",1000m);

checkingAccount.Deposit(500);
checkingAccount.Withdraw(200);
checkingAccount.PrintStatement();
Console.WriteLine($"Проценты: {checkingAccount.CalculateInterest()}");

Console.WriteLine();

BankAccountServices savingsAccount = new SavingsAccountServices( "Ali", "DDDD-002",2000m);
savingsAccount.Deposit(1000);
savingsAccount.Withdraw(300);
savingsAccount.PrintStatement();
Console.WriteLine($"Проценты: {savingsAccount.CalculateInterest()}");
