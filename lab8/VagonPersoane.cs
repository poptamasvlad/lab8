using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonPersoane : Vagon
    {
        private int numarDeLocuri;

        public VagonPersoane(int masa, int anFabricatie, int numarDeLocuri) : base(masa, anFabricatie)
        {
            this.numarDeLocuri = numarDeLocuri;

        }

        public void InchideUsi()
        {
            Console.WriteLine("Se inchid usile. ");
        }

        public void DeschideUsi()
        {
            Console.WriteLine("Se deschid usile. ");
        }

        public int NumarDeLocuri
        {
            get { return numarDeLocuri; }
        }
    }
}
