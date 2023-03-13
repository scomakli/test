using OOPExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class Authentication 
    {
        public string username = "scomakli";
        public string password = "12345";

        public bool AuthControl(string username,string password)
        {
            bool exception = false;
            
                if (username == null || password == null)
                {
                    exception= true;
                
                }
                else if (username == "scomakli" && password == "12345")
                {
                    Console.WriteLine("Giriş Başarılı");
                 
                }
                else
                {

                    exception= true;
                }
            return exception;
           
        }

        
    }
}
