using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    class Program
    {
        static void Main(string[] args)
        { 
            sini:

            try
            {
                
                Console.WriteLine("masukkan 1  : ");
                double x = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan 2  : ");
                double y = int.Parse(Console.ReadLine());
                Console.WriteLine(x + y);
                
            }
            catch (FormatException formatsalah)
            {
                Console.WriteLine(formatsalah.Message);
                //throw;
                

            }
            finally
            {
                Console.WriteLine("thanks dude");
            }
            Console.ReadLine();
            goto sini;
        }

    }
}
