using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helinski
{
    internal class Adatok
    {
        public int Helyezes { get; set; }
        public int SportoloSzama { get; set; }
        public string SportagNeve { get; set; }
        public string VersenyszamNeve { get; set; }

        public Adatok(string sor)
        {
            string[] v = sor.Split(' ');
            this.Helyezes = int.Parse(v[0]);
            this.SportoloSzama = int.Parse(v[1]);
            this.SportagNeve = v[2];
            this.VersenyszamNeve = v[3];
        }
    }
}
