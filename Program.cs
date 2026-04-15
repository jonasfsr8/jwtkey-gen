using System.Security.Cryptography;

namespace jwtkey
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyBytes = RandomNumberGenerator.GetBytes(64);
            var key = Convert.ToBase64String(keyBytes);

            Console.WriteLine($"jwt_key: {key}");
        }
    }
}