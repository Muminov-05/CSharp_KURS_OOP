//В этом упражнении вы будете работать с классом Account, который представляет банковский счет с балансом.
//Ваша задача — написать программу, которая выполняет следующие шаги в точном порядке:

//1.Создайте аккаунт с балансом 100,0.
//2. Внесите 20,0 на счет.
//3. Распечатайте баланс счета.

using Infrastructure.Services;

AccountServices accountServices = new AccountServices(100);
accountServices.PrintBalance();

accountServices.Deposit(20);
accountServices.PrintBalance();

accountServices.Withdrawal(100);
accountServices.PrintBalance();
