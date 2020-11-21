using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Hashing
{

    public class Hashing
    {
        public static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }
        public static string HashPassword(string Password, string hasSalt)
        {
            return BCrypt.Net.BCrypt.HashPassword(Password, GetRandomSalt());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contoh Program Hashing");
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.Write("Masukan Username : ");
            string name = Console.ReadLine();

            Console.Write("Masukan Password : ");
            string password = Console.ReadLine();

            string salt = Hashing.GetRandomSalt();
            string hashing = Hashing.HashPassword(password, salt);

            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Password setelah di hashing " + hashing);

            Console.ReadKey();
        }
    }
}
