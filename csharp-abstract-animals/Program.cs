namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Animale cane = new Cane();
            Animale passerotto = new Passerotto();
            Animale aquila = new Aquila();
            Animale delfino = new Delfino();

            Passerotto passerottoVola = new Passerotto();
            Delfino delfinoNuota = new Delfino();
            Aquila aquilaVola = new Aquila();
            Cane caneNuota = new Cane();

            static void FaiVolare(Ivolante animale)
            {
                animale.Vola();
            }


            static void FaiNuotare(INuotante animale)
            {
                animale.Nuota();
            }

            Console.WriteLine("Cane");
            cane.Verso();
            cane.CosaMangi();
            cane.Dormi();
            FaiNuotare(caneNuota);
            Console.WriteLine();

            Console.WriteLine("Passerotto");
            passerotto.Verso();
            passerotto.CosaMangi();
            passerotto.Dormi();
            FaiVolare(passerottoVola);
            Console.WriteLine();

            Console.WriteLine("Aquila");
            aquila.Verso();
            aquila.CosaMangi();
            aquila.Dormi();
            FaiVolare(aquilaVola);
            Console.WriteLine();

            Console.WriteLine("Delfino");
            delfino.Verso();
            delfino.CosaMangi();
            delfino.Dormi();
            FaiNuotare(delfinoNuota);


            

        }
    }
}