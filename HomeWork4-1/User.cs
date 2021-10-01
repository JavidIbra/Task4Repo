using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsSingle { get; set; }
        public DateTime DayOfBirth { get; set; }
        public Post[] post;
        public Comment[] commen;

        public User()
        { 
        } 
        public User( string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public User(int userId, bool isSingle, string email)
        {
            this.UserId = userId;
            this.IsSingle = isSingle;
            this.Email = email;
        }

    }
}
