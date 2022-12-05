using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //string[] isimler = new string[] { "İnan", "Nebahat", "Reşit", "Nazlı" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        //isimler = new string[5];   // new dediğimizde yeni bir adres/array oluşturduğu için adres deişir 
        //isimler[4] = "Ayşe";        
        //Console.WriteLine(isimler[4]); // ayşeyi yazar 
        //Console.WriteLine(isimler[0]); // ama yeni bir array oluştuğu için diğer indexleri boş olarak verir

        List<string> isimler2 = new List<string> { "İnan", "Nebahat", "Reşit", "Nazlı" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("Ayşe");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);  //Collectionslarda diğer indexler kaybolmaz
    }
}