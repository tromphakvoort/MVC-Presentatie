using Microsoft.AspNetCore.Mvc;
using MVC_Presentatie.Models;

namespace MVC_Presentatie.Controllers;

public class PostController : Controller
{
    // GET
    public IActionResult Index()
    {
        List<Post> posts = Post.GetPosts();

        ViewBag.Posts = posts;
        
        return View();
    }

    public IActionResult BlogPost()
    {
        int id  = Int32.Parse((string)Url.ActionContext.RouteData.Values["id"]);
        
        Post post = Post.getPost(id);

        ViewBag.Post = post;
        
        return View();
    }
}