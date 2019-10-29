using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Manager : IKristian, INotKristian
    {
        void IKristian.WriteManagedKristian()
        {
            Console.WriteLine("Write like true cristian");
        }

        void INotKristian.WriteManagedNoKristian()
        {
            Console.WriteLine("Write like not true cristian");
        }
    }
}
