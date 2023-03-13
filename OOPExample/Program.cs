using OOPExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Exceptionx = OOPExample.Models.ExceptionHandling;

namespace OOPExample
{
    class Program 
    {

        static void Main(string[] args)
        {
            
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            Authentication authentication= new Authentication();
            Console.WriteLine("Lütfen Kullanıcı Adı Giriniz=");
            string username=Console.ReadLine();
            Console.WriteLine("Lütfen Şifrenizi Giriniz=");
            string password=Console.ReadLine();
            bool exception2;
            try
            {
                exception2 = authentication.AuthControl(username, password);
                if(exception2==true)
                {
                    throw new Exception();
                }                                                  
                
            }
            catch (Exception)
            {
                exceptionHandling.AuthError();
            }
            
            Console.WriteLine("Otoparka Giriş Yapan Aracın Tipini,Markasını ve Model Yılını Giriniz");
            string VehicleInfos = Console.ReadLine();
            string[] VehicleInfoSplit = VehicleInfos.Split(' ');
            Console.WriteLine("Araç Giriş Yapıyorsa 1,Çıkış Yapıyorsa 2 Yazınız.");
            string InorOut = Console.ReadLine();

            if (VehicleInfoSplit[0] == "Araba") 
            {
                try

                {
                    Car car = new Car(VehicleInfoSplit[0], VehicleInfoSplit[1], VehicleInfoSplit[2]);
                    if (VehicleInfoSplit[1] != "" && VehicleInfoSplit[2]!="")
                    {
                        if (InorOut == "1")
                        {
                            car.EnteredPark();
                        }
                        else
                        {
                            car.CameOutPark();
                        }
                        car.Info();
                    }
               
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {                  
                    exceptionHandling.Error();
                }
            }
            if (VehicleInfoSplit[0] == "Otobüs")
            {
                try

                {
                    Car bus = new Car(VehicleInfoSplit[0], VehicleInfoSplit[1], VehicleInfoSplit[2]);
                    if (VehicleInfoSplit[1] != "" && VehicleInfoSplit[2] != "")
                    {
                        if (InorOut == "1")
                        {
                            bus.EnteredPark();
                        }
                        else
                        {
                            bus.CameOutPark();
                        }
                        bus.Info();
                    }

                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {
                    exceptionHandling.Error();
                }
            }
            if (VehicleInfoSplit[0] == "Kamyon")
            {
                try

                {
                    Car truck = new Car(VehicleInfoSplit[0], VehicleInfoSplit[1], VehicleInfoSplit[2]);
                    if (VehicleInfoSplit[1] != "" && VehicleInfoSplit[2] != "")
                    {
                        if (InorOut == "1")
                        {
                            truck.EnteredPark();
                        }
                        else
                        {
                            truck.CameOutPark();
                        }
                        truck.Info();
                    }

                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {
                    exceptionHandling.Error();
                }
            }
        }

    }
}
