using System;
using System.Collections;
using System.Collections.Generic;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<int>();
            //list.Add(5);
            ////list.Add("5");

            //var lista = new List<Czlowiek>();
            //lista.Add(new Czlowiek("aaa"));
            ////lista.Add(5);

            //var listaa = new List<object>();
            //var czObject = new Czlowiek("aa");

            //listaa.Add(czObject);

            //var a = Convert.ToString(listaa[0]);
            ////Console.WriteLine(a.Imie);
            //string c = "5";
            ////int b;

            //if (int.TryParse(c, out int b))
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine("bad");
            //}

            //Console.WriteLine(b);


            //try
            //{
            //    object e = "e";
            //    string f = (string)e;
            //    object j = f;


            //    var d = (int)e;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("catch");
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}
            //Czlowiek c1 = new Czlowiek("elo");

            PoryRoku p1 = (PoryRoku)15;
            PoryRoku p2 = PoryRoku.Lato;
            Console.WriteLine(p1);
            Console.WriteLine((int)p2);

            ////SWITCH
            //int poraRoku = 0;
            //Console.Write("Podaj numer pory roku: ");
            //string numer = Console.ReadLine();
            //poraRoku = int.Parse(numer);
            //switch (poraRoku)
            //{
            //    case 1:
            //        Console.WriteLine("Wiosna");
            //        break;
            //    case 2:
            //        Console.WriteLine("Lato");
            //        break;
            //    case 3:
            //        Console.WriteLine("Jesień");
            //        break;
            //    case 4:
            //        Console.WriteLine("Zima");
            //        break;
            //    default:
            //        Console.WriteLine("Wybrano niewlasciwy numer");
            //        break;
            //}


            //  TABLICE
            string[] imiona = new string[4];
            imiona[0] = "Piotrek";
            imiona[1] = "Przemek";
            imiona[2] = "Kuba";
            imiona[3] = "Pawel";
            int num = 0;
            Console.WriteLine(imiona.Length);
            Console.Write("Wpisz numer imiona z tabeli: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Imie numer {num} - {imiona[num]}");

            Console.WriteLine($"Indeks imiona: {Array.IndexOf(imiona, "Pawela")}");
            Console.WriteLine("GetValue: " + imiona.GetValue(3));
            imiona.SetValue("Piotrek", 2);

            for (int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine($"{i}. {imiona[i]}");
            }

            //  LISTY
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("elo");
            a1.Add(new Czlowiek("Adam"));

            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }


            ////  PROPERTIES
            //Czlowiek c2 = new Czlowiek("Jula");
            //Console.WriteLine(c2.PIN);
            //c2.pesel = 1;
            //Console.WriteLine("PESEL c1: " + c2.pesel);




        }
    }
}

public class Czlowiek
{
    private string _imie;
    public int PIN { get; } = 12345;
    private int Pesel = 960531;

    public int pesel
    {
        get { return Pesel; }
        set
        {
            if (value < 10 & value > 0)
                Pesel = Pesel + value;
          
        }
    }

    public string Imie { get => _imie; set => _imie = value; }

    public Czlowiek(string imie)
    {
        Imie = imie;
    }

    public Czlowiek ReturnCzlowiek()
    {
        Console.WriteLine($"{6} jjj");
        return this;
    }
}
enum PoryRoku
{
    Wiosna = 15, Lato = 30, Jesien = 8, Zima = -10
}

