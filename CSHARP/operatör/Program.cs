Console.WriteLine("Hello, World!");

// Atama ve İşlemli Atama
            int x = 3;
            int y = 3;

            y = y + 2;
            y += 2;  // üsttekinin kısa syntaxı

            x = x * 4;
            x *= 4;  //kısa syntax

            
            
            
            // Mantıksal Operatorler
            // &&, ||, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess&&isCompleted)
            {
                Console.WriteLine("perfect");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("great");
            }

            if (isSuccess&& !isCompleted)
            {
                Console.WriteLine("fine");
            }

            
            
            // İlişkisel Operatorler
            // <,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a != b;
            Console.WriteLine(sonuc); // Çıktı true

            
            
            // Aritmetik Operatorler
            // *,/,+,-
            
            int sayı1 = 35;
            int sayı2 = 7;
            int sonuç1 = sayı1 / sayı2;
            Console.WriteLine(sonuç1); // Çıktı 5


            // Mod alma
            // %

            int c = 20%6;
            Console.WriteLine(c); // Çıktı 2