using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //mylistimde T ile çalışıcam.
    {
        T[] items;  //clasın tüm operasyonları erişebilir. T tipinde bir array
       
        public MyList()  //constructor. classı new lersen otomatik çalışıyo.
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;  //t nin ilk referens numarasını tutuyoo.

            items = new T[items.Length+1];  //new lediğin için yeni referans num alıyo

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;
            

        }
        public int Length
        {
            get {return items.Length; }
        }
    }
}
