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
            //I.osa Andmetüübid, Alamfunktsioonid,If
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus=Funktsioonid.Liitmine(a,b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=Funktsioonid.Liitmine(a,(int)arv);
            //Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus==0) // &&-and, ||-or, !-not
            {
                Console.WriteLine(taht);
            }
            else 
            { 
                Console.WriteLine(vastus);
            }
            var lause= Console.ReadLine();
            arv=Funktsioonid.Arvuta(lause);
            Console.WriteLine(arv);
        }

    }
}
