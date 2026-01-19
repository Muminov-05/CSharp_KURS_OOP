//Напишите класс под названием `Book`, который представляет книгу с названием, автором и годом публикации.

//1. Создайте общедоступный класс под названием Book.

//2. Создайте конструктор, который принимает параметры `title`, `author` и `year` для инициализации свойств объекта.
//3. Добавьте метод `GetInfo()`, который будет отображать информацию о книге в формате строки,
//    например: «Название: Агар ҷавонӣ медонист…, Автор: Башир Усмон, Год издания: 2019».
//4.Добавьте метод `IsPublishedRecently()`, который будет возвращать true, если книга была опубликована после 2010 года, и false в противном случае.

Book book = new Book("Dokhunda", "Sadriddin Ayni", 2000);
book.GetInfo();
if (book.IsPublishedRecently())
{
    Console.WriteLine(" On bul opublicovan posle 2010 ");
}
else
{
    Console.WriteLine("  On bul opublicovan pered 2010 ");
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book() {}
    public Book(string Title, string Author, int Year)
    {
        this.Title = Title; this.Author = Author; this.Year = Year;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Год издания: {Year}");
    }
    public bool IsPublishedRecently()
    {
        if( Year > 2010 )
            return true;
        return false;
    }
}