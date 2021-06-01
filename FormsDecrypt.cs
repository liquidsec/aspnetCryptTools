using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace FormsTicketCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test if input arguments were supplied.
            if (args.Length == 0)
            {
                Console.WriteLine("Please supply encrypted forms ticket");
                return;
            }
            string encryptedTicket = args[0];
            FormsAuthenticationTicket unencryptedTicket = FormsAuthentication.Decrypt(encryptedTicket);
            Console.WriteLine(unencryptedTicket.Version);
            Console.WriteLine(unencryptedTicket.Name);
            Console.WriteLine(unencryptedTicket.IssueDate);
            Console.WriteLine(unencryptedTicket.Expiration);
            Console.WriteLine(unencryptedTicket.IsPersistent);
            Console.WriteLine(unencryptedTicket.UserData);
            Console.WriteLine(unencryptedTicket.CookiePath);
            Console.ReadLine();
        }
    }
}
 
