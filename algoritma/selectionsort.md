# Selection Sort

Aşamaları:

- [22]
- [22,27]
- [16,22,27]
- [2,16,22,27]
- [2,16,18,22,27]
- [2,6,16,18,22,27]

Big-O gösterimi: O(n^2)

Time Complexity:
Worst case: Aradığımız sayının sonda olması
18 sayısı dizinin sonunda olduğu için, tüm elemanlar dizinin sonunda olduğu için, bu durumda, insertion sort'un en yavaş çalıştığı durumdur.

Best case: Aradığımız sayının dizinin en başında olması.
18 sayısı dizinin başında olduğu için, bu durumda, insertion sort'un en hızlı çalıştığı durumdur.

**Average case: Aradığımız sayının ortada olması**
**18 sayısı dizinin ortasında olduğu için, bu durumda, insertion sort ortalama olarak çalışır.**

## 2.Soru-Cevap

- 1.Adım: En küçük eleman 2 olduğu için, 2 ile 7 yer değiştirir. Dizi şöyle olur: [2,3,5,8,7,9,4,15,6]
- 2.Adım: En küçük eleman 3 olduğu için, 3 ile 2 yer değiştirir. Dizi şöyle olur: [2,3,5,8,7,9,4,15,6]
- 3.Adım: En küçük eleman 4 olduğu için, 4 ile 3 yer değiştirir. Dizi şöyle olur: [2,3,4,8,7,9,5,15,6]
- 4.Adım: En küçük eleman 5 olduğu için, 5 ile 4 yer değiştirir. Dizi şöyle olur: [2,3,4,5,7,9,8,15,6]