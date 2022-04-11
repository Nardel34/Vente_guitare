using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_GUITARD_CMD.NS_WS_LOCAL;

namespace WS_GUITARD_CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WS_GUITARDSoapClient client = new WS_GUITARDSoapClient();

            foreach (var item in client.getGuitare())
            {
                Console.WriteLine(item.Id_Guitare);
            }
        }
    }
}
