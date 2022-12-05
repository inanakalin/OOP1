using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //stackte alan oluşturuyoruz 
        public MyList()
        {
            items = new T[0];  //new leyerek heapte alan oluşturuyoruz
        }
        public void Add(T item)
        {
            T[] tempArray = items;   // geçici bir array oluşturarak Add metodu çalışmadan önceki arrayı tutar yani 0 elemanlıyı
            items = new T[items.Length + 1]; // new leyerek 1 elemanlı yeni dizi oluştu
            for (int i = 0; i <= tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // geçici arraydeki verileri itemsa tekrar ekledik a
            }

            items[items.Length-1] = item; // Add metodu çalışınca gelen elemanı artık yeni listeye ekledik
        }                                    
    }
}
