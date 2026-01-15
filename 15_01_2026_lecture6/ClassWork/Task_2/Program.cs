
//Создайте класс под названием «Post» со следующими свойствами: `Text`, `Likes`, `Comments`.
//**Атрибутес:**
//***Text * *: текст сообщения.
//***Tikes * *: количество лайков публикации.
//* **Comments**: список комментариев к публикации.

//***SetPost(text) * *: Создает новое сообщение .

//* **Like()**: увеличивает количество лайков на один.

//* **Comment(comment)**: добавляет новый комментарий к сообщению.

//* **Info()**: отображает информацию о публикации, включая ее текст, количество лайков и комментариев.

Post post = new Post();
post.SetPost();
post.AddLike();
post.AddLike();
post.AddComment();
post.AddComment();
post.GetInfo();


class Post
{
    public string Text;
    public int Likes;
    public string[] Comment;

    public Post()
    {
        Likes = 0;
        Comment = new string[0];
    }

    public void SetPost()
    {
        Console.Write("Введите сообщение: ");
        string str = Console.ReadLine();
        Text = str;
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment()
    {
        Console.Write("Введите комментарий: ");
        string com = Console.ReadLine();
        int dlina = Comment.Length + 1;
        string[] newComments = new string[dlina];
        for (int i = 0; i < Comment.Length; i++)
        {
            newComments[i] = Comment[i];
        }
        newComments[dlina-1] = com;
        Comment = newComments;
    }

    public void GetInfo()
    {
        Console.WriteLine("\n---Post------");
        Console.WriteLine($"Text  : {Text}");
        Console.WriteLine($"Likes : {Likes}");
        Console.WriteLine("Comments:");

        for (int i = 0; i < Comment.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Comment[i]}");
        }
    }
}
