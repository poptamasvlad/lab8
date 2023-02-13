using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Tren
    {
        private string nume;
        Locomotiva locomotiva;
        List<Vagon> listaVagoane = new List<Vagon>();

        private static int totalLocuri = 0;

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }

        public void AdaugaVagon(Vagon vagon)
        {
            listaVagoane.Add(vagon);
        }

        public void PleacaDinGara()
        {
            foreach(Vagon vagon in listaVagoane)
            {
                if(vagon is VagonPersoane)
                {
                    (vagon as VagonPersoane).InchideUsi();
                }
                if(vagon is VagonClasa1)
                {
                    (vagon as VagonClasa1).PornesteAC();
                }
            }
            locomotiva.Porneste();
        }

        public void OpresteInGara()
        {
            locomotiva.Opreste();
            foreach (Vagon vagon in listaVagoane)
            {
                if(vagon is VagonPersoane)
                {
                    (vagon as VagonPersoane).DeschideUsi();
                }
                if(vagon is VagonClasa1)
                {
                    (vagon as VagonClasa1).OpresteAC();
                }
            }
        }

        public int GetNumarDeLocuri()
        {
            foreach (Vagon vagon in listaVagoane)
            {
                if (vagon is VagonPersoane)
                {
                    totalLocuri += (vagon as VagonPersoane).NumarDeLocuri;
                }
            }
            return totalLocuri;
        }

        
    }
}
