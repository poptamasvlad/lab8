using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class VagonClasa1 : VagonPersoane
    {

        public VagonClasa1(int masa, int anFabricatie, int numarDeLocuri) : base(masa, anFabricatie, numarDeLocuri)
        {
        }

        public void PornesteAC()
        {
            Console.WriteLine("A pornit aerul conditionat. ");
        }

        public void OpresteAC()
        {
            Console.WriteLine("S-a oprit aerul conditionat. ");
        }
    }
}
