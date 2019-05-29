using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMash.Models;

namespace WebMash.Service.Interface
{
    public interface IUserService
    {
        Task<(bool, User)> ValidateUserCredentialsAsync(string username, string password);
    }
}
