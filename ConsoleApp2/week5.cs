//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] regels = System.IO.File.ReadAllLines("C:\\Users\\User\\source\\repos\\ConsoleApp2\\verwarrendRandom.txt");
//        string[] woorden = new string[regels.Length];
//        int aantal = 0; 

//        // Filter 
//        for (int i = 0; i < regels.Length; i++)
//        {
//            string woord = regels[i].Trim();

//            if (woord.Length > 3 && !woord.Contains(" "))
//            {
//                woorden[aantal] = woord;
//                aantal++;
//            }
//        }
        
//        bool Isgewisseld;

//        do
//        {
//            Isgewisseld = false;

//            for (int i = 0; i < aantal - 1; i++)
//            {
//                if (String.Compare(woorden[i], woorden[i + 1], StringComparison.OrdinalIgnoreCase) > 0)
//                {
//                    // wissel
//                    (woorden[i], woorden[i + 1]) = (woorden[i + 1], woorden[i]);
//                    Console.WriteLine($"Ik heb iets gewisseld bij index {i}");
//                    Isgewisseld = true;
//                }
//            }

//        } while (Isgewisseld); 


//        string[] gesorteerd = new string[aantal];
//        for (int i = 0; i < aantal; i++)
//        {
//            gesorteerd[i] = woorden[i];
//        }

//        System.IO.File.WriteAllLines("C:\\Users\\User\\source\\repos\\ConsoleApp2\\gesorteerd.txt", gesorteerd);

//        Console.WriteLine("Klaar met sorteren!");
//    }
//}
