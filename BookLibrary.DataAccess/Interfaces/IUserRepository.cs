using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.DataAccess.Interfaces
{
  public  interface IUserRepository
    {

        string AddUser(User Data);

        string DeleteUser(int Id);

        string UpdateUser(int Id);

        List<User> GetAllUsers();

        List<User> GetUsersByName(string Name);

        User GetUserById(int Id);

    }
}
