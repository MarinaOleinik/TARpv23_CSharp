using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
            
            Console.OutputEncoding = Encoding.UTF8;
            string text = "AAAAA BBB RRR OOOOO";
            string[] texts = text.Split(' ');


            //III. osa OOP

            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 52;
            inimene1.Sugu=Sugu.mees;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 100;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Sugu = Sugu.naine;
            inimene2.Pikkus = 160;
            inimene2.Kaal = 70;
            Inimene inimene3 = new Inimene("Marina", 18,Sugu.naine);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina",18,Sugu.naine));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + " aasta vana"+".Ta on "+inimene.Sugu+" SBI="+ inimene.HB_vorrand());
                
            }

            Auto auto1=new Auto("681MRP",Color.Bisque,inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);
            auto1.KelleOmaAuto();
            Dictionary<Auto,Inimene> register = new Dictionary<Auto,Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene3);
            register.Add(auto3, inimene3);
            foreach (Auto item in register.Keys)
            {
                Console.WriteLine($"{item.Regnumber} - {item.Omanik.Nimi}");
            }
            foreach (KeyValuePair<Auto,Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.Regnumber+"-"+pair.Value.Nimi);
            }

            //II. osa listid ja sõnastikud
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vas=Console.ReadLine();
            if (vas !=null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub "+arrayList.IndexOf(vas)+". kohal");
            }
            else
            {
                Console.WriteLine("Kokku oli " + arrayList.Count + " elemente, vaid otsitav puudub");
            }
            arrayList.Clear();
            arrayList.Insert(1, "Anna");
            arrayList.Insert(0, "Inna");
            





            List<string> abc = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Fail ei saa leida!");
            }
            foreach (string e in abc)
            {
                Console.Write(e);
            }
            Console.ReadLine();

            //I.osa Andmetüübid, Alamfunktsioonid,If
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
