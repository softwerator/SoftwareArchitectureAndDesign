﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class DusmanTank : IDusman
    {
        public string DusmanAdi()
        {
            return "Tankın adı Siku Zırhlı Tank'tır.";
        }

        public string Hizlan()
        {
            return "Tank hızlanabilir.";
        }

        public string SilahKullan()
        {
            return "Tank ateş edebilir.";
        }
    }
}
