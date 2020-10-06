using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaskalaskalaskala
{
    class Karakterek
    {
        List<Karakter> karakterLista;

        public Karakterek(string fajlNev)
        {
            this.karakterLista = new List<Karakter>();
            StreamReader r = new StreamReader(fajlNev);
            while (!r.EndOfStream)
            {
                string sor = r.ReadLine();
                string[] adatok = sor.Split(';');
                Karakter k = new Karakter(adatok[0], int.Parse(adatok[1]));
                this.karakterLista.Add(k);
            }

        }

        public List<Karakter> KarakterLista
        {
            get
            {
                return this.karakterLista;
            }
        }

    }
}
