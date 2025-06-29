// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System;

//public class week4
//{
//    public static int SomFor(int a, int n)
//    {
//        int totaal = 0;
//        for (int i = a; i < n; i++)
//        {
//            totaal += i;
//        }
//        return totaal;
//    }

//    public static int SomWhile(int a, int n)
//    {
//        int totaal = 0;
//        int i = a;

//        while (i < n)
//        {
//            totaal += i;
//            i++;
//        }

//        return totaal;
//    }

//    public static int SomForeach(int a, int n)
//    {
//        int totaal = 0;

//        List<int> getallen = new List<int>();
//        for (int i = a; i < n; i++)
//        {
//            getallen.Add(i);
//        }

//        foreach (int i in getallen)
//        {
//            totaal += i;
//        }

//        return totaal;
//    }


//    public static int AantalCijfers(string tekst)
//    {
//        bool doorgaan = true;
//        int TotaalCijfer = 0;

//        for (int i = 0; i < tekst.Length; i++)
//        {
//            if (!char.IsDigit(tekst[i]))
//            {
//                doorgaan = false;
//            }
            
//            if (doorgaan)
//            {
//                TotaalCijfer++;
//            }
//        }
        
//        return TotaalCijfer;
//    }

//    public static int AantalCijfersWhile(string tekst)
//    {
//        int totaalCijfer = 0;
//        int i = 0;

//        while (i < tekst.Length && char.IsDigit(tekst[i]))
//        {
//            totaalCijfer++;
//            i++;
//        }

//        return totaalCijfer;
//    }

//    public static int AantalCijfersForeach(string tekst)
//    {
//        int totaalCijfer = 0;

//        foreach (char c in tekst)
//        {
//            if (char.IsDigit(c))
//            {
//                totaalCijfer++;
//            }
//            else
//            {
//                break;
//            }
//        }

//        return totaalCijfer;
//    }



//    public static int AantalA(string tekst)
//    {
//        int TotaalA = 0;
//        for (int i = 0;i < tekst.Length;i++)
//        {
//            if (tekst[i] == 'a')
//            {
//                TotaalA++;
//            }
//        }
//        return TotaalA;
//    }

  

//    public static void Main(string[] args)
//    {
//        int opdrachtA = SomWhile(8, 3);
//        Console.WriteLine("Som: " + opdrachtA);

//        int opdrachtBC = AantalCijfers("10a24");
//        Console.WriteLine("Aantal cijfers in de string: " + opdrachtBC);

//        int opdrachtD = AantalA("12a43");
//        Console.WriteLine("Aantal a's in de string: " + opdrachtD);

//        int opdracht4c;
//        Foreach4C("1234a4bc", out opdracht4c);
//        Console.WriteLine(opdracht4c);
//    }

//    static void Foreach4C(string tekst, out int count)
//    {
//        count = 0;
//        bool doorgaan = true;

//        foreach (char c in tekst)
//        {
//            if (doorgaan && c >= '0' && c <= '9')
//            {
//                count++;
//            }
//            else
//            {
//                doorgaan = false;
//            }
//        }
//    }
//}
