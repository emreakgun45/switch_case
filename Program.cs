using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1 :
                    System.Console.WriteLine("Ocak ayindasiniz!");
                    break;
                case 2 :
                    System.Console.WriteLine("Subat ayindasiniz!");
                    break;
                case 3 :
                    System.Console.WriteLine("Mart ayindasiniz!");
                    break;
                case 4 : 
                    System.Console.WriteLine("Nisan ayindasiniz!");
                    break;
                case 5 :
                    System.Console.WriteLine("Mayis ayindasiniz!");
                    break;
                case 6 :
                    System.Console.WriteLine("Haziran ayindasiniz!");
                    break;
                case 7 : 
                    System.Console.WriteLine("Temmuz ayindasiniz!");
                    break;
                case 8 : 
                    System.Console.WriteLine("Agustos ayindasiniz");
                    break;
                case 9 :
                    System.Console.WriteLine("Eylul ayindasiniz!");
                    break;
                case 10 :
                    System.Console.WriteLine("Ekim ayindasiniz");
                    break;
                case 11 :
                    System.Console.WriteLine("Kasim ayindasiniz!");
                    break;
                case 12 :
                    System.Console.WriteLine("Aralik ayindasiniz!");
                    break;
                default:
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kis ayindasiniz!");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("Ilkbahar ayindasiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz ayindasiniz!");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar ayindasiniz!");
                    break;
                
                
                default:
                break;
            }






        }
    }
}
