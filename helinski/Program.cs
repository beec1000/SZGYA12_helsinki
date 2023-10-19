using helinski;
using System;
using System.Text;

namespace helsinki
{
	class Program
	{
		static int F5(List<Adatok> o)
		{
            var OsszPontszam = 0;

            foreach (var item in o)
            {
                if (item.Helyezes == 1)
                {
                    OsszPontszam += 7;
                }
                else if (item.Helyezes == 2)
                {
                    OsszPontszam += 5;
                }
                else if (item.Helyezes == 3)
                {
                    OsszPontszam += 4;
                }
                else if (item.Helyezes == 4)
                {
                    OsszPontszam += 3;
                }
                else if (item.Helyezes == 5)
                {
                    OsszPontszam += 2;
                }
                else
                {
                    OsszPontszam += 1;
                }
            }
			return OsszPontszam;
        }
		static string F6(List<Adatok> o)
		{
            var torna = o.Count(d => d.SportagNeve == "torna");
            var uszas = o.Count(d => d.SportagNeve == "uszas");

            var valasz = string.Empty;

            if (torna == uszas)
            {
                valasz = "Egyenlő volt az érmek száma!";
            }
            else if (torna > uszas)
            {
                valasz = "Torna sportágban szereztek több érmet!";
            }
            else if (torna < uszas)
            {
                valasz = "Úszás sportágban szereztek több érmet!";
            }
            return valasz;
        }
		static void Main(string[] args)
		{
			var olimpikonok = new List<Adatok>();

			using var sr = new StreamReader(@"..\..\..\src\helsinki.txt");
			while (!sr.EndOfStream)
			{
				olimpikonok.Add(new (sr.ReadLine()));
			}

            Console.WriteLine($"3. feladat \nPontszerző helyezések száma: {olimpikonok.Count()}");

            Console.WriteLine("4. feladat");

			var Elsok = 0;
			var Masodikok = 0;
			var Harmadikok = 0;

            foreach (var item in olimpikonok)
			{
				if (item.Helyezes == 1)
				{
					Elsok += 1;
				}
				else if(item.Helyezes == 2)
				{
					Masodikok += 1;
				}
				else if (item.Helyezes == 3)
				{
					Harmadikok += 1;
				}
			}

            Console.WriteLine($"Arany: {Elsok} \n" +
                $"Ezüst: {Masodikok} \n" +
                $"Bronz: {Harmadikok} \n" +
                $"Összesen: {Elsok + Masodikok + Harmadikok}");

			Console.WriteLine($"5. feladat \nOlimpiai pontok száma: {F5(olimpikonok)}");

			Console.WriteLine($"6. feladat \n{F6(olimpikonok)}");

            //7.feladat

            //var olimpikonok2 = new List<Adatok>(olimpikonok);

            //var f7 = string.Empty;

            //foreach (var i in olimpikonok)
            //{
            //    if (i.SportagNeve == "kajakenu")
            //    {
            //        f7 = i.SportagNeve;
            //    }
            //}

            //using var sw = new StreamWriter(@"..\..\..\src\helsinki2.txt");
            //foreach (var i in olimpikonok2)
            //{
            //    if (f7 == i.SportagNeve )
            //    {
            //        i.SportagNeve = "kajak-kenu";
            //    }
            //}
            //sw.WriteLine(olimpikonok2);

        }
	}
}