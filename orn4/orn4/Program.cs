using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orn4
{
    internal class Program
    {
        static void Main(string[] args)
        {        //Kullanıcının girmiş olduğu sayının tam bölen adedini gösteren uygulamayı yazınız.c#

            Console.WriteLine("Girilen sayı: ");
            int sayi =int.Parse(Console.ReadLine());

            int adet = 0;
            int f = 1;

            while (sayi <= f)
            {
                if (sayi % f==0)
                {

                   adet++;
                    
                }
                f++;
            }
            Console.WriteLine( "tam bölen: " +adet );
            Console.ReadKey();
        }
    }
}
