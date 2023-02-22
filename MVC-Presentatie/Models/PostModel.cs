namespace MVC_Presentatie.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public static List<Post> GetPosts()
    {
        return new List<Post>()
        {
            new() { Id = 1, Title = "Post 1", Body = "Ik ben post één :)" },
            new() { Id = 2, Title = "Post 2", Body = "Ik ben post twee :)" },
            new() { Id = 3, Title = "Post 3", Body = "Ik ben post drie :)" }
        };
    }

    public static Post getPost(int id)
    {
        List<Post> posts = GetPosts();

        return posts.FirstOrDefault(x => x.Id == id);
    }
}