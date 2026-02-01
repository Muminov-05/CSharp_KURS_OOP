//### Домашнее задание 3 Книжный класс
//Напишите программу, которая сначала считывает информацию о книге от пользователя.
//Подробная информация, которую необходимо запросить для каждой книги, включает название, количество страниц и год публикации.
//Ввод пустой строки в качестве названия книги завершает процесс чтения.
//После этого у пользователя спрашивают, что именно нужно распечатать.
//Если пользователь вводит «все», печатаются все детали: названия книг, имя автора, количество страниц и годы публикации.
//Однако если пользователь вводит строку «название», печатаются только названия книг.
//Однако если пользователь вводит строку «Автор», печатаются только книги автора книги.
//Если указано что-то иное, чем «все», «Заголовок» или «Имя автора», программа не должна ничего печатать.
//   class Book
//{
//        + Title:string
//        + NameAuthor:string
//        + Pages:int
//        + PublicationYear : int
//        + Book(string title, string nameAuthor, int pages, int publicationYear)
//}

using Domain.Models;
using Infrastructure.Services;
using System;
using System.Collections.Generic;

BookServices listBook = new BookServices();

Book book1 = new Book("Title1","Author1",100,2020);
Book book2 = new Book("Title2", "Author1", 110, 2010);
Book book3 = new Book("Title3", "Author1", 130, 2015);
Book book4 = new Book("", "Author1", 104, 2020);

var listBook1 = new List<Book> { book1, book2, book3, book4 };

foreach  (var item in listBook1)
{
    if ( item.Title == "")
    {
        return;
    }
    listBook.AddBook(item);
}

Console.Write("Vvedite stroku dlya poiska : ");
var stringSearch = Console.ReadLine();

if(stringSearch == "All")
{
    listBook.ShawAllBooks();
}
else if (stringSearch == "Title")
{
    listBook.ShowOnlyTitle();
}
else if(stringSearch == "Author")
{
    listBook.ShowOnlyNameAuthor();
}
else
{
    Console.WriteLine();
}