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
    }
}
