using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Facultate: ICloneable, IComparable
    {
        private string denumire;
        private int nrLocuriDisponibile;
        private float ultimaMedie;
        private string descriere;

        public Facultate(string denumire, int nrDisponibile, float ultimaMedie, string descriere)
        {
            this.Denumire = denumire;
            this.NrDisponibile = nrDisponibile;
            this.UltimaMedie = ultimaMedie;
            this.Descriere = descriere;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public int NrDisponibile { get => nrLocuriDisponibile; set => nrLocuriDisponibile = value; }
        public float UltimaMedie { get => ultimaMedie; set => ultimaMedie = value; }
        public string Descriere { get => descriere; set => descriere = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Facultate fac = (Facultate)obj;
            if (this.ultimaMedie < fac.ultimaMedie)
                return -1;
            else if (this.ultimaMedie > fac.ultimaMedie)
                return 1;
            else return string.Compare(this.denumire, fac.denumire);
        }

        public override string ToString()
        {
            return "Facultatea " + this.denumire + " are " + this.nrLocuriDisponibile + " locuri disponibile." + " Ultima medie a anul trecut este " + this.ultimaMedie + ". Descrierea facultatii: " + this.descriere;
        }

        public static Facultate operator+(Facultate fac, int nr)
        {
            fac.nrLocuriDisponibile += nr;
            return fac;
        }

        public static Facultate operator +(int nr, Facultate fac)
        {
            return fac + nr;
        }


    }
}
