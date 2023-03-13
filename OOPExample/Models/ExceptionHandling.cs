using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class ExceptionHandling : Interfaces.IException
    {
        public ExceptionHandling() { }
        
         public void Error()
        {
            Console.WriteLine("Araç Bilgileri Eksik Girildi");
        }
   
        public void AuthError()
        {
            Console.WriteLine("Kullanıcı Bilgileri Yanlış veya Eksik Girildi.");
        }
    }
}
