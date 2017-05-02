using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueensOfCodeProject.UI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Featured { get; set; }
        public int Visible { get; set; }
        public string ImageFilePath { get; set; }
        [AllowHtml]
        public string PostText { get; set; }

        public virtual List<Category> Categories { get; set; }
    }
}