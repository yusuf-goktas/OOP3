using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   
        //Method injection - kullanacağın metodun hangi kredimanager ve loglayıcı olacağı enjekte edilir.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme
            //
            //

            krediManager.Hesapla(); //interface tuttuğu için buraya ne gönderirsen onun Ikredimanager onu çalıştıracaktır.
            loggerService.Log();

        }

        //IKrdiManager türünde liste ver 
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //listedeki her krediyi tek tek dolanması için 
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //her krediyi tek tek dolandırıp hesaplatıyoruz 

            }


        }




    }
}
