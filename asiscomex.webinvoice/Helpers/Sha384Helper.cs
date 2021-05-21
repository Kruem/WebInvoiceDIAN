using System;
using System.Security.Cryptography;
using System.Text;

namespace Asiscomex.Webinvoice.Helpers
{
    public static class Sha384Helper
    {
        public static string BuildSha384(params string[] param)
        {
            var initialData = string.Concat(param);
            var data = Encoding.UTF8.GetBytes(initialData);
            SHA384 sha384 = new SHA384Managed();
            var result = sha384.ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", string.Empty).ToLower();
        }
    }
}
