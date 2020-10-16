using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskAPIs1.Models
{
    public class ArticlesViewModel
    {
        public int Id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleCategory { get; set; }
        public string ArticleContent { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> commentApproval { get; set; }
        public string Reason { get; set; }
    }
}