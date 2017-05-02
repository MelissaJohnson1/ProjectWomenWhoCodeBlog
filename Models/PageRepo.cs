using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueensOfCodeProject.UI.Models
{
    public class PageRepo
    {
        public IEnumerable<Page> GetAllPages()
        {
            using (var context = new QueensOfCodeDbContext())
            {
                var page = context.Pages;
                return page.ToList();
            }

        }

        public Page GetPageById(int id)
        {
            using (var context = new QueensOfCodeDbContext())
            {

                var page = context.Pages.FirstOrDefault(p => p.Id == id);
                return page;
            }

        }

        public void Add(Page webpage)
        {
            using (var context = new QueensOfCodeDbContext())
            {
                context.Pages.Add(webpage);
                context.SaveChanges();

            }
        }

        public void Edit(Page webpage)
        {
            using (var context = new QueensOfCodeDbContext())
            {
                var page = context.Pages.FirstOrDefault(p => p.Id == webpage.Id);

                page.Title = webpage.Title;
                page.PostText = webpage.PostText;
                page.ImageFilePath = webpage.ImageFilePath;
                page.Id = webpage.Id;

                context.SaveChanges();

            }


        }
        public void Delete(int id)
        {
            using (var context = new QueensOfCodeDbContext())
            {

                var page = context.Pages.FirstOrDefault(p => p.Id == id);
                context.Pages.Remove(page);
                context.SaveChanges();

            }

        }
    }
}