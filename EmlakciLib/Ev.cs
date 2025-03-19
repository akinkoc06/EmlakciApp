using System;

namespace EmlakciLib
{
    public class Ev
    {
        public static int sayac = 0;
        //public Ev(int katno,int odasayisi,  double alan)
        //{
        //    this.katno = katno;
        //    this.odasayisi = odasayisi;
        //    this.semt = "Kızılay";
        //    this.alan = alan;
        //}
        public Ev(int odasayiyi, int katno, double alan, string semt = "Kızılay")//constructor
        {
            this.odasayisi = odasayiyi;
            this.katno = katno;
            this.semt = semt;
            this.alan = alan;
            sayac++;

        }

        public Ev()
        {
            sayac++;
        }

        
        

        private int katno;//field
        private string semt;//Buraya atanan değerler büyük olmalı.
        private double alan;
        private int odasayisi;

        public void SetSemt(string semt)
        {
            this.semt = semt.ToUpper();
        }
        public string GetSemt()
        {
            return this.semt;
        }


        public void SetKatNo(int katno)
        {
            this.katno = katno;
        }
        public int GetKatNo()
        {
            return this.katno;
        }

        public void SetAlan(double alan)
        {
            this.alan = alan;
        }
        public double GetAlan()
        {
            return this.alan;
        }

        public void SetOdaSayisi(int odasayisi)
        {
            this.odasayisi= Math.Abs(odasayisi);//Kapsülleme
        }
        public string EvBilgileri()
        {
            return $"Alan: {this.alan} \nsemt: {this.semt} \nkatno: {this.katno} \nodasayısı: {this.odasayisi}\n";
            sayac++;
        }
        public int GetOdaSayisi()
        {
            return this.odasayisi;
        }
            




    }
}
//Constructor-yapıcı metodlar
//Görevleri: Bir class içindeki nesne türetirken çalışır ve class içindeki fieldların varsayılan değer atamalarını yapar
//Her calssta mutlaka vardır .Varsayılan olarak parametre almazlar. Bu constructorlara default constructor denir.
//isimleri clas adı ile aynıdır ve farklı isimle tanımlanamazlar.
//Constructorlar geriye değer döndürmezler.
//Constructorlar classlardan nesne türerildiğinde çalışan ilk metoddur.
//ctor code snippeti ile default constructor oluşturulabilir.
// Bir class içinde satatic olarak tanımlanan üyelere, class adı ile erişilir ve bu üyüler program çalıştığı sürece bellekte kalır. Nesnelerden bağımsız,classa bağlıdır. !!!!!!!!!!!!!!!
//Kapsülleme(Encapsulation) ilkesi : Class içerisinde yapılan işlerin, class dışından gizlenmesidir. Örn: odasayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişilebilen public SetOdaSayısı(int odasayisi) metodu yazıldı. Bu metod içinde gelen feğerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.
