using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueensOfCodeProject.UI.Models
{
    public class Page
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string ImageFilePath { get; set; }
        [AllowHtml]
        public string PostText { get; set; }
      
    }
}