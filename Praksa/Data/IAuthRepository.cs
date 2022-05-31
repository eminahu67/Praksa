﻿using Praksa.Models;
using System.Threading.Tasks;
namespace Praksa.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
        Task Register(User user, object password);
    }
}
