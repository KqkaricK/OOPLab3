using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Materick
    {
        string materick_name;
        int kol = 1;
        public string Manterick_name { get { return materick_name; } set { materick_name = value; } }
        public int Kol { get { return kol; } }

    }
    class Planet
    {
        int i = 0;
        string planet_name;
        Materick X;
        public string Planet_name { get { return planet_name; } set { planet_name = value; } }

        public string Get_Materick_name { get { return X.Manterick_name; } }

        public Planet(Materick x, string planet_name)
        {
            this.planet_name = planet_name;
            X = x;
            i += x.Kol;
        }
        public int Kol { get { return i; } }
    }
}
