using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NisanOdev3.Interface;

namespace NisanOdev3.Classes
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar}ında harcama yapıldı";
        }
    }
}
