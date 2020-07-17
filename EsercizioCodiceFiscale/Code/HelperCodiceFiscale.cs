using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCodiceFiscale.Code
{
    /*
 Assemini a474
Cagliari b354
Genova d969
Iglesias e281
Milano f205
*/
    static class HelperCodiceFiscale
    {
        public static Dictionary<string, string> CodiciComuni = new Dictionary<string, string>
        {
            {"assemini", "a474" },
            {"cagliari", "b354" },
            {"genova", "d969" },
            {"iglesias", "e281" },
            {"milano", "f205" },
            {"portoscuso", "g922" }
        };
        public static string GetCodiceCatastale(string comune)
        {
            //if (CodiciComuni.ContainsKey(comune))
            //{
            //    return CodiciComuni[comune];
            //}
            //return null;

            return CodiciComuni.ContainsKey(comune.ToLower()) ? CodiciComuni[comune.ToLower()] : null;
        }
        public static string GetCodiceCatastaleConSwitch(string comune)
        {
            switch (comune.ToLower())
            {
                case "cagliari":
                    return "b354";
                case "assemini":
                    return "a474";
                case "genova":
                    return "d969";
                case "iglesias":
                    return "e281";
                case "milano":
                    return "f205";
                default:
                    return null;
            }
        }
    }
}
