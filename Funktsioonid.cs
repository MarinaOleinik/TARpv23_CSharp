using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}",nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        // Loo Arvuta() funktsioon, mis sõltub 3 parameetrist: tehe, arv1, arv2. Kasuta if konstruktsioon. Tulemus kuva ekraanile.
        public static double Arvuta_2(string exp)
        {
            double vastus=Convert.ToDouble(new System.Data.DataTable().Compute(exp,null));
            return vastus;
        }
        public static string Pikkuse_analuus(double pikkus) 
        {
            string analuus;
            if (pikkus<1.6)
            {
                analuus = "Lühike kasvu inimene";
            }
            else if(pikkus<1.8)
            {
                analuus = "Keskmine kasvu inimene";
            }
            else
            {
                analuus = "Pikka kasvu inimene";
            }
            return analuus;
        }

        //päeva number-> päeva nimetus
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1:paev = "Esmaspäev"; break;
                case 2:paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
            return paev;
        }

        public static string[] Nimede_massiiv(int k) 
        {
            string nimi;
            string[] nimed=new string[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("{0} nimi :", i+1);
                nimi=Console.ReadLine();
                nimed[i] = nimi;
            }
            return nimed; 
        }
        public static int[] Arvude_massiiv(int N, int M)
        {
            int[] arvud = new int[M-N];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = N;
                N++;
            }
            return arvud;
        }
    }
}
