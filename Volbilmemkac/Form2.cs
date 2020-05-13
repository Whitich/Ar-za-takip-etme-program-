using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volbilmemkac
{
    public partial class Form2 : Form
    {
        //burada oluşturduğum classlardaki kodları çağırdım

        cihhaz getcihaz = new cihhaz();
        Kisib getirdi = new Kisib();
        telefonnumarasi telefengetir = new telefonnumarasi();
        Kisii mailudis = new Kisii();
       


        public Form2()
        {
            InitializeComponent();
        }

        private void İsim_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //burada switch case kodlarını kullanıp kolaylık sağlamayı amaçladım textboxa 1,2,3 değerlerinden biri yazılınca (başka şeyler de yazılabiliyor atanan değerler otomatik geliyor

            switch (textBox5.Text)
                {
                case"1":
                    textBox5.Text = "Telefon";
                    break;

                case"2":
                    textBox5.Text = "Televizyon";
                    break;

                case "3":
                    textBox5.Text = "Tablet";
                    break;
            }
            
            
            //burada kontrol mekanizmasının içine dizi yazıp switch case de olduğu gibi bir kolaylık sağlamaya çalıştım uzun uzun gün adı yazmaktansa 0-6 aralığından sayı girilince karşılığındaki gün otomatik yazılıyor.
            
            try
            {
                string[] gunler = new string[7];

                gunler[0] = "pazartesi";
                gunler[1] = "salı";
                gunler[2] = "çarşamba";
                gunler[3] = "peşembe";
                gunler[4] = "cuma";
                gunler[5] = "cumartesi";
                gunler[6] = "pazar";

                //burada textboxa yazdırdım

                int dön = Convert.ToInt32(textBox3.Text);
                textBox3.Text = gunler[dön];
            }

            //0-6 değer aralığı dışında değer girilince program hata vermesin diye catch kullandım. Hatalı değer girilince uyarı veriyor textboxun içinde

            catch
            {
                textBox3.Text = "Lütfen 0-6 aralığında bir değer giriniz";
            }

            //burada değerler oluşturup textboxtaki değerleri atadım.

            string saat = maskedTextBox2.Text;
            string günü = textBox3.Text;
            string not = textBox8.Text;
            string bisey = maskedTextBox1.Text;
            
            //burada da classlardan çektiğim verileri kullanım onlara textboxtaki değerleri atadım.

            getirdi.isim = textBox1.Text;
            getirdi.soyisim = textBox2.Text;
            getcihaz.cihaz = textBox5.Text;
            getcihaz.marka = textBox6.Text;
            getcihaz.serino = textBox7.Text;
            getirdi.adres = textBox4.Text;

            //burada listboxa yan yana olacak şekilde yazdırdım.

            listBox1.Items.Add("Ad-Soyad: " + getirdi.isim + " " + getirdi.soyisim + " Telefon numarası: "+bisey+" Adres: "+getirdi.adres+" Cihaz: "+getcihaz.cihaz+" Marka: "+getcihaz.marka+" Seri no: "+getcihaz.serino+" Gün: "+günü+" Saat: "+saat+" Not: "+not);

            
        }

        //burada yukarıda oluşturulan listlerden istediğimizi silmemize yarayan buton ekledim.
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        //burada tüm kayıtları silmeye yarayan buton var.
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //burada da kayıt yarinde yazan yazıları kolaylık olsun diye silmeye yarayan buton var.
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox3.Clear();
            textBox8.Clear();
            maskedTextBox2.Clear();
        }

        //seri no sadece sayı olarak girilebilsin diye oluşturdum
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        //burada pollymorphism kullanarak günlerin yanında bulunan butonda küçük bir bilgi vermesini sağladım.
        class gunitem
        {
            public string ptesi()
            {
                string items = "0 yazarsan Pazartesi günü çıkar.";
                return items;
            }
            public string salı()
            {
                string items = "1 yazarsan Salı günü çıkar.";
                return items;
            }
            public string cars()
            {
                string items = "2 yazarsan Çarşamba günü çıkar.";
                return items;
            }
            public string pers()
            {
                string items = "3 yazarsan Perşembe günü çıkar.";
                return items;
            }
            public string cuma()
            {
                string items = "4 yazarsan Cuma günü çıkar.";
                return items;
            }
            public string ctesi()
            {
                string items = "5 yazarsan Cumartesi günü çıkar.";
                return items;
            }
            public string pazar()
            {
                string items = "6 yazarsan Pazar günü çıkar.";
                return items;
            }
        }
        private void button5_Click(object sender, EventArgs e)

            //burada da o bilgileri yazdırdım.

        {
            gunitem cıkar = new gunitem();
            MessageBox.Show(cıkar.ptesi() + "\n" + cıkar.salı() + "\n" + cıkar.cars() + "\n" + cıkar.pers() + "\n" + cıkar.cuma() + "\n" + cıkar.ctesi() + "\n" + cıkar.pazar());
        }


        //burada da yukarda yaptığım işlemin aynısını cihaz için de yaptım.
        class cihazitem
        {
            public string tel()
            {
                string items = "1 yazarsan Telefon çıkar.";
                    return items;
            }
            public string tv()
            {
                string items = "2 yazarsan Televizyon çıkar.";
                return items;
            }
            public string tab()
            {
                string items = "3 yazarsan Tablet çıkar.";
                return items;
            }

        }

        //burada da yazdırdım.
        private void button6_Click(object sender, EventArgs e)
        {
            cihazitem ci = new cihazitem();
            MessageBox.Show(ci.tel() + "\n" + ci.tv() + "\n" + ci.tab());
        }

        
        //burada bazı markaları yukarıda yaptığım şekle benzer bir şekilde ? kutusunda yazdırdım. list ve foreach kullandım.
        private void button7_Click(object sender, EventArgs e)
        {
            List<string> marka = new List<string>();
            marka.Add("samsung");
            marka.Add("nokia");
            marka.Add("vestel");
            marka.Add("casper");
            marka.Add("lenovo");
            marka.Add("asus");

            foreach (var deger in marka)
            {
                MessageBox.Show(deger);
            }
        }

        //sayı girişini engellemek için eklediğim kod.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
            }
        }

        //sayı girişini engellemek için eklediğim kod.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
            }
        }
    }
}
