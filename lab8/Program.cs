using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Locomotiva locomotiva = new Locomotiva();
            Tren tren = new Tren("T1", locomotiva);

            Vagon vagon1 = new Vagon(1200, 1978);
            Vagon vagon2 = new VagonMarfa(1500, 1981, Marfa.cereale, 200);
            Vagon vagon3 = new VagonMarfa(980, 1998, Marfa.otel, 400);
            Vagon vagon4 = new VagonPersoane(1100, 2000, 80);
            Vagon vagon5 = new VagonClasa1(1250, 1988, 50);

            tren.AdaugaVagon(vagon1);
            tren.AdaugaVagon(vagon2);
            tren.AdaugaVagon(vagon3);
            tren.AdaugaVagon(vagon4);
            tren.AdaugaVagon(vagon5);

            tren.PleacaDinGara();
            tren.OpresteInGara();

            Console.WriteLine(tren.GetNumarDeLocuri());


        }
    }
}
