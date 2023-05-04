
using System;
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            MevcutOgrenci ilayda = new MevcutOgrenci("ilayda", 2002, 490, "Bilgisayar Mühendisliği", 4);
            ilayda.kimsin();
            MezunOgrenci mehmet = new MezunOgrenci("mehmet", 1999, 490, "Ekonomi", 2020);
            mehmet.kimsin();
            Maasli sinem = new Maasli("sinem", 1987, 119, 20000);
            sinem.kimsin();
            Mesaili melis = new Mesaili("melis", 1972, 339, 25000, 45);
            melis.kimsin();
            Komisyonlu mustafa = new Komisyonlu("mustafa", 1982, 229, 55, 50);
            mustafa.kimsin();


        }
    }
    abstract class Insan
    {
        protected string ad;
        protected int dogumtarihi;
        protected int yas;

        public Insan(string ad, int dogumtarihi)
        {
            this.ad = ad;
            this.dogumtarihi = dogumtarihi;
            yas = 2023 - dogumtarihi;
        }

        abstract public void kimsin();

    }
    abstract class Ogrenci : Insan
    {
        protected int no;
        protected string bolum;
        public Ogrenci(string ad, int dogumtarihi, int no, string bolum) : base(ad, dogumtarihi)
        {
            this.no = no;
            this.bolum = bolum;
        }



    }
    class MevcutOgrenci : Ogrenci
    {
        protected int donem;
        public MevcutOgrenci(string ad, int dogumtarihi, int no, string bolum, int donem) : base(ad, dogumtarihi, no, bolum)
        {
            this.donem = donem;
        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1} , no={2} , bolum={3} , donem={4}", ad, yas, no, bolum, donem);
        }

    }
    class MezunOgrenci : Ogrenci
    {
        protected int mezuniyetyil;
        public MezunOgrenci(string ad, int dogumtarihi, int no, string bolum, int mezuniyetyil) : base(ad, dogumtarihi, no, bolum)
        {
            this.mezuniyetyil = mezuniyetyil;
        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1} , no={2} , bolum={3} , mezuniyetyil={4}", ad, yas, no, bolum, mezuniyetyil);
        }

    }
    abstract class Calisan : Insan
    {
        protected int SSK;
        public Calisan(string ad, int dogumtarihi, int SSK) : base(ad, dogumtarihi)
        {
            this.SSK = SSK;
        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1} , SSK={2}", ad, yas, SSK);
        }
    }
    class Maasli : Calisan
    {
        protected int maas;
        public Maasli(string ad, int dogumtarihi, int SSK, int maas) : base(ad, dogumtarihi, SSK)
        {
            this.maas = maas;
        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1} ,SSK={2} , maas={3}", ad, yas, SSK, maas);
        }


    }
    class Mesaili : Calisan  //40 saati geçerse geçtiği saatin 100 katı kadar fazladan alır.
    {
        protected int maas;
        protected int toplamücret;
        protected int calismasaat;

        public Mesaili(string ad, int dogumtarihi, int SSK, int maas, int calismasaat) : base(ad, dogumtarihi, SSK)
        {
            this.maas = maas;
            this.calismasaat = calismasaat;
            if (calismasaat > 40)
                toplamücret = maas + (calismasaat - 40) * 100;



        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1} , SSK={2} , toplamücret={3},", ad, yas, SSK, toplamücret);
        }


    }
    class Komisyonlu : Calisan
    {
        protected int SatisSayisi;
        protected int SatisOran;
        protected int ücret;
        public Komisyonlu(string ad, int dogumtarihi, int SSK, int SatisSayisi, int SatisOran) : base(ad, dogumtarihi, SSK)
        {
            this.SatisSayisi = SatisSayisi;
            this.SatisOran = SatisOran;
            ücret = (SatisOran * SatisSayisi) / 100;
        }
        public override void kimsin()
        {
            Console.WriteLine("ad={0} , yas={1}, SSK={2} , ücret={3},", ad, yas, SSK, ücret);
        }

    }
}