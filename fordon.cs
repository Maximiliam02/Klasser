using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Fordon
    {
        Fordon f = new Fordon();
        private string tillverkare;
        private string modell;
        private int årsmodell;
        private int vikt;

        public void setTillverkare(string a) { tillverkare = a; }
        public string getTillverkare() { return tillverkare; }

        public void setModell(string b) { modell = b; }
        public string getModell() { return modell; }

        public void setÅrsmodell(int c) { årsmodell = c; }
        public int getÅrsmodell() { return årsmodell; }

        public void setVikt(int d) { vikt = d; }
        public int getVikt() { return vikt; }



    }
}





}
