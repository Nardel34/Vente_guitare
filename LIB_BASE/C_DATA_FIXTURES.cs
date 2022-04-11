using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BASE
{
    public class C_DATA_FIXTURES
    {
        C_BASE_AZURE Base_azure = new C_BASE_AZURE();

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

        public void removeAllBois()
        {
            foreach (var item in getBois())
            {
                Base_azure.Les_Bois.Remove(item);
            }
            Base_azure.SaveChanges();
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

        public void removeAllMicro()
        {
            foreach (var item in getMicros())
            {
                Base_azure.Les_Micros.Remove(item);
            }
            Base_azure.SaveChanges();
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

        public void removeAllVibrato()
        {
            foreach (var item in getVibratos())
            {
                Base_azure.Les_Vibratos.Remove(item);
            }
            Base_azure.SaveChanges();
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

        public void removeAllUsers()
        {
            foreach (var item in getUsers())
            {
                Base_azure.Les_Users.Remove(item);
            }
            Base_azure.SaveChanges();
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

        public void removeAllGuitard()
        {
            foreach (var item in getGuitard())
            {
                Base_azure.Les_guitares.Remove(item);
            }
            Base_azure.SaveChanges();
        }

        // -------------- Fixtures Loader ---------------
        public void removeAll()
        {
            removeAllGuitard();
            removeAllBois();
            removeAllMicro();
            removeAllUsers();
            removeAllVibrato();
        }

        public void dataFixturesLoad()
        {
            // Add bois
            C_BOIS un_bois = new C_BOIS() { Prix = "12", Type = "Chêne" };
            C_BOIS un_bois2 = new C_BOIS() { Prix = "13", Type = "Platane" };
            C_BOIS un_bois3 = new C_BOIS() { Prix = "14", Type = "Pommier" };
            addBois(un_bois);
            addBois(un_bois2);
            addBois(un_bois3);

            // Add Micro
            C_MICRO un_micro = new C_MICRO() { Prix = "12", Reference = "PHILLIPS" };
            C_MICRO un_micro2 = new C_MICRO() { Prix = "13", Reference = "SONY" };
            C_MICRO un_micro3 = new C_MICRO() { Prix = "14", Reference = "AKG" };
            addMicro(un_micro);
            addMicro(un_micro2);
            addMicro(un_micro3);

            // Add Vibrato
            C_VIBRATO un_vibrato = new C_VIBRATO() { Prix = "12", Type = "Vibrato1" };
            C_VIBRATO un_vibrato2 = new C_VIBRATO() { Prix = "13", Type = "Vibrato2" };
            C_VIBRATO un_vibrato3 = new C_VIBRATO() { Prix = "14", Type = "Vibrato3" };
            addVibrato(un_vibrato);
            addVibrato(un_vibrato2);
            addVibrato(un_vibrato3);

            // Add Users
            C_USER user = new C_USER() { Nom = "Nom1", Prenom = "Prenom1", Email = "email@gmail.com", telephone = "0707070707" };
            C_USER user2 = new C_USER() { Nom = "Nom2", Prenom = "Prenom2", Email = "email2@gmail.com", telephone = "0707070707" };
            C_USER user3 = new C_USER() { Nom = "Nom3", Prenom = "Prenom3", Email = "email3@gmail.com", telephone = "0707070707" };
            addUser(user);
            addUser(user2);
            addUser(user3);

            // Add guitare
            C_GUITARE une_guitare = new C_GUITARE()
            {
                BoisCorps = un_bois,
                BoisManche = un_bois2,
                BoisTouche = un_bois2,
                Micro = un_micro,
                Micro1 = un_micro3,
                Micro2 = un_micro3,
                Vibrato = un_vibrato3,
                Proprietaire = user
            };
            addGuitard(une_guitare);
        }
    }
}
