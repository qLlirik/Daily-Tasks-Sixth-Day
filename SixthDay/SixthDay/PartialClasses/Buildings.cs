using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthDay.DB
{
    partial class Buildings
    {
        public string MySelfStr
        {
            get
            {
                return MySelf ? "Да" : "Нет";
            }
        }
    }
}
