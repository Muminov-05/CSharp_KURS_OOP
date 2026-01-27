
//## Virtual Methods (Виртуальные методы)
//Вы создаете приложение для загрузки и обработки фотографий в Instagram.    

//У вас есть базовый класс "Фотография" (Photo) и класс-наследник "Обработанная фотография" (ProcessedPhoto).       

//У класса "Фотография" есть виртуальный метод "отобразить" (display), который выводит фотографию на экран. 

//Класс "Обработанная фотография" переопределяет этот метод, добавляя к нему дополнительный функционал, например, фильтры или эффекты.                                          



using Domain.Models;

Photo photo = new Photo("Spring");
photo.Display();

ProcessedPhoto processedPhoto = new ProcessedPhoto("spring","Black & White");
processedPhoto.Display();

