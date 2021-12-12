using System;
namespace Uebung50_Luftballon_pbbgh20aba
{
    class Program
    {
        static void Main(string[] args)
        {

            Luftballon ballon; //Deklaration
            ballon = new Luftballon(); // Initilisierung
            Luftballon ballon2 = new Luftballon();

            Luftballon blauerLB = new Luftballon("blau", "rund", 1.2);
            Luftballon gelberLB = new Luftballon("gelb", "längerlich", 0.9, 0.85, true);


            blauerLB.Aufpusten(0.3);
            blauerLB.Aufpusten(0.5);
            Console.WriteLine(blauerLB);

            blauerLB.verknoten();
            Console.WriteLine(blauerLB);

            blauerLB.Aufpusten(0.3);
            Console.WriteLine(blauerLB);

            gelberLB.Platzen();
            Console.WriteLine(gelberLB);



            //Getter-Setter
            string farbe = blauerLB.GetFarbe();
            blauerLB.SetFarbe("Grünnnnnnnnnnnnnnnn");
            Console.WriteLine(blauerLB);

            //Get-Set
            string Farbe = blauerLB.Farbe;
            blauerLB.Farbe = "grüüünnnnaskdsifmisdmvosmvvmdfpovmdfkmv....";
            Console.WriteLine(blauerLB);





        }
    }
}
