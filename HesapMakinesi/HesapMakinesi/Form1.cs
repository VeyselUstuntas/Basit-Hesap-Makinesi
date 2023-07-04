
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool ekranTemizle; // ilk sayıyı girdikten sonra ekranın temizlenmesi için deklare edildi.
        double ilkSayi; // butonlardan girilen ilk sayıyı saklamak için deklare edildi.
        char islem; // "+" "-" vs gibi işlemleri tanımlamak için deklare edildi.
        double islem2; // tek paremetre gerektiren işlemler için deklare edildi.
        string islem3; // sayının işaretini belirlemede kullandık
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if(ekranTemizle)
            {
                lblEkran.Text = ""; // if bloğuna girdiğinde ekranı temizler.
                ekranTemizle = false;
            }

            if(lblEkran.Text==0.ToString()) // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                           
                lblEkran.Text = ""; // ve ekranı temizler.
               
            }

            lblEkran.Text += 0.ToString(); // ekrana birden fazla 0 yazdırır.
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 1.ToString(); // ekrana birden fazla 1 yazdırır.
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 2.ToString(); //ekrana birden fazla 2 rakamı yazdırır
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 3.ToString(); //ekrana birden fazla 3 rakamı yazdırır
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu                        
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 4.ToString();  //ekrana birden fazla 4 rakamı yazdırır
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 5.ToString();  //ekrana birden fazla 5 rakamı yazdırır
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 6.ToString();  //ekrana birden fazla 6 rakamı yazdırır
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 7.ToString();  //ekrana birden fazla 7 rakamı yazdırır
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString())  // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                   // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik

            }

            lblEkran.Text += 8.ToString();  //ekrana birden fazla 8 rakamı yazdırır
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == 0.ToString()) // hesap makinesi ilk açılışta ekranda 0 rakamı yazdığı, 0 rakamını silmek için if bloğunu tanımladık
            {                                  // yoksa ekranda sayıın en başında 0 rakamı olurdu
                lblEkran.Text = ""; // ekranı temizledik
                
            }

            lblEkran.Text += 9.ToString(); // ekrana birden fazla 9 rakamı yazdırır
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            islem = '+'; // işlemin toplama olduğunu belirttik.
            lblEkran.Text = ""; // ikinci sayıyı girmek için ekranı temizledik
            lblEkran2.Text = ilkSayi + " +"; // ikinci ekrana yapılan işlemi tam olarak ifade ettik
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            islem = '-';
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            lblEkran.Text = "";// ikinci sayıyı girmek için ekranı temizledik
            lblEkran2.Text = ilkSayi + "-"; // ikinci ekrana yapılan işlemi tam olarak ifade ettik
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            islem = '*';
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            lblEkran.Text = "";// ikinci sayıyı girmek için ekranı temizledik
            lblEkran2.Text = ilkSayi + " x "; // ikinci ekrana yapılan işlemi tam olarak ifade ettik
        }

        private void btnBolu_Click(object sender, EventArgs e)
        {
            islem = '/';
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            lblEkran.Text = "";// ikinci sayıyı girmek için ekranı temizledik
            lblEkran2.Text = ilkSayi + "/"; // ikinci ekrana yapılan işlemi tam olarak ifade ettik
        }

        private void btnKareKok_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            islem2 = Math.Sqrt(ilkSayi); // math fonksiyonu kullanarak karekök alma işlemini yaptık
            lblEkran2.Text = "√" + ilkSayi + " = "; // sonucu ekrana yazdırdık
            lblEkran.Text= islem2.ToString("0.00");
        }


        private void btnKaresi_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            islem2 = Math.Pow(ilkSayi,2); //math fonksiyonununu kullanarak girilen sayının karesini alma işlemini yaptık
            lblEkran2.Text = ilkSayi+ "²"+" = "; // sonucu ekrana yazdırdık
            lblEkran.Text = islem2.ToString();
        }

        private void btnBirBoluSayi_Click(object sender, EventArgs e)
        {
            if (ilkSayi == 0)
            {
                lblEkran.Text = "TANIMSIZ!!"; // girilen sayı 0 ise ekrana yazdırır.
            }

            else
            {     
                ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
                islem2 = 1 / (ilkSayi); // girilen sayının -1'inci kuvvetini aldık 
                lblEkran2.Text = islem2.ToString(); // sonucu ekrana yazdırdık
            }
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            ilkSayi = Convert.ToDouble(lblEkran.Text); // girilen ilk sayıyı convert metodu ile "ilkSayı" değişkenine kaydettik
            islem2 = ilkSayi % 100; // girilen sayının 100 e kalanınını hesapladık
            lblEkran2.Text = islem2.ToString(); // sonucu ekrana yazdırdık
        }

        private void btnEsit_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(lblEkran.Text); // iki parametre gerektiren aritmetik işlmelerde, ikinci sayıyı saklamak için kullanıldı.
            double sonuc; // yapılan işlemin sonucunu kaydetmek için tanımlandı.
            
            if(islem=='+') // eğer eşittire bastığımızda, yapılan işlem toplama ise if bloğuna girecek
            {
                sonuc = ilkSayi + ikinciSayi; // girilen ikinci sayıyı ilk sayıyla topladık sonuc değişkenine kaydettik.
                lblEkran.Text = sonuc.ToString(); // sonucu ekrana yazdırdık.
                lblEkran2.Text = ilkSayi + " + " + ikinciSayi + " ="; // yapılan işlemi bütün haliyle ekrana yazdırdık.
            }

            if(islem=='-') // eğer eşittire bastığımızda, yapılan işlem çıkarma ise if bloğuna girecek
            {
                sonuc = ilkSayi - ikinciSayi; // girilen ikinci sayıyı ilk sayıdan çıkardık sonuc değişkenine kaydettik.
                lblEkran.Text = sonuc.ToString(); // sonucu ekrana yazdırdık.
                lblEkran2.Text=ilkSayi+" - "+ikinciSayi+" ="; // yapılan işlemi bütün haliyle ekrana yazdırdık.

            }

            if (islem == '*') // eğer eşittire bastığımızda, yapılan işlem çarpma ise if bloğuna girecek
            {
                sonuc = ilkSayi * ikinciSayi; // girilen ilk sayıyı ikinci sayıyla çarptık sonuc değişkenine kaydettik.
                lblEkran.Text = sonuc.ToString(); // sonucu ekrana yazdırdık.
                lblEkran2.Text = ilkSayi + " x " + ikinciSayi + " ="; // yapılan işlemi bütün haliyle ekrana yazdırdık.

            }

            if (islem == '/') // eğer eşittire bastığımızda, yapılan işlem bölme ise if bloğuna girecek
            {
                if (ikinciSayi == 0)
                {
                    lblEkran.Text = "TANIMSIZ!!"; // eğer payda sıfır ise ekrana yazdırır.
                }
                
                else
                {
                    sonuc = ilkSayi / ikinciSayi; // girilen ilk sayıyı ikinci sayıya böldük sonuc değişkenine kaydettik.
                    lblEkran.Text = sonuc.ToString(); // sonucu ekrana yazdırdık.
                    lblEkran2.Text = ilkSayi + " / " + ikinciSayi + " ="; // yapılan işlemi bütün haliyle ekrana yazdırdık.
                }
            }

            if(islem3=="+-")// sayı önündeki işareti belirler
            {
                sonuc = ilkSayi * -1;
                sonuc = ikinciSayi * -1;
            }
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            lblEkran.Text = ""; // birinci ekranı temizler
        }

        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            lblEkran.Text = ""; // birinci ekranı temizler
            lblEkran2.Text = ""; // ikinci ekranı tmizler
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblEkran.Text = null; // ana ekranı temziler.
        }

        private void btnIsaret_Click(object sender, EventArgs e)
        {
            islem3 = "+-"; // sayının işaretini belirler
            islem2 = Convert.ToDouble(lblEkran.Text) * (-1); // sayıyı -1 ile çarparak artı mı eksi mi olcağını seçeriz
            lblEkran.Text = islem2.ToString(); // oluşan sayıyı ekrana yazdırır
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            lblEkran.Text += ','; // sayıyı ondalıklı hale çevirir.
        }
    }
}