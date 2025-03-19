using EmlakciLib;

namespace EmlakciApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //Ev evim = new Ev();
            //evim.alan = 160;
            //evim.semt = "Gazi";
            //evim.katno = 2;
            //evim.odasayisi = 4;

            //Console.WriteLine(evim.EvBilgileri());


            //Ev evim2 = new Ev { alan= 150, katno = 3, odasayisi = 3, semt = "Çayyolu" };


            //Console.WriteLine(evim2.EvBilgileri());

            //var evim3 =new Ev(3,4,200);
            //Console.WriteLine(evim3.EvBilgileri());

            //Console.WriteLine($" Bellekteki ev sayısı :{Ev.sayac}");

            //evim.odasayisi = int.Parse(Console.ReadLine());
            //if (evim.odasayisi < 0)
            //{
            //    evim.odasayisi=Math.Abs(evim.odasayisi);
            //}


            var evim = new Ev();

            Console.Write("Oda sayısı: ");
            evim.SetOdaSayisi(int.Parse(Console.ReadLine()));
            

            Console.Write("Evin alanı :");
            evim.SetAlan(double.Parse(Console.ReadLine()));
            

            Console.Write("Evin kat no: ");
            evim.SetKatNo(int.Parse(Console.ReadLine()));

            Console.Write("Evin semti: ");
            evim.SetSemt(Console.ReadLine());
            

            Console.WriteLine($"\n Evin odasayısı: {evim.GetOdaSayisi()}");
            Console.WriteLine($"\n Evin alanı: {evim.GetAlan()}");
            Console.WriteLine($"\n Evin kat no: {evim.GetKatNo()}");
            Console.WriteLine($"\n Evin semti: {evim.GetSemt()}");
            //int sayi = 5;//set
            //Console.WriteLine("sayi");//get



        }

    }



}

// Ev evim = new Ev();//Ev classından nesne türetildi 
// evim: Refarans, Nesnelerin bellekdeki adresini tutarlar. Blleğin STACK bölgesinde tutulurlar. 
// Ev: Class. Classlar aynı zamanda bir veri tipidir.
// new: Bellekde nesne oluşturmaya yarayan anahtar sözçüktür.
// Nesne: new anahtar sözcüğü ile HEAP bölgesinde oluştururlar.

// Erişim belirleyiciler (Access Modifiers )
// Privite: Sadece class içinde erişilebilir üyelerdir .
// Public: class içinde tanımlanan üyeye her yerden erişim imkanı sağlar.
// Ctrl + (.) hata düzeltmek için kullanılabilir çözüm yolları sunar.

