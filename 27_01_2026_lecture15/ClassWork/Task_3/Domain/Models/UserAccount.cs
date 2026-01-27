using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserAccount : Account
    {
        public string PostName {  get; set; }
        public UserAccount() {}
        public UserAccount(string userName, string email , string postName) : base(userName, email)
        {
            PostName = postName;
        }
        public void LikePost(string postName)
        {
            Console.WriteLine($"{UserName} лайкнул пост: {postName}");
        }
        public override void DisplayProfile()
        {
            Console.WriteLine($"Пользователь: {UserName}, Email: {Email}, Пост: {PostName}");
        }
    }
}
