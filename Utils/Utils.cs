using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BPMC.Common.Utils
{
    public static class Utils
    {
        /// <summary>
        /// Convert url title
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConvertToUrlTitle(string name)
        {
            string strNewName = name;

            #region Replace unicode chars
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = name.Normalize(NormalizationForm.FormD);
            strNewName = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            #endregion

            #region Replace special chars
            string strSpecialString = "~\"“”#%&*:;<>?/\\{|}.+_@$^()[]`,!-'";

            foreach (char c in strSpecialString.ToCharArray())
            {
                strNewName = strNewName.Replace(c, ' ');
            }
            #endregion

            #region Replace space

            // Create the Regex.
            var r = new Regex(@"\s+");
            // Strip multiple spaces.
            strNewName = r.Replace(strNewName, @" ").Replace(" ", "-").Trim('-');

            #endregion)

            return strNewName;
        }

        public static bool IsNumeric(this String str)
        {
            double myNum = 0;
            if (Double.TryParse(str, out myNum))
            {
                return true;
            }
            return false;
        }

        public static string GetHash(string input)
        {
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();

            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(input);

            byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);

            return Convert.ToBase64String(byteHash);
        }

        public static byte[] UrlToBytes(string url)
        {
            Stream stream = null;
            byte[] buf;

            try
            {
                WebProxy myProxy = new WebProxy();
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                stream = response.GetResponseStream();

                using (BinaryReader br = new BinaryReader(stream))
                {
                    int len = (int)(response.ContentLength);
                    buf = br.ReadBytes(len);
                    br.Close();
                }

                stream.Close();
                response.Close();
            }
            catch (Exception exp)
            {
                buf = null;
            }

            return (buf);
        }

        public enum ApplicationTypes
        {
            JavaScript = 0,
            NativeConfidential = 1
        }        
    }
}
