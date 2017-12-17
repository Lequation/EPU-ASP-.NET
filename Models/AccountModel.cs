using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private EPUDbContext db = null;
        public AccountModel()
        {
            db = new EPUDbContext();
        }
        public bool Login(string UserName, string Password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@PasswordHash", MD5Hash(Password))
            };
            return db.Database.SqlQuery<bool>("Sp_User_Login @UserName, @PasswordHash", sqlParams).SingleOrDefault();
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
