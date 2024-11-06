// Kahve isimlerini tutmak için bir liste oluştur
List<string> kahveListesi = new List<string>();

// Kullanıcıdan 5 kahve ismi al ve listeye ekle
Console.WriteLine("Lütfen 5 adet kahve ismi girin:");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Kahve {i}: ");
    string kahveIsmi = Console.ReadLine();
    kahveListesi.Add(kahveIsmi);
}

// foreach döngüsü ile liste içerisindeki kahve isimlerini ekrana yazdır
Console.WriteLine("\nGirdiğiniz kahve isimleri:");
foreach (string kahve in kahveListesi)
{
    Console.WriteLine(kahve);
}