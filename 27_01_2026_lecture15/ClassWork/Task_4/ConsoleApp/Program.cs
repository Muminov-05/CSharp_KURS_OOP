//## Abstract Methods (Абстрактные методы)
//Вы создаете систему публикации контента в Instagram.       

//У вас есть абстрактный класс "Публикация" (Publication), у которого есть абстрактный метод "опубликовать" (publish).        

//Классы-наследники, например "Фото" (Photo) и "Видео" (Video), должны реализовать этот метод по-своему, в зависимости от типа контента. 

using Domain.Models;

Publication photoPost = new Photo("beach.jpg");
Publication videoPost = new Video("travel.mp4",85);

photoPost.Publish();  
videoPost.Publish();