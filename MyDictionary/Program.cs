using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> authors = new Dictionary<int,string>();
            authors.Add(444551265, "Oğuz Atay - Tehlikeli Oyunlar");
            authors.Add(156541895,"Cemal Süreya - Sevda Sözleri");
            authors.Add(895149547,"Cemil Meriç - Kırk Ambar");
            authors.Add(392395981,"Franz Kafka - Dava");
            Console.WriteLine(authors.Length);
            Console.WriteLine("Sırasıyla kitapların isimleri ve barkod numaraları: ");
            foreach (var item in authors.Isimler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in authors.Barkodlar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
