using System.Collections;

// Tanimlama
var sehirler = new Hashtable();


// Ekleme
sehirler.Add(6, "Ankara");
sehirler.Add(34, "Istanbul");
sehirler.Add(55, "Samsun");
sehirler.Add(23, "Elazig");

// Dolasma
foreach (DictionaryEntry item in sehirler)
{
    Console.WriteLine($"{item.Key,-5} " + $"- {item.Value,-20}");
}

// Anahtarlari alma
Console.WriteLine("\nAnahtarlar (Keys)");
var anahtarlar = sehirler.Keys;
foreach(var item in anahtarlar)
{
    Console.WriteLine(item);
}

// Degerler
Console.WriteLine("\nDegerler (values)");
ICollection degerler = sehirler.Values;
foreach(var item in degerler)
{
    Console.WriteLine(item);
}

// Elemana Erisme
Console.WriteLine("\nElemana erisim");
Console.WriteLine(sehirler[55]);


//Eleman silme
Console.WriteLine("\n Eleman silme");
sehirler.Remove(23);

// Dolasma
foreach(DictionaryEntry item in sehirler)
{
    Console.WriteLine($"{item.Key,-5}" + $"- {item.Value,-20}");
}