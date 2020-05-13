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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //burada şifre ekranın oluşturdum ve kullanıcı adı ile şifrenin doğruluğunu kontrol ettirdim

            if(textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                //kullanıcı adı ve şifre doğru ise form 2 açılıyor

                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                //kullanıcı adı veya şifre hatalıysa form 2 açılmıyor ve uyarı veriyor

                textBox1.Text = "Hatalı giriş";
                textBox2.Text = "Hatalı giriş";
            }
        }
    }
}
