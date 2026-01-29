using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public interface IUser
    {
        public void ReadListUser();
        public void AddUser(User user);
        public void DeleteUser(int id);
        public void UpdateUser(User user);
    }
}
