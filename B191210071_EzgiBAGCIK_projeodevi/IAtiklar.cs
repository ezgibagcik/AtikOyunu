using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210071_EzgiBAGCIK_projeodevi
{
    //Atik sinifina rehberlik eden ve Atik sinifinin kalıtım aldigi interface tasarlandi.
    public interface IAtiklar
    {
        int Hacim { get; } 
        string Tur { get; }
        string Ad { get; }
        void ozellikAta();
        void rastgeleUret();
    }

  
    public interface IAtikKutusu : IDolabilen
    {   
        int BosaltmaPuani { get; } 
        bool Ekle(IAtiklar atik);
        bool Bosalt();  

       
                      
    }

    public interface IDolabilen
    {
        int Kapasite { get;  }
        int DoluHacim { get; } 
        int DolulukOrani { get; }
    }
}
