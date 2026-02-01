//### Задача 1
//Задача, связанная с ООП и немного сложнее:

//Рассмотрим систему для управления библиотекой книг.

//1. Создайте класс "Book" с атрибутами: название книги, автор, год издания и жанр.

//2. Создайте класс "Library" с атрибутами: список книг и методами:

//   -"add_book": добавляет новую книгу в список книг библиотеки.
//   - "remove_book": удаляет книгу из списка книг по ее названию. 
//   - "search_books_by_author": возвращает список книг заданного автора.
//   - "search_books_by_year": возвращает список книг, опубликованных после заданного года.
//   - "search_books_by_genre": возвращает список книг определенного жанра.

//3. Создайте объект класса "Library" и проверьте работу каждого из методов.

//4. Добавьте в класс "Library" метод "get_book_count", который будет возвращать общее количество книг в библиотеке.

//Теперь ваша система для управления библиотекой книг будет иметь основные функции добавления,
//удаления и поиска книг, а также возможность получить общее количество книг в библиотеке. 📚                                      
//Удачи! 

using Domain.Models;
using Infrastructure.Services;

Book book1 = new Book("Title1", "Author1", 2020, "Genre1");
Book book2 = new Book("Title2", "Author1", 2020, "Genre2");
Book book3 = new Book("Title3", "Author2", 2022, "Genre3");

LibraryServices libraryServices = new LibraryServices();
libraryServices.AddBook(book1);
libraryServices.AddBook(book2);
libraryServices.AddBook(book3);

Console.WriteLine("Kolichestvo knig : "+ libraryServices.GetBookCount());

var ListAuthor = libraryServices.SearchBooksByAuthor("Author1");
var ListGenre = libraryServices.SearchBooksByGenre("Genre2");
var ListYear = libraryServices.SearchBooksByYear(2020);

libraryServices.RemoveBook(book1);
