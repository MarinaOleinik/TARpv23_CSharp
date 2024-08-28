using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv23_CSharp.Properties;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            //I.osa Andmetüübid, Alamfunktsioonid,If
            Console.OutputEncoding = Encoding.UTF8;
            int N=random.Next(-10,101);
            int M = random.Next(-10, 101);
            int[] arvud;
            Console.WriteLine(N);
            Console.WriteLine(M);
            if (N < M)
            {
                arvud=Funktsioonid.Arvude_massiiv(N,M);
            }
            else
            {
                arvud = Funktsioonid.Arvude_massiiv(M,N);
            }
            foreach (int item in arvud)
            {
                Console.WriteLine(item*item);
            }

            /*string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            nimed[0] = "Marina";
            //1.V
            for (int i = 0; i < nimed.Length; i++)
            {
                nimed[i] = "Uljana";
                Console.WriteLine(nimed[i]);
            }
            //2.V
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            //3.V
            int n = 0;
            while (n<nimed.Length)
            {
                Console.WriteLine(nimed[n]);
                n++;
            }
            //4.V
            do
            {
                Console.WriteLine(nimed[n-1]);
                n--;
            } while (n>0); //!=
            */




            //Täidame massiiv funktsiooni kaudu
            string[] nimed_funktsioonist;
            nimed_funktsioonist = Funktsioonid.Nimede_massiiv(6);
            foreach (var item in nimed_funktsioonist)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 7; i++)
            {
                
                int paev_nr=random.Next(-4,30);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine("Päeva nr: {0}. See on {1}",paev_nr,paeva_nimetus);
            }

            try
            {
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus=Double.Parse(Console.ReadLine());
                string vastus=Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0}, sa oled {1}",pikkus,vastus);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            






            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus1=Funktsioonid.Liitmine(a,b);
            Console.WriteLine(vastus1);
            double arv = 5.123456;
            vastus1=Funktsioonid.Liitmine(a,(int)arv);
            //Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus1==0) // &&-and, ||-or, !-not
            {
                Console.WriteLine(taht);
            }
            else 
            { 
                Console.WriteLine(vastus1);
            }
            var lause= Console.ReadLine();
            
        }

    }
}
