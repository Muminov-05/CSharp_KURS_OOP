//## Abstract Classes (Абстрактные классы)
//Вы разрабатываете систему управления аккаунтами в Instagram.      

//У вас есть абстрактный класс "Аккаунт" (Account), который содержит общие методы и свойства для всех аккаунтов.    

//От этого класса наследуются классы "Пользовательский аккаунт" (UserAccount) и "Бизнес-аккаунт" (BusinessAccount),

//которые дополняют его функционалом специфичным для каждого типа аккаунта. 

using Domain.Models;

UserAccount user = new UserAccount("john", "john@.com", "post1");
BusinessAccount business = new BusinessAccount("company123", "contact@company.com", "TechCo");

user.Login();                     
user.DisplayProfile();            
user.LikePost("post1");      
user.Logout();                    

Console.WriteLine();

business.Login();               
business.DisplayProfile();       
business.CompanyAdversting();    
business.Logout();                