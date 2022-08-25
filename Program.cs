﻿//List<T>class
//System.Collections.Generic
// T->object türündedir.
List<int>sayiListesi=new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string>renkListesi=new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");
// Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);
foreach(var sayi in sayiListesi)
   Console.WriteLine(sayi);
foreach(var renk in renkListesi)
   Console.WriteLine(renk);

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));
// Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşisl");
sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);
sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));
// Liste içerisinde Arana
if(sayiListesi.Contains(18))
   Console.WriteLine("10 Liste içerisinde bulundu!");
// Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));


// Diziyi List'e çevirme
string[]hayvanlar={"Kedi","Köpek","Kuş"};
List<string>hayvanListesi=new List<string>(hayvanlar);

// Listeyi nasıl temizleriz?
hayvanListesi.Clear();

// List içerisinde nesne tutmak
List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();

Kullanıcılar kullanıcı1=new Kullanıcılar();
kullanıcı1.Isim="Ayse";
kullanıcı1.Soyisim="Yılaz";
kullanıcı1.Yas=26;

Kullanıcılar kullanıcı2=new Kullanıcılar();
kullanıcı2.Isim="Özcan";
kullanıcı2.Soyisim="Çalışkan";
kullanıcı2.Yas=26;

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar()
{
    Isim ="Hakan",
    Soyisim="Baş",
    Yas=23
    

});

foreach (var kullanıcı in kullanıcıListesi)
{
    Console.WriteLine("Kullanıcı Adı :",kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyadı :",kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yaş :",kullanıcı.Yas);

}

public class Kullanıcılar
{
    private string isim;

    private string soyisim;

   

    private int yas;

    public int Yas { get => yas; set => yas = value; }
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
}