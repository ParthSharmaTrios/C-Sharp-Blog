using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using System.Net;
using System.Web.Script.Serialization;

namespace Blog
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/posts");



            JavaScriptSerializer js = new JavaScriptSerializer();
            BlogModels[] posts = js.Deserialize<BlogModels[]>(json);


            ViewBag.posts = posts;


            return View();
        }

        [HttpGet]
        public string post() {

            var id = Request["id"];

            var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/posts/"+id);

            return json;




           
        }
    }
}