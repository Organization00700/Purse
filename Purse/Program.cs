﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessCard.Class busCrd = new BusinessCard.Class(1000);
            busCrd.Subtract(200);
        }
    }
}
