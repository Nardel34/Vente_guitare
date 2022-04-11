using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BASE;
using System.Collections.ObjectModel;

namespace Vente_Guitare.Coordination
{
    class C_COORDINATION : C_NOTIFIABLE
    {
        C_BASE la_base = new C_BASE();

        WS_GuitareSoapClient WS = new WS_GuitareSoapClient();

        public ObservableCollection<C_BOIS> Les_bois { get; set; }
        public ObservableCollection<C_MICRO> Les_micros { get; set; }
        public ObservableCollection<C_VIBRATO> Les_vibratos { get; set; }
        private int _les_guitares;

        public int Les_guitares
        {
            get { return _les_guitares; }
            set { _les_guitares = value; Signal_changement(); }
        }

        public void addGuitard(C_BOIS P_mancheBois, C_BOIS P_corpBois, C_BOIS P_toucheBois, 
                C_MICRO P_micro1, C_MICRO P_micro2, C_MICRO P_micro3, C_VIBRATO P_vibrato, C_USER P_user)
            {
            C_GUITARE guitard = new C_GUITARE()
            {
                BoisManche = P_mancheBois,
                BoisCorps = P_corpBois,
                BoisTouche = P_toucheBois,
                Micro = P_micro1,
                Micro1 = P_micro3,
                Micro2 = P_micro2,
                Proprietaire = P_user,
                Vibrato = P_vibrato,
            };
        }

        public void showPanier(C_USER P_user)
        {
            la_base.getGuitardByUser(P_user);
        }
    }
}
