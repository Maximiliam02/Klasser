using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon f = new Fordon();
            f.setTillverkare("Stefan");
            f.setModell("volvo");
            f.setÅrsmodell(2020);
            f.setVikt(900);

           
        }

    }
}
