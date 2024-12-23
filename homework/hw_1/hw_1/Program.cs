namespace hw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = SayiUret();
            DiziYazdir(sayilar);
            int max = EnBuyukDeger(sayilar);
            int min = EnKucukDeger(sayilar);
            Console.WriteLine("Max değer:" + max);
            Console.WriteLine("Min değer:" + min);
        }
        static int[] SayiUret()
        {
            int max, min;
            Console.WriteLine("Min değer giriniz:");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max değer giriniz:");
            max = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Bekleyiniz...");
            Thread.Sleep(1500);
            Random random = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(min, max + 1);
            }
            return sayilar;
        }
        static void DiziYazdir(int[] sayilar)
        {
            Console.Clear();
            Console.Write("Dizinin Elemanları: ");
            foreach (int i in sayilar)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
        static int EnBuyukDeger(int[] sayilar)
        {
            int enBuyuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            return enBuyuk;
        }
        static int EnKucukDeger(int[] sayilar)
        {
            int enKucuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            return enKucuk;
        }
    }

}
