using QueensOfCodeProject.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueensOfCodeProject.UI.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult ListPosts()
        {
            PostRepo reap = new PostRepo();
            var model = reap.GetAllPosts();

            return View(model);

        }

        [HttpGet]
        public ActionResult DeletePost(int id)
        {
            PostRepo reap = new PostRepo();
            var model = reap.GetPostById(id);
            return View(model);

        }

        [HttpPost]
        public ActionResult DeletePost(Post blog)
        {
            PostRepo reap = new PostRepo();
            reap.Delete(blog.Id);
            return RedirectToAction("ListPosts");
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePost(Post blog)
        {

            if (ModelState.IsValid)
            {
               PostRepo pr = new PostRepo();

                var fabpost = new Post();
                fabpost.Title = blog.Title;
                fabpost.CreationDate = blog.CreationDate;
                fabpost.PostText = blog.PostText;
                fabpost.ExpirationDate = blog.ExpirationDate;
                pr.Add(fabpost);
                return RedirectToAction("ListPosts");

            }
            return View(blog);

        }
        [HttpGet]
        public ActionResult EditPost(int id)
        {

            PostRepo reap = new PostRepo();
            var model = reap.GetPostById(id);
            return View(model);
           
        }

        [HttpPost]
        public ActionResult EditPost(Post blog)
        {
            if (ModelState.IsValid)
            {
                PostRepo pr = new PostRepo();

                pr.Edit(blog);
                return RedirectToAction("ListPosts");

            }
            return View(blog);

        }

        [HttpGet]
        public ActionResult ListPages()
        {
            PageRepo reap = new PageRepo();
            var model = reap.GetAllPages();

            return View(model);

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            PageRepo reap = new PageRepo();
            var model = reap.GetPageById(id);
            return View(model);

        }

        [HttpPost]
        public ActionResult DeletePage(Page webpage)
        {
            PageRepo reap = new PageRepo();
            reap.Delete(webpage.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreatePage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePage(Page webpage)
        {

            if (ModelState.IsValid)
            {
                PageRepo pr = new PageRepo();

                var fabpost = new Page();
                fabpost.Title = webpage.Title;
                fabpost.PostText = webpage.PostText;
                
                pr.Add(fabpost);
                return RedirectToAction("Index");

            }
            return View(webpage);

        }
        [HttpGet]
        public ActionResult EditPage(int id)
        {

            PageRepo reap = new PageRepo();
            var model = reap.GetPageById(id);
            return View(model);

        }

        [HttpPost]
        public ActionResult EditPage(Page webpage)
        {
            if (ModelState.IsValid)
            {
                PageRepo pr = new PageRepo();

                pr.Edit(webpage);
                return RedirectToAction("Index");

            }
            return View(webpage);

        }
    }
}