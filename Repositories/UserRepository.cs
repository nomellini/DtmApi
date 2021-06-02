using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebDatamaceApi.Models;

namespace WebDatamaceApi.Repositories
{
    public class UserRepository
    {
        private readonly CoreDbContext _context;

        public UserRepository(CoreDbContext context)
        {
            _context = context;
        }

        public AdmUsuario Get(string Email, string password)
        {

            string senhaMd5 = CreateMD5(CleanInjection(password));

            return _context.AdmUsuario.Where(x => x.Email.ToLower() == CleanInjection(Email) && x.Senha == senhaMd5).FirstOrDefault();
        }

        public string CleanInjection(string text)
        {
            text = text.Replace("'", String.Empty);
            text = text.Replace("\"", String.Empty);
            text = text.Replace("´", String.Empty);
            text = text.Replace(";", String.Empty);
            text = text.Replace("--", String.Empty);
            text = text.Replace("/", String.Empty);

            string[] lixos = new string[] { "select", "drop", ";", "--", "insert", "delete", "xp_" };
            foreach (string lixo in lixos)
            {
                text = text.Replace(lixo, String.Empty);
            }

            return text;
        }

        private static string CreateMD5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
