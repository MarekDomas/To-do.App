using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do
{
    public class Ukol
    {
        string nazev;
        public string Nazev { get { return nazev; } }
        DateTime? termin;
        public DateTime? Termin { get { return termin; } }
        public enum Pokrok
        {
            Zadáno,
            Rozpracováno,
            Hotovo
        }

        public Pokrok CurrentProgress { get; set; }
        public Ukol(string Nazev, DateTime? Termin, Pokrok Progress)
        {
            this.nazev = Nazev;
            this.termin = Termin;
            this.CurrentProgress = Progress;
        }

        public override string ToString()
        {
            return $"{Nazev}, {Termin}, {CurrentProgress}";
        }
    }
}
