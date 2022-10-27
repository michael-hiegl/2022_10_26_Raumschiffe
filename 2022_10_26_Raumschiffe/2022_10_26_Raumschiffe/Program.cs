//Imports######################################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#############################################################

//Classes######################################################
class Raumschiff
{
    double länge;
    double breite;
    double höhe;

    public void set(double l, double b, double h)
    {
        länge = l;
        höhe = h;
        breite = b;
    }

    public double getlänge()
    {
        return länge;
    }

    public double getbreite()
    {
        return breite;
    }

    public double gethöhe()
    {
        return höhe;
    }

    public double getMaße(string a)
    {
        if (a == "Höhe")
            return höhe;
        else if (a == "Breite")
            return breite;
        else if (a == "Länge")
            return länge;
        else
            return 0;
    }
}
//#############################################################

namespace _2022_10_26_Raumschiffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code#############################################
            Raumschiff Enterprise = new Raumschiff();
            Enterprise.set(288.6, 127.1, 72.6);

            Raumschiff Voyager = new Raumschiff();
            Voyager.set(344.5, 132.1, 64.4);

            Console.WriteLine("Enterprise: {0}, {1}, {2}", Enterprise.getlänge(), Enterprise.getbreite(), Enterprise.gethöhe());
            Console.WriteLine("Voyager: {0}, {1}, {2}", Voyager.getlänge(), Voyager.getbreite(), Voyager.gethöhe());

            Console.WriteLine("Enterprise: {0}, {1}, {2}", Enterprise.getMaße("Länge"), Enterprise.getMaße("Breite"), Enterprise.getMaße("Höhe"));
            Console.WriteLine("Voyager: {0}, {1}, {2}", Voyager.getMaße("Länge"), Voyager.getMaße("Breite"), Voyager.getMaße("Höhe"));
            //#################################################

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }

        //Functions############################################
        //#####################################################
    }
}