using BookLibrary.DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BookLibrary.DataAccess.Implementations
{
    public class UserRepository : IUserRepository
    {
        public string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\repos\\BookLibrary\\BookLibrary.DataAccess\\db\\Db.mdf;Integrated Security=True";
        
        public string AddUser(User Data)
        {
            var conn = new SqlConnection(cn);
            string stmt = "INSERT INTO user (userid,firstname,lastname,email,passwordsalt,passwordhash) VALUES (@userid,@firstname,@lastname,@email,@passwordsalt,@passwordhash)";

            using (var cmd = new SqlCommand(stmt, conn))
            {
                cmd.Parameters.AddWithValue("@userid", Data.Id);
                cmd.Parameters.AddWithValue("@firstname", Data.FirstName);
                cmd.Parameters.AddWithValue("@lastname", Data.LastName);
                cmd.Parameters.AddWithValue("@email", Data.Email);
                cmd.Parameters.AddWithValue("@passwordsalt", Data.PasswordSalt);
                cmd.Parameters.AddWithValue("@passwordhash", Data.PasswordHash);
                conn.Open();
                var response = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return "ok";
        }

        public string DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByName(string Name)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
