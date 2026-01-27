using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BusinessAccount : Account
    {
        public string Company {get;set;}
        public BusinessAccount() { }
        public BusinessAccount(string userName, string email, string company) : base(userName, email)
        {
            Company = company;
        }
        public void CompanyAdversting()
        {
            Console.WriteLine($"{Company} разместила рекламу.");
        }
        public override void DisplayProfile()
        {
            Console.WriteLine($"Бизнес-аккаунт: {UserName}, Email: {Email}, Компания: {Company}");
        }
    }
}
