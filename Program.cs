using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHTÄVÄ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan 2-ulotteinen taulukko ja lisätään siihen kysymykset sekä oikeat vastaukset
            string[,] kysymykset = new string[3, 2];

            //laitetaan taulukkoon mitä kysytään ja vastaukset

            //1
            kysymykset[0, 0] = "Mikä on Ranskan pääkaupunki (a=Pariisi,b=Helsinki,c=Jordania,d=Lyon)?";
            kysymykset[0, 1] = "b";
            //2
            kysymykset[1, 0] = "Montako päivää on karkausvuosina (a=111,b=254,c=336,d=366)?";
            kysymykset[1, 1] = "d";
            //3
            kysymykset[2, 0] = "Kuka maalasi Mona Lisa-taulun (a=Jarkko,b=minä,c=naapurisi,d=da Vinci)?";
            kysymykset[2, 1] = "d";

            //Kysytään kysymykset ja lasketaan oikeat vastaukset
            int oikeat = 0;
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Kysymys : " + (i + 1) + kysymykset[i, 0]);
                string vastaus = Console.ReadLine();

                if (vastaus.Equals(kysymykset[i, 1]))
                {
                    // Jos meni oikein
                    oikeat++;
                    Console.WriteLine("Oikein!");
                }else
                {
                    Console.WriteLine("Harmi, ei mennyt oikein.");
                } //If

            } // for lause päättyy

            //Tulostetaan oikeiden vastausten määrä.
            Console.WriteLine("Oikeat vastaukset : " +oikeat+ "/ 3");
        } //Main
    }//Class
}//Namespace