using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraznanjaMarioBuric
{
    class Osoba
    {
        string ime;
        string prezime;
        int OIB;
        DateTime datumRodj;




        public Osoba(string ime, string prezime, int OIB, int godinaRodj)
        {
            this.ime = ime;

            this.prezime = prezime;

            this.OIB = OIB;

            this.GodinaRodj = godinaRodj;


        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int oib { get => OIB; set => OIB = value; }

        public int GodinaRodj { get => GodinaRodj; set => GodinaRodj = value; }

    }
}



    
