using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonMarfa : Vagon
    {
        private Marfa tipMarfa;
        private int capacitate;

        public VagonMarfa(int masa, int anFabricatie, Marfa tipMarfa, int capacitate) : base(masa , anFabricatie)
        {
            this.tipMarfa = tipMarfa;
            this.capacitate = capacitate;
        }

        
    }
}
