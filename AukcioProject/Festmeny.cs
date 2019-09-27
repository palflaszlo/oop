using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProject
{
    class Festmeny
    {
        private string cim;
        private string festo;
        private string stilus;
        private int licitekSzama = 0;
        private int legmagasabbLicit = 0;
        private DateTime legutolsoLicitIdeje;
        private bool elkelt = false;

        public string Cim { get => cim; set => cim = value; }
        public string Festo { get => festo; set => festo = value; }
        public string Stilus { get => stilus; set => stilus = value; }
        public int LicitekSzama { get => licitekSzama; set => licitekSzama = value; }
        public int LegmagasabbLicit { get => legmagasabbLicit; set => legmagasabbLicit = value; }
        public DateTime LegutolsoLicitIdeje { get => legutolsoLicitIdeje; set => legutolsoLicitIdeje = value; }
        public bool Elkelt { get => elkelt; set => elkelt = value; }

        public Festmeny(string cim, string festo, string stilus, int licitekSzama, int legmagasabbLicit, DateTime legutolsoLicitIdeje, bool elkelt)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
            this.licitekSzama = licitekSzama;
            this.legmagasabbLicit = legmagasabbLicit;
            this.legutolsoLicitIdeje = legutolsoLicitIdeje;
            this.elkelt = elkelt;
        }

        public override string ToString()
        {
            return string.Format("{0} című. Szerzője: {1}. \nStílusa: {2}. Eddigi licitek száma{3}. \nA legmagasabb licit értéke: {4}$. A legutolsó licit ideje: {5}.\n  Elkelt-e: {6}",
                this.cim, this.festo, this.stilus, this.licitekSzama, this.legmagasabbLicit, this.legutolsoLicitIdeje, this.elkelt);
        }

        public void Licit()
        {
            if (elkelt == false && legmagasabbLicit <= 2000)
            {
                legmagasabbLicit += 500;
                licitekSzama++;
                legutolsoLicitIdeje = DateTime.Now;

                
                
                 //--------------ezt kell meghívni külön nem cw-ben

            }
            if (legmagasabbLicit >= 2000)
            {
                elkelt = true;

            }

        }

        public void BekertLicit(int mertek)
        {
            legmagasabbLicit += mertek;
            licitekSzama++;
            legutolsoLicitIdeje = DateTime.Now;
            if (legmagasabbLicit >= 3000)
            {
                elkelt = true;

            }
        }

        /*
        public string Licit2()
        {
            if (elkelt == true)
            {
                return "Hiba. A licitált termék már elkelt!"; //----------ezt kell meghívni cw-be
            }
            else
            {
                return "fasz";
            }
        }
        */

    }
}
