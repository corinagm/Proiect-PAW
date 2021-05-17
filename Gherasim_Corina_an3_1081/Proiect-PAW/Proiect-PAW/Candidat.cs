using Proiect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
   public class Candidat:ICloneable, IComparable
    {
        private string nume;
        private string CNP;
        private int varsta;
        private string email;
        private char sex;
        private float medie;
        string[] optiuni;

        public string Nume { get => nume; set => nume = value; }
        public string CNP1 { get => CNP; set => CNP = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string Email { get => email; set => email = value; }
        public char Sex { get => sex; set => sex = value; }
        

        public float Medie { get => medie; set => medie = value; }
        /*public string[] Optiuni { get => optiuni; set
            {
                for (int i = 0; i <optiuni.Length; i++)
                    optiuni[i] = value[i];
            }
        }*/

          
        

        public string this[int index]
        {
            get
            {
                if (optiuni != null && index >= 0 && index <3)
                    return optiuni[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index <3)
                { optiuni[index] = value; }
            }

        }

        public Candidat(string nume, string cNP, int varsta, string email,char s, float medie, string[] opt)
        {
            this.nume = nume;
            this.CNP = cNP;
            this.varsta = varsta;
            this.email = email;
            this.sex = s;
            this.medie = medie;
            this.optiuni = new string[3];
            for(int i=0; i<3; i++)
            {
                this.optiuni[i] = opt[i];
            }
        }

        public Candidat()
        {

            this.nume = "";
            this.CNP = "";
            this.varsta = 0;
            this.email = "";
            this.sex = 'F';
            this.medie = 0;
            this.optiuni = new String[3];
            for (int i = 0; i < 3; i++)
            {
                this.optiuni[i] = "";
            }
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Candidat c = (Candidat)obj;
            return string.Compare(this.CNP, c.CNP);

        }

        public override string ToString()
        {
            string rezultat = "Candidatul pe nume " + this.nume + " cu CNP-ul " + this.CNP + ", sexul " + this.sex + " are " + this.varsta + " ani." + " Email-ul acestuia este: " + this.email + ". A obtinut la bacalaureat media de: " + this.medie + " si a ale sa se inscrie la: ";
            for(int i=0; i<3; i++)
            {
                rezultat += this.optiuni[i] + ", ";
            }
            return rezultat;
        }
    }
}
