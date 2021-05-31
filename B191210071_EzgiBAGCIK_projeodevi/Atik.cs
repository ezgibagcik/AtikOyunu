using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_projeodevi
{
    class Atik : IAtiklar, IDolabilen
    {
        private int _hacim;
        private string _tur;
        private string _ad;
        private int _kapasite;
        public string atik;
        public int Hacim
        {
            get => _hacim;
        }
        public string Tur
        {
            get => _tur;
        }
        public string Ad
        {
            get => _ad;
        }
        public int Kapasite
        {
            get => _kapasite;
        }

        public int DoluHacim => DoluHacim;
        public int DolulukOrani => DolulukOrani;


        public Atik() // Nesne olustugunda rastgele atik uretmesi ve ozelliklerin atanmasi icin kurucu fonksiyon olusturuldu
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.
            rastgeleUret();
            ozellikAta();
            
        }
        public void rastgeleUret()
        {
            Random rnd = new Random(); //Random sinifindan nesne olusturulur.

            List<string> atikAdlar = new List<string>();  //List sinifindan nesne olusturulur.

            //Olusturulan atikAdlar listesine degerler eklenir.
            atikAdlar.Add("cambardak"); 
            atikAdlar.Add("camsise");
            atikAdlar.Add("dergi");
            atikAdlar.Add("domates");
            atikAdlar.Add("gazete");
            atikAdlar.Add("kolakutusu");
            atikAdlar.Add("salatalik");
            atikAdlar.Add("salcakutusu");

            //atik degiskenine rastgele bir atik atanir.
            atik = atikAdlar[rnd.Next(0, 7)];
        }
        public void ozellikAta() //Atiklarin ozellikleini atayan fonksiyondur.
        {

            if (atik == "camsise") //Rastegele atanan atik eger camsise ise ona ait ozellikleri atar.
            {
                _ad = "camsise";
                _tur = "CamAtik";
                _hacim = 600;
             
            }

            if (atik == "cambardak")  //Rastegele atanan atik eger cambardak ise ona ait ozellikleri atar.
            {
                _ad = "cambardak";
                _tur = "CamAtik";
                _hacim = 250;

            }

            if (atik == "salatalik") //Rastegele atanan atik eger salatalik ise ona ait ozellikleri atar.
            {
                _ad = "salatalik";
                _tur = "OrganikAtik";
                _hacim = 120;
            }

            if (atik == "domates") //Rastegele atanan atik eger domates ise ona ait ozellikleri atar.
            {
                _ad = "domates";
                _tur = "OrganikAtik";
                _hacim = 150;

            }

            if (atik == "dergi") //Rastegele atanan atik eger dergi ise ona ait ozellikleri atar.
            {
                _ad = "dergi";
                _tur = "KagitAtik";
                _hacim = 200;
            }

            if (atik == "gazete") //Rastegele atanan atik eger gazete ise ona ait ozellikleri atar.
            {
                _ad = "gazete";
                _tur = "KagitAtik";
                _hacim = 250;

            }

            if (atik == "salcakutusu") //Rastegele atanan atik eger salcakutusu ise ona ait ozellikleri atar.
            {

                _ad = "salcakutusu";
                _tur = "MetalAtik";
                _hacim = 550;

            }

            if (atik == "kolakutusu") //Rastegele atanan atik eger kolakutusu ise ona ait ozellikleri atar.
            {

                _ad = "kolakutusu";
                _tur = "MetalAtik";
                _hacim = 350;

            }
        }



    }
}
