using Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var kerner = new StandardKernel();
            kerner.Bind<ICreditCard>().To<MasterCard>();

            var shopper = kerner.Get<Shopper>();

            Console.WriteLine(shopper.Charge());
            Console.Read();
        }
    }
}
