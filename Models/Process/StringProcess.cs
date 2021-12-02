using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models.Process{
    public class StringProcess{
        public string GenerateKey(string id){
            string strKey = "";
            string numPart = "", strPart = "";
            numPart = Regex.Match(id,@"\d+").Value;
            strPart = Regex.Match(id,@"\D+").Value;
            int intPart = (Convert.ToInt32(numPart)+1);
            for (int i = 0;i <numPart.Length - intPart.ToString().Length;i++)
            {
                strPart +="0";
            }
            strKey = strPart +numPart;
            return strKey;
        }
    }
}