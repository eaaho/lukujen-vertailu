using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lukujen_vertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Annappa luku: ");
            int intNro = int.Parse(Console.ReadLine());
            

            if (intNro > 0)
            {
                Console.WriteLine("Luku on " + (intNro.ToString()) + " ja se on positiivinen.");
            }

            if (intNro < 0)
            {
                Console.WriteLine("Luku on " + (intNro.ToString()) + " ja se on negatiivinen.");
            }

            if (intNro == 0)
            {
                Console.WriteLine("Luku on 0.");
            }

            Console.ReadKey();

        }
    }
}
