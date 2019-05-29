using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMash.Models;
using WebMash.Service.Interface;

namespace WebMash.Service
{
    public class UserService : IUserService
    {
        private readonly IDictionary<string, User> _users;

        public UserService(IDictionary<string, User> users) => _users = users;

        public Task<(bool, User)> ValidateUserCredentialsAsync(string username, string password)
        {
            var isValid = _users.ContainsKey(username) &&
                          string.Equals(_users[username].Password, password, StringComparison.Ordinal);
            var result = (isValid, isValid ? _users[username] : null);
            return Task.FromResult(result);
        }
    }
}
