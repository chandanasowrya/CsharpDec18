
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Security;




namespace SelectUser
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUser nu = new NewUser();
            nu.createSelectUser();
            Console.WriteLine("Welcome to GitHub");
            Console.WriteLine("Welcome to GitHub");
        }

    }

    class NewUser
    {

        //# region createSelectUser
        //      public void createSelectUser()
        //      {

        //           for (int i = 6; i <= 6; i++)
        //           {

        //                  string domain="[SERVER]";
        //                  string userName = "admin";
        //                  string password = "Passw0rd";
        //                  string selectServerName = "FNFSEZWK159";
        //                  string selectServerUri = "http://" + selectServerName + ":8383";

        //                  NetworkCredential networkCred = new NetworkCredential(domain,userName,password);


        //                      SelectServer ss = new SelectServer(new Uri(selectServerUri));
        //                      ISecurityManager secMgr = ss.GetService<ISecurityManager>();

        //                      SelectIdentityDescriptor sid = new SelectIdentityDescriptor();
        //                      ISecurityUser newUser = secMgr.NewUser(sid);


        //                      newUser.Name = "FIT2NET\\FIPerfTestUser" + i.ToString() ;
        //                      //newUser.Description = "Fidelity Performance Test User" + i.ToString(); 
        //                      //newUser.FirstName = "FIPerfTest"; 
        //                      //newUser.LastName = "User" + i.ToString(); 
        //                      //newUser.EmailAddress = "FIPerfTestUser" + i.ToString() + "@fnf.com";

        //                      secMgr.ApplyChanges(newUser);

        //           }


        //       }

        //  # endregion



        public void createSelectUser()
        {
            //string domain = "[SERVER]";
            //string userName = "admin";
            //string password = "Passw0rd";
            string selectServerUri = "http://FNFSEZWK159:8383";


            try
            {
                //NetworkCredential networkCred = new NetworkCredential(domain, userName, password);
                //SelectServer ss = new SelectServer(new Uri(selectServerUri));
                //ss.EnsureAuthenticated();
                //ISecurityManager secMgr = ss.GetService<ISecurityManager>();

                //SelectIdentityDescriptor sid = new SelectIdentityDescriptor();
                //ISecurityUser newUser = secMgr.NewUser(sid);
                //newUser.Name = "FIT2NET\\TestUser";

                //ISecurityIdentity isi = ss.GetService<ISecurityIdentity>();

                //secMgr.ResetPassword(newUser, "123!@#Sof");

                //secMgr.ApplyChanges(newUser);

            }



            catch (Exception ex)
            {
                throw new Exception("select login failed due to following error:", ex);
            }
        }

    }


}

