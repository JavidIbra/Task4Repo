using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    public class Post
    {
        public string Text { get; set; }
        public DateTime SharedDate { get; set; }
        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public int ShareCount { get; set; }
        public Comment[] comment;
    }
}
