using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LIB_BASE;

namespace WS_GUITARD
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // [System.Web.Script.Services.ScriptService]
    public class WS_GUITARD : System.Web.Services.WebService
    {
        C_BASE la_base = new C_BASE();

        // ----------- Wood Manager ------------------
        [WebMethod]
        public List<C_BOIS> getBois()
        {
            return la_base.getBois();
        }

        [WebMethod]
        public void addBois(C_BOIS bois1)
        {
            la_base.addBois(bois1);
        }

        [WebMethod]
        public void setBois(C_BOIS P_bois)
        {
            la_base.setBois(P_bois);
        }

        // ----------- Micro Manager ------------------
        [WebMethod]
        public List<C_MICRO> getMicros()
        {
            return la_base.getMicros();
        }

        [WebMethod]
        public void addMicro(C_MICRO C_micro)
        {
            la_base.addMicro(C_micro);
        }

        [WebMethod]
        public void setMicro(C_MICRO P_micro)
        {
            la_base.setMicro(P_micro);
        }

        // ----------- Vibrato Manager ------------------
        [WebMethod]
        public List<C_VIBRATO> getVibrato()
        {
            return la_base.getVibratos();
        }

        [WebMethod]
        public void addVibrato(C_VIBRATO C_vibrato)
        {
            la_base.addVibrato(C_vibrato);
        }

        [WebMethod]
        public void setVibrato(C_VIBRATO P_Vibrato)
        {
            la_base.setVibrato(P_Vibrato);
        }

        // ----------- Guitare Manager ------------------
        [WebMethod]
        public List<C_GUITARE> getGuitare()
        {
            return la_base.getGuitard();
        }

        [WebMethod]
        public void addGuitare(C_GUITARE arg1)
        {
            la_base.addGuitard(arg1);
        }

        [WebMethod]
        public void setGuitare(C_GUITARE P_guitard)
        {
            la_base.setGuitard(P_guitard);
        }

        [WebMethod]
        public List<C_GUITARE> getGuitareByUser(C_USER P_user)
        {
            return la_base.getGuitardByUser(P_user);
        }

        // ----------- Users Manager --------------
        [WebMethod]
        public List<C_USER> getUsers()
        {
            return la_base.getUsers();
        }

        public void addUser(C_USER arg1)
        {
            la_base.addUser(arg1);
        }

        public void setUser(C_USER P_user)
        {
            la_base.setUser(P_user);
        }
    }
}
