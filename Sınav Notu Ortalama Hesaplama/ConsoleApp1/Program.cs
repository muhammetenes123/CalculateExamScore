using System;

class Program
{
    static void Main(string[] args)
    {
        string secim = "";

        while (secim != "E" || secim != "e")
        {
            Console.WriteLine("Çıkış için 'E'");
            Console.WriteLine("Not hesaplamak için 'H'");
            Console.Write("Seçiminiz: ");
            secim = Console.ReadLine();

            if (secim == "H"|| secim == "h")
            {
                Console.Write("Dersin adı: ");
                string dersAdi = Console.ReadLine();

                Console.Write("Kaç adet not girilecek: ");
                int notAdedi = Convert.ToInt32(Console.ReadLine());

                double[] notlar = new double[notAdedi];
                double[] yuzdeler = new double[notAdedi];
                double toplamYuzde = 0;

            git: for (int i = 0; i < notAdedi; i++)
                {
                    
                    Console.Write("Not {0}: ", i + 1);
                    notlar[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Yüzde {0}: ", i + 1);
                    yuzdeler[i] = Convert.ToDouble(Console.ReadLine());
                    toplamYuzde += yuzdeler[i];

                    if (notlar[i] < 0 || notlar[i] > 100 || yuzdeler[i] < 0 || yuzdeler[i] > 100)
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. Notlar ve yüzdeler 0-100 arasında olmalıdır.");
                        goto git;
                        i--;
                        toplamYuzde -= yuzdeler[i];
                    }
                }

                if (toplamYuzde != 100)
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Yüzdelerin toplamı 100 olmalıdır.");
                    goto git;
                }
                else
                {
                    double ortalama = 0;

                    for (int i = 0; i < notAdedi; i++)
                    {
                        ortalama += (notlar[i] * yuzdeler[i] / 100);
                    }

                    string harfNotu;

                    if (ortalama >= 90)
                    {
                        harfNotu = "AA";
                    }
                    else if (ortalama >= 85)
                    {
                        harfNotu = "BA";
                    }
                    else if (ortalama >= 80)
                    {
                        harfNotu = "BB";
                    }
                    else if (ortalama >= 75)
                    {
                        harfNotu = "CB";
                    }
                    else if (ortalama >= 65)
                    {
                        harfNotu = "CC";
                    }
                    else if (ortalama >= 58)
                    {
                        harfNotu = "DC";
                    }
                    else if (ortalama >= 50)
                    {
                        harfNotu = "DD";
                    }
                    else
                    {
                        harfNotu = "FF";
                    }

                    Console.WriteLine("Ders Adı: {0}", dersAdi);
                    Console.WriteLine("Not Ortalaması: {0}", ortalama);
                    Console.WriteLine("Harf Notu: {0}", harfNotu);

                    if (ortalama >= 50)
                    {
                        Console.WriteLine("Geçti");
                    }
                    else
                    {
                        Console.WriteLine("Kaldı");
                    }
                }
            }
            else if (secim == "E" || secim == "e")
            {
             Console.WriteLine("Programdan Çıkılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız. Lütfen 'E' veya 'H' seçeneklerinden birini giriniz.");
            }
            Console.WriteLine();
        }
    }
}