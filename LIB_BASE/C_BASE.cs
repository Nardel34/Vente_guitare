using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BASE;

namespace LIB_BASE
{
    public class C_BASE
    {
        C_BASE_AZURE Base_azure = new C_BASE_AZURE();

        public C_BASE()
        {
            Base_azure.Configuration.ProxyCreationEnabled = false;

            Base_azure.Les_Bois.Load();
            Base_azure.Les_Vibratos.Load();
            Base_azure.Les_Micros.Load();
            Base_azure.Les_Users.Load();
            Base_azure.Les_guitares.Load();
        }

        // ----------- Wood Manager --------------
        public List<C_BOIS> getBois()
        {
            return Base_azure.Les_Bois.ToList();
        }

        public void addBois(C_BOIS bois1)
        {
            Base_azure.Les_Bois.Add(bois1);
            Base_azure.SaveChanges();
        }
        public void setBois(C_BOIS P_bois)
        {
            C_BOIS bois = (from un_bois in Base_azure.Les_Bois where un_bois.Id_Bois == P_bois.Id_Bois select un_bois).FirstOrDefault();

            if (bois != null)
            {
                Base_azure.Les_Bois.Remove(bois);
                Base_azure.Les_Bois.Add(bois);
                Base_azure.SaveChanges();
            }
        }

        // ----------- Micro Manager --------------
        public List<C_MICRO> getMicros()
        {
            return Base_azure.Les_Micros.ToList();
        }

        public void addMicro(C_MICRO arg1)
        {
            Base_azure.Les_Micros.Add(arg1);
            Base_azure.SaveChanges();
        }

        public void setMicro(C_MICRO P_micro)
        {
            C_MICRO micro = (from un_micro in Base_azure.Les_Micros where un_micro.Id_Micro == P_micro.Id_Micro select un_micro).FirstOrDefault();

            if (micro != null)
            {
                Base_azure.Les_Micros.Remove(micro);
                Base_azure.Les_Micros.Add(micro);
                Base_azure.SaveChanges();
            }
        }

        // ----------- Vibrato Manager --------------
        public List<C_VIBRATO> getVibratos()
        {
            return Base_azure.Les_Vibratos.ToList();
        }

        public void addVibrato(C_VIBRATO arg1)
        {
            Base_azure.Les_Vibratos.Add(arg1);
            Base_azure.SaveChanges();
        }

        public void setVibrato(C_VIBRATO P_vibrato)
        {
            C_VIBRATO vibrato = (from un_vibrato in Base_azure.Les_Vibratos where un_vibrato.Id_Vibrato == P_vibrato.Id_Vibrato select un_vibrato).FirstOrDefault();

            if (vibrato != null)
            {
                Base_azure.Les_Vibratos.Remove(vibrato);
                Base_azure.Les_Vibratos.Add(vibrato);
                Base_azure.SaveChanges();
            }
        }

        // ----------- Users Manager --------------
        public List<C_USER> getUsers()
        {
            return Base_azure.Les_Users.ToList();
        }

        public void addUser(C_USER arg1)
        {
            Base_azure.Les_Users.Add(arg1);
            Base_azure.SaveChanges();
        }

        public void setUser(C_USER P_user)
        {
            C_USER user = (from un_user in Base_azure.Les_Users where un_user.Id_User == P_user.Id_User select un_user).FirstOrDefault();

            if (user != null)
            {
                Base_azure.Les_Users.Remove(user);
                Base_azure.Les_Users.Add(user);
                Base_azure.SaveChanges();
            }
        }

        // ----------- Guitard Manager --------------
        public List<C_GUITARE> getGuitard()
        {
            return Base_azure.Les_guitares.ToList();
        }

        public void addGuitard(C_GUITARE arg1)
        {
            Base_azure.Les_guitares.Add(arg1);
            Base_azure.SaveChanges();
        }

        public void setGuitard(C_GUITARE P_guitard)
        {
            C_GUITARE guitard = (from une_guitard in Base_azure.Les_guitares where une_guitard.Id_Guitare == P_guitard.Id_Guitare select une_guitard).FirstOrDefault();

            if (guitard != null)
            {
                Base_azure.Les_guitares.Remove(guitard);
                Base_azure.Les_guitares.Add(guitard);
                Base_azure.SaveChanges();
            }
        }

        public List<C_GUITARE> getGuitardByUser(C_USER P_user)
        {
            var req = from guitare in Base_azure.Les_guitares where guitare.Id_User == P_user.Id_User select guitare;

            return req.ToList();
        }
    }
}
