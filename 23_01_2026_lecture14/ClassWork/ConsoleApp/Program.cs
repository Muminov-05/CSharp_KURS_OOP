//### Task 1 
//1.Создайте класс "Магазин" (Shop) с полем-списком "Товары" (Products) типа List<Product>. Это поле будет хранить список товаров, доступных в магазине. 

//2. Реализуйте методы для добавления товара в магазин, удаления товара из магазина и вывода списка товаров в магазине.                                    
//    Для этого добавьте следующие методы в класс "Магазин":                                    

//   -Метод "ДобавитьТовар"(AddProduct), который принимает объект типа Product в качестве аргумента и добавляет его в список "Товары".

//   - Метод "УдалитьТовар" (RemoveProduct), который принимает объект типа Product в качестве аргумента и удаляет его из списка "Товары".

//   - Метод "ВывестиСписокТоваров" (PrintProductList), который выводит на экран информацию о всех товарах в магазине.
//   - Для этого переберите элементы списка "Товары" и вызовите метод, который выводит информацию о каждом товаре.

//4. Создайте классы "Телефон" (Phone) и "Автомобиль" (Car), которые наследуют класс "Товар" (Product).                                            
// Класс "Товар" должен иметь поля "Название" (Name) и "Цена" (Price), а классы "Телефон" и "Автомобиль" должны расширять этот функционал своими дополнительными полями и методами.

//5. Создайте объект класса "Магазин" и добавьте несколько товаров различных типов                                                                       
//    (несколько объектов класса "Телефон" и несколько объектов класса "Автомобиль") с помощью метода "ДобавитьТовар".                                  

//7. Продемонстрируйте работу методов класса "Магазин" вызовом следующих операций:

//   -Добавьте новый товар в магазин с помощью метода "ДобавитьТовар".

//   - Выведите список товаров в магазине с помощью метода "ВывестиСписокТоваров".

//   - Удалите один из товаров

using Domain.Models;
using Infrastructure.Services;

ShopServices shopServices =  new ShopServices();

Phone phone1 = new Phone("iPhone 14", 1200, "Apple", "128gb");
Phone phone2 = new Phone("Galaxy S23", 1000, "Samsung", "256gd");
Phone phone3 = new Phone("Redmi Note 12", 1600, "Xiomi", "128gd");

Car car1 = new Car("BMW X5", 50000, "BMW", 2022, 350);
Car car2 = new Car("Tesla Model 3", 45000, "Tesla",  2023, 300);
Car car3 = new Car("Mersedes Benz", 45000, "Mersedes", 2023 ,250);

shopServices.AddProduct(car1);
shopServices.AddProduct(car2);
shopServices.AddProduct(car3);
shopServices.AddProduct(phone1);
shopServices.AddProduct(phone2);
shopServices.AddProduct(phone3);

shopServices.PrintProductList();

Console.WriteLine();
PhoneServices phoneService = new PhoneServices();
phoneService.printMemoryPhone(phone2);

Console.WriteLine();
CarServices carService = new CarServices();
carService.PrintMaxSpeed(car3);

shopServices.RemoveProduct(phone1);
shopServices.RemoveProduct(car2);

Console.WriteLine("\nСписок товаров после удаления");
shopServices.PrintProductList();






























