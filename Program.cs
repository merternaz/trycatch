using System;
using System.Collections.Generic;


namespace tryCatch
{
    class Program
    {
         static void Main(string[] args)
        {

            /*
            try{
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a bir sayıdır");
                //a=s;
                
            }catch(Exception e){
                Console.WriteLine("Hata!"+e.Message.ToString());

            }
            finally{
                    Console.WriteLine("OK");
            }
*/

            //-----------------------------

             try{
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a bir sayıdır");
                //a=s;
                
            }catch(ArgumentNullException e){
                Console.WriteLine("Bos veri Hata!"+e.Message.ToString());

            }catch(ArgumentException e){
                Console.WriteLine("Veri hata!"+e.Message.ToString());

            }catch(OverflowException e){
                Console.WriteLine("Fazla deger !"+e.Message.ToString());

            }



            

        }
    }
}