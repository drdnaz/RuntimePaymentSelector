using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NisanOdev3.Interface;

namespace NisanOdev3.Classes
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
         return $"kredi kartı ile {tutar}ında harcama yapıldı";
        }
    }
}
