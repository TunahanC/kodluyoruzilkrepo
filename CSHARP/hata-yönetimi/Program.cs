try
{
  Console.WriteLine("Bir sayi giriniz");
  int sayi = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);  
}
catch (System.Exception ex)
{
    Console.WriteLine("Hata: "+ ex.Message.ToString());
}
//finally
//{
//   Console.Write("İşlem Tamamlandı.");
//}

try
{
  //int a = int.Parsel(null);
  //int a = int.Parsel("test");
  int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
   Console.WriteLine("Boş değer girdiniz");
   Console.WriteLine(ex);
}
catch (FormatException ex)
{
   Console.WriteLine("Veri tipi uygun değil.");
   Console.WriteLine(ex);
}
catch (OverflowException ex)
{
   Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
   Console.WriteLine(ex);
}
finally
{
  Console.WriteLine("İşlem başariyla tamamlandi.");
}