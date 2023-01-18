﻿   //out parametreler
   string sayi ="999";

   bool sonuc = int.TryParse(sayi, out int outSayi);
   if (sonuc)
   {

    Console.WriteLine("Başarili!");
    Console.WriteLine(outSayi);
   }

   else 
   {
    Console.WriteLine("Başarisiz!");
   }

   Metotlar instance = new Metotlar();
   instance.Topla(4,5, out int toplamSonucu);
   Console.WriteLine(toplamSonucu);


   //Metot Aşırı Yükleme - Overloading
   int ifade = 999;
   instance.EkranaYazdir (Convert.ToString(ifade));
   instance.EkranaYazdir (ifade);
   instance.EkranaYazdir ("Zikriye", "Ürkmez");


   //Metot Imzası
   //metotAdi + parametre sayisi + parametre

class Metotlar
{

   public void Topla(int a, int b, out int toplam)
   {
      toplam = a+b;
   }

   public void EkranaYazdir(string veri)
   {
      Console.WriteLine(veri);
   }

   public void EkranaYazdir(int veri)
   {
      Console.WriteLine(veri);
   }

   public void EkranaYazdir(string veril, string veri2)
   {
      Console.WriteLine(veril + veri2);
   }

}

