using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210071_EzgiBAGCIK_projeodevi
{
    class AtikKutusu 
    {
      
        public void atikKutulariTemizle()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"]; // Acik olan forma erisim saglandi.
            //Listboxların ici temizlenir.
            frm.lbCam.Items.Clear(); 
            frm.lbKagit.Items.Clear();
            frm.lbMetal.Items.Clear();
            frm.lbOrganikAtik.Items.Clear();
            //ProgressBarların degerleri 0 lanır.
            frm.pBarCam.Value = 0;
            frm.pBarKagit.Value = 0;
            frm.pBarMetal.Value = 0;
            frm.pBarOrganik.Value = 0;
            //Labellar ilk degerlerine getirilir.
            frm.lbPuan.Text = "";
            frm.lbSure.Text = "60";
        }

    }
}
