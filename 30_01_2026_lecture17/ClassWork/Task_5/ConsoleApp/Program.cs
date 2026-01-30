//using System.Xml.Linq;

//5️⃣ **Задача: Система управления библиотекой**

//Создайте класс под названием «Library», который представляет систему управления библиотекой.
//Класс `Library` должен иметь следующие свойства и методы:

//Характеристики:
//- `Name` (строка) — представляет имя библиотеки.
//— «Книги» — представляет коллекцию (например, список, массив) объектов книги.

//Методы:
//- `AddBook(Книга книги)` -Добавляет книгу в библиотеку.
//- `RemoveBook(Книга книги)` - Удаляет книгу из библиотеки.
//- `SearchBook(string title)` — ищет книгу по названию и возвращает объект книги.

//Создайте отдельный класс под названием Book со следующими свойствами:

//Характеристики:
//- `Title` (строка) – представляет название книги.
//- `Автор` (строка) — представляет автора книги.
//- `PublicationYear` (int) — представляет год публикации книги.

//Наслаждайтесь вызовом кодирования! 💪👩‍💻👨‍💻

using Domain.Models;
using Infrastructure.Services;

LibraryServices myLibrary = new LibraryServices("Библиотека МГУ");

Book book1 = new Book ("OOP", "Micle", 2000 );
Book book2 = new Book("Sql", "John", 2005);
Book book3 = new Book("C#", "Alex", 2010);

myLibrary.AddBook (book1);
myLibrary.AddBook (book2);
myLibrary.AddBook (book3);

myLibrary.ShowBook();
Console.WriteLine();

myLibrary.SearchBook("C#");
Console.WriteLine();

myLibrary.RemoveBook(book2);
Console.WriteLine();

myLibrary.ShowBook();


