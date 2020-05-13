/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............: Mert HARMANKAŞI
** ÖĞRENCİ NUMARASI.......: B191200047
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volbilmemkac
{
    //burada cihhaz sınıfında kullanmak üzere nesneler oluşturdum
    class cihhaz
    {
        public string marka;
        public string cihaz;
        public string serino;
    }
    //burada kisib sınıfında kullanmak üzere nesneler oluşturdum
    class Kisib
    {
        public string isim;
        public string soyisim;
        public string adres;
       
    }
    //burada seri no üzerinde yazdığım kodlar var maalesef ki çalışmıyor
    class Class1
    {
        public int serno;
        public int sno
        {
            get
            {
                return serno;
            }
            set
            {
                if (value <= 0)
                {
                    serno = 1;
                }
                else
                {
                    serno = value;
                }
            }
        }
    }
    //burada telefon numarası üzerinde yazdığım kodlar var maalesef ki çalışmıyor
    class telefonnumarasi
    {
        public int falno;

        public int faln
        {
            get
            {
                return falno;
            }
            set
            {
                if (value <= 0)
                {
                    falno = 00000;
                }
                else
                {
                    falno = value;
                }
            }
        }
    }
    //burada soyut sınıf oluşturdum 
    abstract class kisi
    {
        public string adi, soyadi;
        abstract public void bilgisi();

    }
    //burada da oluşturduğum soyut sınıftan kalıtım yaptım ama kullanıcak bir yer bulamadığım için boşta duruyor
    class Kisii : kisi
    {
        public override void bilgisi()
        {

        }
    }
}
