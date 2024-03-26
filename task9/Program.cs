
//using System;
//namespace task9
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, -3, -5, 6, -7 };
//            ConvertNegativeToPozitive(arr);
//            foreach (int i in arr)
//            {
//                Console.Write(i);
//            }
//        }
//        static void ConvertNegativeToPozitive(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < 0)
//                {
//                    arr[i] *= -1;
//                }
//            }
//        }
//    }
//}










//using System;

//namespace task9
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string text = "bu gun derse az usaq gelib";
//            Console.WriteLine(Check(text));
//        }

//        static bool Check(string text)
//        {
//            for (int i = 0; i < text.Length; i++)
//            {
//                if (text[i] == 'a' || text[i] == 'A')
//                    return true;
//            }
//            return false;
//        }
//    }
//}








//using system;

//namespace task9
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] arr = { 12, 3, 24, 78, 19, -5 };
//            console.writeline(min(arr));
//        }

//        static int min(int[] arr)

//        {
//            int min = arr[0];
//            for (int i = 0; i < arr.length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//            }
//            return min;
//        }
//    }
//}











//using System;
//namespace task9
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            int num = 15479;
//            Console.WriteLine(NumLength(num));
//        }
//        static int NumLength(int num)
//        {
//            int count = 0;
//            while (num != 0)
//            {
//                num /= 10;
//                count++;
//            }
//            return count;
//        }

//    }
//}










//using System;
//namespace task9
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            string text = "hava yagislidir";
//            Console.WriteLine(WovelLetter(text));
//        }
//        static int WovelLetter(string text)
//        {
//            int count = 0;
//            for (int i = 0; i < text.Length; i++)
//            {
//                if (text[i] == 'a' || text[i] == 'u' || text[i] == 'i' || text[i] == 'e' || text[i] == 'o' ||
//                    text[i] == 'A' || text[i] == 'U' || text[i] == 'I' || text[i] == 'E' || text[i] == 'O')
//                {
//                    count++;
//                }
//            }
//            return count;
//        }
//    }
//}







//using System;
//namespace task9
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 40, 10, 20 };
//            Console.WriteLine(EdediOrta(arr));
//        }
//        static int EdediOrta(int[] arr)
//        {
//            int count = 0;
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum += arr[i];
//                count++;
//            }
//            sum /= count;
//            return sum;
//        }
//    }
//}









//namespace check1
//{
//    internal class Program
//    {
//        static string[] adlar = new string[20];
//        static int say = 0;
//        static void Main(string[] args)

//        {
//            int secim;
//            Console.WriteLine("Layihe");
//            Console.WriteLine("1. Adlari goster");
//            Console.WriteLine("2. Ad elave et");
//            Console.WriteLine("3. Adi yoxla");
//            Console.WriteLine("4. Daxil edilmsş indeksdeki adi goster");
//            Console.WriteLine("0. Menyudan cix");

//            secim = Convert.ToInt32(Console.ReadLine());
//            switch (secim)
//            {
//                case 1:
//                    AdlariGoster();
//                    break;
//                case 2:
//                    AdElaveEt();
//                    break;
//                case 3:
//                    AdYoxla();
//                    break;
//                case 4:
//                    IndekstekiAdiGoster();
//                    break;
//                case 0:
//                    Console.WriteLine("Proqramdan cixilir");
//                    break;

//            }
//            static void AdlariGoster()
//            {
//                Console.WriteLine("Siyahidaki butun adlar");
//                for (int i = 0; i < say; i++)
//                {
//                    Console.WriteLine(adlar[i]);
//                }
//            }

//            static void AdElaveEt()
//            {
//                Console.WriteLine("Siyahiya elave etmek istediyiniz adi daxil edin");
//                string yeniAd = Console.ReadLine();
//                for (int i = 0; i < adlar.Length; i++)
//                {
//                    if (yeniAd != adlar[i] && yeniAd.Length > 2)
//                    {
//                        adlar[say] = yeniAd;
//                        say++;
//                        Console.WriteLine("ad siyahıya əlavə edildi.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ad uygun deyil. Ad reqemle baslaya bilmez ve uzunlugu 2-den boyuk olmalidir ve siyahida tekrar olmamalidir.");
//                    }
//                }
//            }
//            static void AdYoxla()
//            {
//                Console.WriteLine("Yoxlamaq istediyiniz adi daxil edin:");
//                string yoxlanilacaqAd = Console.ReadLine();
//                bool adVar = true;
//                for (int i = 0; i < adlar.Length; i++)
//                {
//                    if (yoxlanilacaqAd == adlar[i])
//                    {
//                        adVar = false;
//                        break;
//                    }
//                }
//                if (adVar)
//                {
//                    Console.WriteLine("Daxil etdiyiniz ad siyahıda mövcuddur.");
//                }
//                else
//                {
//                    Console.WriteLine("Daxil etdiyiniz ad siyahıda mövcud deyil.");
//                }
//            }

//            static void IndekstekiAdiGoster()
//            {
//                Console.WriteLine("Gosterilmesini istediyiniz indeksi daxil edin:");
//                int indeks = Convert.ToInt32(Console.ReadLine());
//                if (indeks >= 0 && indeks < adlar.Length)
//                {
//                    Console.WriteLine("indeksdeki ad:" + adlar[indeks]);
//                }
//                else
//                {
//                    Console.WriteLine("Yanlis indeks daxil edildi.");
//                }


//            }
//        }
//    }









