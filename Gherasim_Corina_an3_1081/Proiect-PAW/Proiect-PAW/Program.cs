using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //citire din fisier
       /*     string[] lines = File.ReadAllLines("facultati.txt");
            foreach( string line in lines)
            {
                string[] col = line.Split(',');
                string denumire = col[0];
                int nrDisponibile = Convert.ToInt32(col[1]);
                float ultimaMEdie =(float) Convert.ToDouble(col[2]);
                string descriere = col[3];
                Facultate fac = new Facultate(denumire, nrDisponibile, ultimaMEdie,descriere);
                Console.WriteLine(fac.ToString());
            }*/

           // Candidat c = new Candidat();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMeniuPrincipal());
        }
    }
}
