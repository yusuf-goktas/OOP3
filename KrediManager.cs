using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   /* kredimanagerı interface olarak tanımladık ve I ile belirttik.Bu interface ise fonksiyonlar içermektedir.
     * Bunu implemente eden (apply -uygulamak) her class'ta kendine göre kuralları ,fonksiyonları düzenlemelidir.*/
   


    /* interface leri birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanılır.*/


      interface IKrediManager        //class // okunurluk için interface'ler I ile başlar.
    {


        void Hesapla();       
        void BiSeyYap();



    }
}
