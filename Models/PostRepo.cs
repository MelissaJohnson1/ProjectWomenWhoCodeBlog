using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueensOfCodeProject.UI.Models
{
    public class PostRepo
    {

        public IEnumerable<Post> GetAllPosts()
        {
            using (var context = new QueensOfCodeDbContext())
            {
                var post = context.Posts;
                return post.ToList();
            }
            
        }

        public Post GetPostById(int id)
        {
            using (var context = new QueensOfCodeDbContext())
            {

                var post = context.Posts.FirstOrDefault(p => p.Id == id);
                return post;
            }

        }

        public void Add(Post blog)
        {
            using (var context = new QueensOfCodeDbContext())
            {
                context.Posts.Add(blog);
                context.SaveChanges();

            }
        }

        public void Edit(Post blog)
        {
            using (var context = new QueensOfCodeDbContext())
            {
                var post = context.Posts.FirstOrDefault(p => p.Id == blog.Id);

                post.Title = blog.Title;
                post.PostText = blog.PostText;
                post.ExpirationDate = blog.ExpirationDate;
                post.Featured = blog.Featured;
                post.Visible = blog.Visible;
                post.CreationDate = blog.CreationDate;
                post.ImageFilePath = blog.ImageFilePath;
                post.Id = blog.Id;

                context.SaveChanges();

            }
        }
        public void Delete(int id)
        {
            using (var context = new QueensOfCodeDbContext())
            {
                
                var post = context.Posts.FirstOrDefault(p => p.Id == id);
                context.Posts.Remove(post);
                context.SaveChanges();      

            }
        }
    }
}