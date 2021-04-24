using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Window
    {
        int kol_window;
        public int Kol_window { get { return kol_window; } set { kol_window = value; } }
    }

    class Doar
    {
        int kol_doar;
        public int Kol_doar { get { return kol_doar; } set { kol_doar = value; } }
    }

    class Home
    {
        bool close = false;
        Window a = new Window();
        Doar b = new Doar();
        public bool Close_Or_Open { get { return close; } set { close = value; } }
        public Window A { get { return a; } set { a = value; } }
        public Doar B { get { return b; } set { b = value; } }
    }
}
