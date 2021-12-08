using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs;
using Models.Models;


namespace Services.Interfaces
{
    public interface IUserService
    {
        public List<User> Users { get; }
        Task<RegisterSuccessDto> Register(User user, string password);
        Task<LoginSuccess> Login(LoginDto loginDto);
        Task<User> GetUser(string email);
    }
}
