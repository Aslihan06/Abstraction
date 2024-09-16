using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Constructor
    public Calisan(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    // Her çalışanın kendi görevini bildiren abstract metot
    public abstract void Gorev();
}

// Yazılım Geliştirici sınıfı
class YazilimGelistirici : Calisan
{
    public YazilimGelistirici(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Yazılım Geliştirici olarak çalışıyorum.");
    }
}

// Proje Yöneticisi sınıfı
class ProjeYoneticisi : Calisan
{
    public ProjeYoneticisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Proje Yöneticisi olarak çalışıyorum.");
    }
}

// Satış Temsilcisi sınıfı
class SatisTemsilcisi : Calisan
{
    public SatisTemsilcisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Satış Temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Proje Yöneticisi örneği
        Calisan projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Proje Yönetimi");
        projeYoneticisi.Gorev();

        // Yazılım Geliştirici örneği
        Calisan yazilimGelistirici = new YazilimGelistirici("Ayşe", "Yazılımcı", "IT");
        yazilimGelistirici.Gorev();

        // Satış Temsilcisi örneği
        Calisan satisTemsilcisi = new SatisTemsilcisi("Ali", "Satıcı", "Satış");
        satisTemsilcisi.Gorev();
    }
}
