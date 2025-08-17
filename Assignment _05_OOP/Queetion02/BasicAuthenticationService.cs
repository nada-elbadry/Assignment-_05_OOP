using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__05_OOP.Queetion02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "admin";
        private readonly string storedPassword = "1234";
        private readonly string storedRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}

