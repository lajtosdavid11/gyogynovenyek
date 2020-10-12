﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyogynovenyek
{
    class novenyek
    {
        public string Nev { get; private set; }
        public string Resz { get; private set; }
        public int Kezd { get; private set; }
        public int Veg { get; private set; }
        public int Idotartam { get; private set; }

        public novenyek(string noveny)
        {
            string[] a = noveny.Split(';');
            Nev = a[0];
            Resz = a[1];
            Kezd = int.Parse(a[2]);
            Veg = int.Parse(a[3]);

            if (Veg > Kezd)
            {
                Idotartam = Veg - Kezd + 1;
            }
            else
            {
                Idotartam = 12 - Kezd + Veg + 1;
            }
            
        }


    }


}
