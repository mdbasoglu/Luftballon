using System;

namespace Uebung50_Luftballon_pbbgh20aba
{
    class Luftballon
    {



        // Attribute
        private string farbe;
        private string form;
        private double maxVolumen;
        private double volumen;
        private bool verknotet;

        //Yandaki isarete tikla ve generate Constructor sec. sonrasinda attributlari sec ve bitti!
        public Luftballon(string farbe, string form, double maxVolumen, double volumen, bool verknotet)
        {
            this.farbe = farbe;
            this.form = form;
            this.maxVolumen = maxVolumen;
            this.volumen = volumen;
            this.verknotet = verknotet;
        }

        public Luftballon(string farbe, string form, double maxVolumen)
        {
            this.farbe = farbe;
            this.form = form;
            this.maxVolumen = maxVolumen;

            //Optional
            volumen = 0;
            verknotet = false;
        }

        public Luftballon()
        {
            farbe = "rot";
            form = "rund";
            maxVolumen = 1.0;
        }

        //Objekt Methoden
        public void Aufpusten(double volumen)
        {
            if (!verknotet)
            {
                this.volumen += volumen;
                if (this.volumen > maxVolumen)
                {
                    Platzen();
                }
            }
        }

        public void verknoten()
        {
            verknotet = true;
        }

        public void Platzen()
        {
            Console.WriteLine("WWWWWWWWWWWWWWW............................");
            volumen = 0;
            maxVolumen = 0;//bedeuten zerplatzt
        }

        //Getter-Setter
        public string GetFarbe()
        {
            return farbe;
        }

        public void SetFarbe(string value)
        {
            farbe = value;
        }

        //Get-Set
        public string Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        //oder public string Farbe{get=>farbe; set=>farbe=value;} wir können mit eine Zeile schreiben

        public override string ToString()
        {
            return $"Luftballon [farbe={farbe}, form={form}],maxVolumen={maxVolumen},volumen={volumen}, verknotet={verknotet}";
        }
    }
}
