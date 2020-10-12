using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyogynovenyek
{
    class Program
    {
        static List<novenyek> noveny = new List<novenyek>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();


        static void Beolv()
        {
            StreamReader sr = new StreamReader("noveny.csv");
            while (!sr.EndOfStream)
            {
                noveny.Add(new novenyek(sr.ReadLine()));
            }

            sr.Close();
        }

        static void elso()
        {
            Console.WriteLine("Növények száma {0} db",noveny.Count()); 


            //int osszeg = 0;
            //for (int i = 0; i < noveny.Count; i++)
            //{
            //    osszeg++;
            //}
            //Console.WriteLine("Növények száma: {0}",osszeg);
        }
        static void masodik()

        {
            Console.WriteLine("Gyüjthető részek:");
            foreach (var t in noveny)
            {
                if (!reszek.ContainsKey(t.Resz))
                {
                    reszek.Add(t.Resz, 0);
                   
                }
                
            }
            foreach (var t in noveny)
            {
                reszek[t.Resz]++;
            }
            foreach (var m in reszek)
            {
                Console.WriteLine($"{m.Key} : {m.Value}");
            }
        }


        static void harmas()
        {
            int max = 0;
            foreach (var t in noveny)
            {
                if ( t.Idotartam > max)
                {
                    max = t.Idotartam;
                }
            }
            Console.WriteLine("Legtöbb idő {0}", max);

            foreach (var t in noveny)
            {
                if (t.Idotartam == max)
                {
                    Console.WriteLine(t.Nev);
                }
            }
        }


        static void negyes()
        {
            Console.WriteLine("\n");
            double szum = 0;
            
            foreach (var t in noveny)
            {
                szum += t.Idotartam;
                
            }
            Console.WriteLine("átlag: {0}",szum/noveny.Count());
        }
        static void Main(string[] args)
        {
            Beolv();
            elso();
            masodik();
            harmas();
            negyes();
            //foreach (var t in noveny)
            //{
            //    Console.WriteLine(t.Nev +";" + t.Resz+ ";" + t.Kezd + ";"+ t.Veg) ;
            //}

            Console.ReadKey();
        }
    }
}
