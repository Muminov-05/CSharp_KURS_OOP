

using System;
using System.Collections.Generic;

Post<int, string>.CreatePost(1, "Title1", "Description1", "Topic1", "Author1", "Date1");
Post<int, string>.CreatePost(2, "Title2", "Description2", "Topic1", "Author1", "Date2");
Post<int, string>.CreatePost(3, "Title3", "Description3", "Topic2", "Author1", "Date2");

Post<int, string>.ShowAllPost();
Console.WriteLine();

var NewListPostTopics = Post<int, string>.GetPostsByTopic("Topic1");
Console.WriteLine();

var NewListPostAuthor = Post<int, string>.GetPostsByAuthor("Author1");
Console.WriteLine();

var NewListPostDate = Post<int, string>.GetPostsByDate("Date1"); 

Post<int, string>.DeletePost(1);

   

public class Post<TId, TString>
{
    private TId Id { get; set; }
    private TString Title { get; set; }
    private TString Description { get; set; }
    private TString Topic { get; set; }
    private TString Author { get; set; }
    private TString Date { get; set; }

    private static List<Post<TId, TString>> posts = new();

    public static void CreatePost(TId id, TString title, TString description, TString topic, TString author, TString date)
    {
        var post = new Post<TId, TString>
        {
            Id = id,
            Title = title,
            Description = description,
            Topic = topic,
            Author = author,
            Date = date
        };
        posts.Add(post);
    }

    public static List<Post<TId, TString>> GetPostsByTopic(TString topic)
    {
        var newPost = new List<Post<TId, TString>>();
        for (var i = 0; i < posts.Count; i++)
        {
            if (posts[i].Topic.Equals(topic))
            {
                newPost.Add(posts[i]);
            }
        }
        return newPost;
    }

    public static List<Post<TId, TString>> GetPostsByAuthor(TString author)
    {
        var newPost = new List<Post<TId, TString>>();
        for (var i = 0; i < posts.Count; i++)
        {
            if (posts[i].Author.Equals(author))
            {
                newPost.Add(posts[i]);
            }
        }
        return newPost;
    }

    public static List<Post<TId, TString>> GetPostsByDate(TString date)
    {
        var newPost = new List<Post<TId, TString>>();
        for (var i = 0; i < posts.Count; i++)
        {
            if (posts[i].Date.Equals(date))
            {
                newPost.Add(posts[i]);
            }
        }
        return newPost;
    }

    public static void DeletePost( TId id)
    {
        posts.RemoveAt(Convert.ToInt32(id));
    }

    public static void ShowAllPost()
    {
        foreach (var p in posts)
        {
            Console.WriteLine($"{p.Id}  {p.Title}  {p.Description}  {p.Topic}  {p.Author}  {p.Date}");
        }
    }
}


