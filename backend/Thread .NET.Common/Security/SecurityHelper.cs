using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;
using Thread_.NET.Common.Security.SecurityProvider;

namespace Thread_.NET.Common.Security
{
    public static class SecurityHelper
    {
        public static string HashPassword(string password, byte[] salt)
        => Convert.ToBase64String(
                    KeyDerivation.Pbkdf2(
                        password: password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 10000,
                        numBytesRequested: 256 / 8
                    )
                );

        public static byte[] GetRandomBytes(int length = 32)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var salt = new byte[length];
                randomNumberGenerator.GetBytes(salt);

                return salt;
            }
        }

        /// <summary>
        /// For seeding and test purposes only!!!
        /// </summary>
        public static byte[] GetDeterminedBytes(int length = 32)
        {
            using (var randomNumberGenerator = new DeterministicRandomGenerator())
            {
                var salt = new byte[length];
                randomNumberGenerator.GetBytes(salt);

                return salt;
            }
        }

        public static bool ValidatePassword(string password, string hash, string salt)
        {
            return HashPassword(password, Convert.FromBase64String(salt)) == hash;
        }
    }
}
