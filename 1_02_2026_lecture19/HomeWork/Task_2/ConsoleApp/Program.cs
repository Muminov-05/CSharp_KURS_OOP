//#### (Russian)
//В этом упражнении вы будете работать с тем же классом Account, что и раньше.
//Ваша задача — написать программу, выполняющую следующие действия:

//1.Создайте учетную запись под названием «Учетная запись Хейкки» с балансом 1000,0.
//2. Создайте учетную запись с названием «Личный кабинет» с балансом 0.
//3. Вывести 100,0 со счета Хейкки.
//4. Внести 100,0 на Личный счет.
//5. Распечатайте информацию об учетной записи Хейкки, а затем о личной учетной записи, используя метод ToString.

using Domain.Models;
using Infrastructure.Services;

AccountServices accountServices1 = new AccountServices("Heikki", 1000);
AccountServices accountServices2 = new AccountServices("Personal", 0);

accountServices1.PrintAccount();
accountServices2.PrintAccount();

accountServices2.Deposit(100);
accountServices1.Withdrawel(100);

accountServices1.PrintAccount();
accountServices2.PrintAccount();