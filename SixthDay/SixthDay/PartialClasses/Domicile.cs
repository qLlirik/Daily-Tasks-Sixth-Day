using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthDay.DB
{
    partial class Domicile
    {
        public string LightStr
        {
            get
            {
                return Light ? "Есть" : "Нет";
            }
        }

        public string WaterPipeStr
        {
            get
            {
                return WaterPipe ? "Есть" : "Нет";
            }
        }

        public string HeatingStr
        {
            get
            {
                return Heating ? "Есть" : "Нет";
            }
        }
    }
}
