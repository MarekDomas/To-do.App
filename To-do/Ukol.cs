using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do
{
    public class Ukol
    {
        public string Nazev;
        public DateTime? Termin;
        public enum Pokrok
        {
            Zadáno,
            Rozpracováno,
            Hotovo
        }

        public Pokrok CurrentProgress { get; set; }
        public Ukol(string Nazev, DateTime? Termin, Pokrok Progress)
        {
            this.Nazev = Nazev;
            this.Termin = Termin;
            this.CurrentProgress = Progress;
        }

        public override string ToString()
        {
            return $"{Nazev}, {Termin}, {CurrentProgress}";
        }
    }
}
