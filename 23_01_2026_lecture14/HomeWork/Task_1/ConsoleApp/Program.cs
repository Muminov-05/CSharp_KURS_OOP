
using Domain.Models;
using Infrastructure.Services;
using System;

ComputerServices computerServices = new ComputerServices();
LaptopServices laptopServices = new LaptopServices();
SmartPhoneServices smartPhoneServices = new SmartPhoneServices();

Computer comp1 = new Computer("Gaming PC RTX 3060", 4500, "New");
Computer comp2 = new Computer("Office PC i3", 1200, "B/u");
Computer comp3 = new Computer("Home PC Ryzen 5", 2800, "New");
computerServices.AddComputer(comp1);
computerServices.AddComputer(comp2);
computerServices.AddComputer(comp3);

Laptop lap1 = new Laptop("Acer Aspire 5", 1800, "New", 8, "SSD 512GB");
Laptop lap2 = new Laptop("Asus VivoBook", 1600, "B/u", 8, "SSD 256GB");
Laptop lap3 = new Laptop("HP Pavilion", 2200, "New", 16, "SSD 1TB");
laptopServices.AddLaptops(lap1);
laptopServices.AddLaptops(lap2);
laptopServices.AddLaptops(lap3);

SmartPhone phone1 = new SmartPhone("Galaxy S23", 3200, "New", "Samsung", 4000);
SmartPhone phone2 = new SmartPhone("iPhone 13", 4500, "B/u", "Apple", 2240);
SmartPhone phone3 = new SmartPhone("Redmi Note 12", 1800, "New", "Xiaomi", 1600);
SmartPhone phone4 = new SmartPhone("Redmi Note 11 Pro", 2800, "New", "Xiaomi", 5000);
smartPhoneServices.AddSmartPhone(phone1);
smartPhoneServices.AddSmartPhone(phone2);
smartPhoneServices.AddSmartPhone(phone3);
smartPhoneServices.AddSmartPhone(phone4);

Console.WriteLine("\nSpisok komputerov :");
computerServices.PrintInfo();

Console.WriteLine("\nSpisok smartfonov :");
smartPhoneServices.PrintInfo();

Console.WriteLine("\nSpisok notebook :");
laptopServices.PrintInfo();

laptopServices.TypeHardDrive(lap3);
laptopServices.DeleteLaptop(lap2);



Console.WriteLine("\nSpisok Xiomi :");
smartPhoneServices.ThearchXiomi();

Console.WriteLine(lap1.Name + "  was deleted");
laptopServices.DeleteLaptop(lap1);




