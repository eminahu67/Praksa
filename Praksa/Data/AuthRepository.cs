﻿using Microsoft.EntityFrameworkCore;
using Praksa.Models;

namespace Praksa.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            if(await UserExists(user.UserName))
            {
                response.Success = false;
                response.Message = " User already exists.";
                return response;
            }


            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PassworddHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            
            response.Data = user.Id;
            return response;
        }

        public Task Register(User user, object password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.UserName.ToLower().Equals(username.ToLower())))
            {
                return true;
            }
                return false;
                    
                    
                    
        } 
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            }
        }
    }  
}
