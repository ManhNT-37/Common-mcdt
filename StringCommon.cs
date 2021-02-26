using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BPMC.Common
{
    public static class StringCommon
    {
        //Cat chuoi theo so luong ky tu
        public static string SubStringWithoutTag(string source)
        {
            try
            {                            
                int size = Convert.ToInt32(ConfigurationManager.AppSettings["SubSize"]);
                string returnStr = string.Empty;
                //Check exist tags in source text
                MatchCollection mC = Regex.Matches(source, @"<[^>]*>");
                if (mC.Count == 0)
                {
                    if (source.Length > size)
                        returnStr = source.ToString().Substring(0, size);
                }

                Dictionary<int, string> lstTag = new Dictionary<int, string>();

                //Get All Tag with index
                foreach (Match item in mC)
                {
                    lstTag.Add(item.Index, item.Value);
                }

                if (source.Length > size)
                {
                    //clear html and cut string
                    StringBuilder result = new StringBuilder(Regex.Replace(source, @"<[^>]*>", String.Empty).Substring(0, size));

                    //Add Tags into string
                    foreach (int index in lstTag.Keys)
                    {
                        if (index <= size - 1)
                            result.Insert(index, lstTag[index]);
                        else
                            result.Insert(result.Length, lstTag[index]);
                    }

                    //Clear empty tag and return
                    returnStr = result.ToString();
                }

                if (!string.IsNullOrEmpty(returnStr))
                {
                    int indexSpaceLast = returnStr.LastIndexOf(" ");
                    return returnStr.Substring(0, indexSpaceLast) + "...";
                }
                else
                    return source;
            }
            catch
            {
                return String.Empty;
            }
        }

        //Convert tieng viet co dau sang khong dau
        public static string ConvertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string ConvertStatus(int totalM)
        {
            try
            {
                if (totalM == 0)
                    return "";
                int hours = (totalM - totalM % 60) / 60;
                int days = (hours - hours % 8) / 8;
                string strDay = (days > 0) ? days + " ngày " : "";
                string strHour = ((hours - days * 8) > 0) ? (hours - days * 8) + " giờ " : "";
                string strMunite = ((totalM - hours * 60) > 0) ? (totalM - hours * 60) + " phút" : "";
                return strDay + strHour + strMunite;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetKieuTiepNhan(string menu)
        {
            int intKieuTiepNhan;
            try
            {
                switch (menu)
                {
                    case Menu.TIEP_NHAN_TRUC_TIEP:
                        intKieuTiepNhan = KieuTiepNhan.TRUC_TIEP;
                        break;
                    case Menu.TIEP_NHAN_QUA_MANG:
                        intKieuTiepNhan = KieuTiepNhan.QUA_MANG;
                        break;
                    case Menu.TIEP_NHAN_LIEN_THONG:
                        intKieuTiepNhan = KieuTiepNhan.LIEN_THONG;
                        break;
                    case Menu.TRA_KET_QUA_LIEN_THONG:
                        intKieuTiepNhan = KieuTiepNhan.LIEN_THONG;
                        break;
                    default:
                        intKieuTiepNhan = KieuTiepNhan.TAT_CA;
                        break;
                }
                return intKieuTiepNhan;

            }
            catch
            {
                return KieuTiepNhan.TAT_CA;
            }
        }

    }
}
