using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BASE;

namespace TEST_CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------ DATA FICTURES LOADER -----------------------------
            //C_DATA_FIXTURES DataFixtures = new C_DATA_FIXTURES();
            //DataFixtures.removeAll();
            //DataFixtures.dataFixturesLoad();

            C_BASE la_base = new C_BASE();

            foreach (var item in la_base.getGuitardByUser(new C_USER() { Id_User = 38}))
            {
                Console.WriteLine(item.Id_Guitare);
            }
        }
    }
}
