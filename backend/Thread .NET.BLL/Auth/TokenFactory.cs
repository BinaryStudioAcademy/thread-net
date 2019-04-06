using System;
using System.Security.Cryptography;

namespace Thread_.NET.BLL.Auth
{
    public sealed class TokenFactory
    {
        private const int SIZE = 32;

        public string GenerateToken()
        {
            var randomNumber = new byte[SIZE];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
