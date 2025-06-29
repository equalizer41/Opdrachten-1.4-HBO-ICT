//List<VluchtRecord> records = new List<VluchtRecord>();
//string[] regels = File.ReadAllLines("C:\\Users\\User\\source\\repos\\ConsoleApp2\\vluchtgegevens.txt");

//bool isEerste = true;

//foreach (string regel in regels)
//{
//    if (isEerste)
//    {
//        isEerste = false;
//        continue;
//    }

//    if (string.IsNullOrWhiteSpace(regel) || regel.StartsWith("=")) continue;

//    string[] kolommen = regel.Split(',');

//    var record = new VluchtRecord
//    {
//        VluchtNr = kolommen[0].Trim(),
//        Maatschappij = kolommen[1].Trim(),
//        Van = kolommen[2].Trim(),
//        Naar = kolommen[3].Trim(),
//        Vertrek = kolommen[5].Trim(),
//        Status = kolommen[6].Trim(),
//        Optijd = kolommen[7].Trim(),
//        Model = kolommen[8].Trim(),
//        CallSign = kolommen[9].Trim(),
//        Owner = kolommen[10].Trim()
//    };

//    records.Add(record);
//}

//List<Vlucht> vluchten = new List<Vlucht>();
//List<Maatschappij> maatschappijen = new List<Maatschappij>();

//foreach (var record in records)
//{
//    Maatschappij maatschappij = new Maatschappij
//    {
//        Afkorting = record.Maatschappij,
//        Naam = record.Maatschappij
//    };

//    Uitvoerder uitvoerder = new Uitvoerder
//    {
//        VluchtNr = record.VluchtNr,
//        Maatschappij = maatschappij
//    };

//    Vlucht vlucht = new Vlucht
//    {
//        Vertrek = DateTime.Parse(record.Vertrek),
//        Status = record.Status,
//        Vliegtuig = new Vliegtuig
//        {
//            Model = record.Model,
//            CallSign = record.CallSign,
//            Owner = record.Owner
//        },
//        Van = new Bestemming { Naam = record.Van, Afkorting = "" },
//        Naar = new Bestemming { Naam = record.Naar, Afkorting = "" },
//        Uitvoerders = new List<Uitvoerder> { uitvoerder }
//    };

//    vluchten.Add(vlucht);
//}


//Console.WriteLine("{0,-8} {1,-15} {2,-10} {3,-30} {4,-12} {5}",
//    "Schema", "Herkomst", "Vluchtnr.", "Maatschappij", "Opmerkingen", "Actuele info");
//Console.WriteLine("-----------------------------------------------------------------------------------------");

//foreach (var vlucht in vluchten)
//{
//    string tijd = vlucht.Vertrek.ToString("HH:mm");
//    string herkomst = vlucht.Van.Naam;

//    foreach (var uitvoerder in vlucht.Uitvoerders)
//    {
//        Console.WriteLine($"{tijd,-8} {herkomst,-15} {uitvoerder.VluchtNr,-10} {uitvoerder.Maatschappij.Naam,-30} {vlucht.Status,-12} Details →");
//    }
//}



//// KLASSEN

//class Bestemming
//{
//    public string Naam;
//    public string Afkorting;
//}

//class Vlucht
//{
//    public Vliegtuig Vliegtuig;
//    public Bestemming Van;
//    public Bestemming Naar;
//    public DateTime Vertrek;
//    public string Status;
//    public List<Uitvoerder> Uitvoerders;
//}

//class Vliegtuig
//{
//    public string Model;
//    public string CallSign;
//    public string Owner;
//}

//class Uitvoerder
//{
//    public string VluchtNr;
//    public Maatschappij Maatschappij;
//    public Vlucht Vlucht;
//}

//class Maatschappij
//{
//    public string Afkorting;
//    public string Naam;
//}

//class VluchtRecord
//{
//    public string VluchtNr;
//    public string Maatschappij;
//    public string Van;
//    public string Naar;
//    public string Vertrek;
//    public string Status;
//    public string Optijd;
//    public string Model;
//    public string CallSign;
//    public string Owner;
//}
