using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueensOfCodeProject.UI.Models
{
    public class DisplayPagePostViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Page> Pages { get; set; }
    }
}