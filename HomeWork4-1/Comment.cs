using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    public class Comment
    {
        public Comment()
        {
        }
        public Comment(User usr)
        {
            this.user = usr; 
        }

        public string Text { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentCount { get; set; }

        public User user;

    }
}
