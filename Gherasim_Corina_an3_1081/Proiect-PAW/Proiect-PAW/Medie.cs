using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1
{
    class Medie : ICloneable, IComparable
    {
        private float nota;
        private string materie;


        public Medie()
        {
            this.Nota = 0;
            this.Materie = null;
        }

        public Medie(float nt, string mat)
        {
            this.Nota = nt;
            this.Materie = mat;
        }

        public float Nota
        {
            get { return this.nota; }
            set { if (value >= 1 && value <= 10) this.nota = value; }
        }
        public string Materie
        {
            get { return this.materie; }
            set { this.materie = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Medie med = (Medie)obj;
            if (this.nota > med.nota)
                return 1;
            else
                return string.Compare(this.materie, med.materie);
        }

        public static Medie operator +(Medie m, int nr)
        {
            if (m.nota + nr <= 10)
            {
                m.nota += nr;
            }
            return m;
        }
    }
}
