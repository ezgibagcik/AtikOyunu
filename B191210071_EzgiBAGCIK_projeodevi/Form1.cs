/**********************************************************************************************************************************************************
**                                       SAKARYA UNIVERSITESI BILGİISAYAR VE BILIŞIM BILIMLERI FAKULTESI
**				                                           BILGISAYAR MUHENDISLIĞI BOLUMU
**				                                           NESNEYE DAYALI PROGRAMLAMA DERSI
**					                                           2019-2020 BAHAR DÖNEMİ
* 
**                                                ÖDEV NUMARASI............: PROJE ODEVİ
**                                                ÖĞRENCİ ADI..............: EZGI BAĞCIK
**                                                ÖĞRENCİ NUMARASI.........: B191210071
**                                                DERS GRUBU...............: 1. OĞRETIM C GRUBU
***********************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_projeodevi
{

    public partial class Form1 : Form
    {
        Atik atik = new Atik();  //Atik sinifindan nesne olusturuldu.
        AtikKutusu aKutu = new AtikKutusu();
        public int toplamPuan = 0;  
        public int camDoluluk = 0;
        public int metalDoluluk = 0;
        public int kagitDoluluk = 0;
        public int organikDoluluk = 0;
        public int kalanSure = 60;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

            //progressbarların minimum deger atamaari yapilir.
            pBarOrganik.Minimum = 0;
            pBarKagit.Minimum = 0;
            pBarCam.Minimum = 0;
            pBarMetal.Minimum = 0;

           //progressBarların maximum deger atamalari yapilir.
            pBarOrganik.Maximum = 700;
            pBarKagit.Maximum = 1200;
            pBarCam.Maximum = 2200;
            pBarMetal.Maximum = 2300;
            lbSure.Text = "60";
           
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            resimAta(); //Form ekrani yuklendiginde resmin atanmasini saglar.

            kalanSure = 60; //Timerın baslangic degeri olan kalanSure atanir.
            timer1.Start(); //Yeni oyun butonuna basildiginda 

            //Yeni Oyun butonuna basildiginda butonlarin erisilebilirligini acar.
            btnCam.Enabled = true;
            btnCamBosalt.Enabled = true;
            btnKagit.Enabled = true;
            btnKagitBosalt.Enabled = true;
            btnMetal.Enabled = true;
            btnMetalBosalt.Enabled = true;
            btnOrganikAtik.Enabled = true;
            btnOrgBosalt.Enabled = true;

            //Yeni Oyun butonuna basildiginda yeni oyun butonu, sure ve puanin yazildigi labellarin renklerini degistirir
            lbSure.BackColor = Color.Aquamarine;
            lbPuan.BackColor = Color.Aquamarine;
            btnYeniOyun.BackColor = Color.DarkSlateGray;  

            //AtikKutu sinifindan olusturulan fonksiyonu cagirir.
            aKutu.atikKutulariTemizle(); 
           
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalanSure > 0) //Sayacin calisir durumdayken kalan sure pozitifken bu kosula girer.
            {
                kalanSure = kalanSure - 1; //Surenin birer birer azalmasi icin kalan sureden 1 eksiltilir.
                lbSure.Text = kalanSure.ToString(); //Kalan sure; sure labelina yazdirilir.
            }
            else //kalan sure 0 dan kucuk oldugunda bu kosula girer.
            {
                timer1.Stop(); //Timer durdurulur.
                //Butonlar sure bıttıgınde etkisiz hale gelir.
                btnCam.Enabled = false;
                btnCamBosalt.Enabled = false ;
                btnKagit.Enabled = false;
                btnKagitBosalt.Enabled = false;
                btnMetal.Enabled = false;
                btnMetalBosalt.Enabled = false;
                btnOrganikAtik.Enabled = false;
                btnOrgBosalt.Enabled = false;
                //Sure bittiginde, sure ve puanin yazildigi labellarin renklerini degistirir.
                lbSure.BackColor = Color.White;
                lbPuan.BackColor = Color.White;
                btnYeniOyun.BackColor = Color.DarkSlateGray;
            }
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "CamAtik") //Atik turu CamAtik oldugunda bu kosula girer
            {
                camDoluluk += atik.Hacim; //Atik hacmini, camin dolulugunu tutan degiiskene atar.
                if (atik.Ad == "camsise" && camDoluluk < 2200) //Atigin adi camsise ve camın dolulugu 2200 den kucukse bu kosula girer.
                {
                    lbCam.Items.Add("Cam Şişe(600)"); //Listboxa cam sisenin hacmi ve adı yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarCam.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret(); //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atıgın resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.

                }
                else if (atik.Ad == "cambardak" && camDoluluk < 2200)//Atigin adi cambardak ve camın dolulugu 2200 den kucukse bu kosula girer.
                {
                    lbCam.Items.Add("Cam Bardak(250)"); //Listboxa cam sisenin hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim;//Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarCam.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();//Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.

                }
               
            }

        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "MetalAtik") //Atik turu MetalAtik oldugunda bu kosula girer
            {
                metalDoluluk += atik.Hacim;  //Atik hacmini, metal dolulugunu tutan degiiskene atar.
                if (atik.Ad == "salcakutusu" && metalDoluluk < 2300) //Atigin adi salcakutusu ve metalin dolulugu 2300 den kucukse bu kosula girer.
                {
                    lbMetal.Items.Add("Salça Kutusu(550)"); //Listboxa salca kutusunun hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString();  //Toplam puan labela yazdirilir.
                    pBarMetal.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret(); //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.

                }
                
                else if (atik.Ad == "kolakutusu" && metalDoluluk < 2300) //Atigin adi kolakutusu ve metalin dolulugu 2300 den kucukse bu kosula girer.
                {
                    lbMetal.Items.Add("Kola kutusu(350)"); //Listboxa salca kutusunun hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarMetal.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();  //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.
                }
                
            }

        }

        private void btnOrganikAtik_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "OrganikAtik")  //Atik turu OrganikAtik oldugunda bu kosula girer
            {
                organikDoluluk += atik.Hacim;  //Atik hacmini, metal dolulugunu tutan degiiskene atar.

                if (atik.Ad == "salatalik" && organikDoluluk < 700)  //Atigin adi salatalik ve organik atigin dolulugu 700 den kucukse bu kosula girer.
                {
                    lbOrganikAtik.Items.Add("Salatalık(120)"); //Listboxa salataligin hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarOrganik.Value += atik.Hacim;//ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();  //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.;
                }
                else if (atik.Ad == "domates" && organikDoluluk < 700)  //Atigin adi domates ve organik atigin dolulugu 700 den kucukse bu kosula girer.
                {
                    lbOrganikAtik.Items.Add("Domates(150)"); //Listboxa domatesin hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarOrganik.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();  //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.
                }
               
            }
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            if (atik.Tur == "KagitAtik" )//Atik turu KagitAtik oldugunda bu kosula girer
            {
                kagitDoluluk += atik.Hacim;  //Atik hacmini, metal dolulugunu tutan degiiskene atar.

                if (atik.Ad == "dergi" && kagitDoluluk < 1200)  //Atigin adi dergi ve kagit atigin dolulugu 1200 den kucukse bu kosula girer.
                {
                    lbKagit.Items.Add("Dergi(200)"); //Listboxa domatesin hacmi ve adi yazdirilir.
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarKagit.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();  //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.
                }
                else if (atik.Ad == "gazete" && kagitDoluluk < 1200) //Atigin adi dergi ve kagit atigin dolulugu 1200 den kucukse bu kosula girer.
                {
                    lbKagit.Items.Add("Gazete(250)"); //Listboxa domatesin hacmi ve adi yazdirilir. 
                    toplamPuan += atik.Hacim; //Toplam puana atıgın hacmi kadar puan eklenir
                    lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                    pBarKagit.Value += atik.Hacim; //ProgressBara atigin hacmi kadar deger atanir.
                    atik.rastgeleUret();  //Yeni atik icin random atik uretilir.
                    resimAta(); //Uretilen atigin resmini atayan fonk cagirilir.
                    atik.ozellikAta(); //Uretilen atiga ait ozellikleri atayan fonk. cagirilir.
                }
                
            }
        }
        public void resimAta()
        {
            if (atik.atik == "camsise") // Atik sinifinda olusturulan rastgele atik cam sise ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.camsise;
            }

            if (atik.atik == "cambardak") // Atik sinifinda olusturulan rastgele atik cam bardak ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.cambardak;
            }

            if (atik.atik == "salatalik")  // Atik sinifinda olusturulan rastgele atik salatalik ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.salatalik;
            }

            if (atik.atik == "domates")  // Atik sinifinda olusturulan rastgele atik domates ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.domates;
            }

            if (atik.atik == "dergi")  // Atik sinifinda olusturulan rastgele atik dergi ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.dergi;
            }

            if (atik.atik == "gazete")  // Atik sinifinda olusturulan rastgele atik gazete ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.gazete;
            }

            if (atik.atik == "salcakutusu")  // Atik sinifinda olusturulan rastgele atik kola kutusu ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.salcakutusu;
            }

            if (atik.atik == "kolakutusu")  // Atik sinifinda olusturulan rastgele atik kola kutusu ise bu kosula girer.
            {
                pbAtiklar.Image = Properties.Resources.kolakutusu;
            }
        }

        private void btnOrgBosalt_Click(object sender, EventArgs e)
        {
            if (organikDoluluk >= 0.75 * 700 ) // Organik kutusu toplam kapasitenin %75 nden büyükse bu kosula girer.
            {
                toplamPuan += 0; //Toplam puana 0 puan eklenir yani eklenmez.
                lbPuan.Text = toplamPuan.ToString(); 
                lbOrganikAtik.Items.Clear(); //Listbox temizlenir.
                //Degerler sifirlanir.
                organikDoluluk = 0;  
                pBarOrganik.Value = 0;
                //Kalan sureye +3 saniye eklenir.
                kalanSure = kalanSure + 3;
                lbSure.Text = kalanSure.ToString(); //Yenilenen kalansure labela yazdirlir.
            }

        }

        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {
            if (kagitDoluluk >= 0.75 * 1200) // Kagit kutusu toplam kapasitenin %75 nden büyükse bu kosula girer.
            {
                
                toplamPuan += 1000; //Toplam puana 1000 puan eklenir.
                lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                lbKagit.Items.Clear(); //Listbox temizlenir.
                //Degerler sifirlanir.
                kagitDoluluk = 0;
                pBarKagit.Value = 0; 
                //Kalan sureye +3 sn eklenir.
                kalanSure = kalanSure + 3; 
                lbSure.Text = kalanSure.ToString(); //Yenilenen kalanSure labela yazdirlir

            }


        }

        private void btnCamBosalt_Click(object sender, EventArgs e)
        {
            if (camDoluluk >= 0.75 * 2200) // Cam kutusu toplam kapasitenin %75 nden büyükse bu kosula girer.
            {
                toplamPuan += 600; //Toplam puana 600 puan eklenir.
                lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                lbCam.Items.Clear();//Listbox temizlenir.
                //Degerler sifirlanir.
                camDoluluk = 0;
                pBarCam.Value = 0;
                //Kalan sureye +3 sn eklenir.
                kalanSure = kalanSure +3;
                lbSure.Text = kalanSure.ToString(); //Yenilenen kalanSure labela yazdirlir
            }

        }

        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {
            if (metalDoluluk >= (0.75 * 2300)) // Metal kutusu toplam kapasitenin %75 nden büyükse bu kosula girer.
            {
                toplamPuan += 800; //Toplam puana 800 puan eklenir.
                lbPuan.Text = toplamPuan.ToString(); //Toplam puan labela yazdirilir.
                lbMetal.Items.Clear();//Listbox temizlenir.
                //Degerler sifirlanir.
                metalDoluluk = 0;
                pBarMetal.Value = 0;
                //Kalan sureye +3 sn eklenir.
                kalanSure = kalanSure + 3;
                lbSure.Text = kalanSure.ToString(); // Yenilenen kalanSure labela yazdirlir
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Program sonlandirilir.
        }
    }
}
