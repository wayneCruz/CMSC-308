using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingArraysByIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = { "reg.realeza@gmail.com", "uchiha.itachi@gmail.com", "hana.uzaki@gmail.com"};
            string[] username = { "rreginarose", "itachiuchiha", "uzakichan" };
            string[] password = {"Yeyel", "shinobi", "sensei"};

            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email: " + (email[index]));
            Console.WriteLine("Username: " + username[index]);
            Console.WriteLine("Password: " + password[index]);
            Console.ReadKey();
        }
    }
}
