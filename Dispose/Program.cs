calistir();

Console.WriteLine("metod sonu");

GC.Collect();

Console.ReadLine();


//GC(garbage collector) nin temizleyeceği nesnenin bir referansa bağlı olmaması gerektiği için sınıf oluşturma işlemini farklı bir metod da yapıyoruz
void calistir()
{
    // birinci test etme yöntemi
    using (Test t = new Test())
    {
        Console.WriteLine("Test sınıf using içinde açılıyor");
    }

    // ikinci test etme yöntemi
    Kisi oKisi = new Kisi(0);
    Kisi oKisi1 = new Kisi(10);
    Kisi oKisi2 = new Kisi(20);
    Kisi oKisi2r = new Kisi(30);
    Kisi oKisi3 = new Kisi(40);
    Kisi oKisi453 = new Kisi(50);
}

class Kisi
{
    int sayac;
    public Kisi(int a)
    {
        sayac = a;
    }

    ~Kisi()
    {
        Console.WriteLine("{0} kişi nesnesi bellekten siliniyor", sayac);
    }
}

class Test : IDisposable
{
    public Test()
    {
        Console.WriteLine("test sınıfı ram de oluşturuluyor");
    }
    ~Test()
    {
        Console.WriteLine("test sınıfı GC tarafından kaldırılıyor");
    }
    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
}

