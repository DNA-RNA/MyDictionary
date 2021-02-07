using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<<<<<<<<<<-----List Ornekleri----->>>>>>>>>>");
            
            List<string> sayilar = new List<string>();  //Hazır kullanılan liste örnek
            sayilar.Add("101");

            MyList<string> isimler = new MyList<string>(); //Mylist isimiyle oluşturulan generic class listesine örnek
            isimler.Add("Rana");
            isimler.Add("Yalçın");

            Console.WriteLine(isimler.Length); //Eklediğimiz eleman sayısını yazdırır.

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);            //Eklediğimiz elemanları yazdırır.
            }
          
            Console.WriteLine("<<<<<<<<<<-----Dictionary Ornekleri----->>>>>>>>>>");
           
            Dictionary<string, int> listem = new Dictionary<string, int>();
            //Hazır kullanılan Dictionarye isim ve yaşı temsil eden değerler girdim.
            listem.Add("RNA", 19);
            listem.Add("Zehra", 24);
            listem.Add("Ali", 25);
            foreach (int item in listem.Values)
            {
                Console.WriteLine(item);     //Burada sadece yaş kısmını yazdırır.
            }

            foreach (KeyValuePair<string, int> item in listem)
            {
                Console.WriteLine(item.Key +"-->" +item.Value.ToString());  //Burada ise hem isimleri hem de yaşi yazdırır.
            }
            Console.WriteLine();
            Console.WriteLine(">>>>>>>-----MyDictionary-----<<<<<<<");
            
            MyDictionary<string, string> product = new MyDictionary<string, string>();
           //Key kısmına ürünlerin adını value kısmına markalarını tanımladım.
            product.Add("Bilgisayar", "Apple MacBook");
            product.Add("Telefon", "Samsung");
            product.Add("Monitör", "Hp");
            product.Add("Mouse/Fare", "Microsoft");
            //Oluşturduğumuz dictionarynin toplam eleman sayısı class kısmında int length olarak tanımlayıp burada çağırdım.
            Console.WriteLine("Eklenen toplam ürün sayısı: " + product.Length); 
            Console.WriteLine();
            product.Listing(); //Girdiğimiz ürünleri ve markalarını listelemek için kullanıdığım metot
            
        }


       

    }
}
