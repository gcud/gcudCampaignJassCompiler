using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcud战役jass编译器
{
    public static class Language
    {
        public static Dictionary<string,string> ReadLanguageFile(string LanguageFileText)
        {
         Dictionary<string, string> AllLanguageText=new Dictionary<string, string>();
            System.IO.StreamReader s = new System.IO.StreamReader(LanguageFileText);
            string LanguageString = "";
            while ((LanguageString = s.ReadLine()) != null)
            {
                string[] lsa = LanguageString.Split('=');
               AllLanguageText[lsa[0]] = lsa[1];
            }
            s.Close();
            return AllLanguageText;
        }
    }
}
