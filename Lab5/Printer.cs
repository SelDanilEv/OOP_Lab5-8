using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Printer
    {
        public virtual string IAmPrinting(IKristian someobj)
        {
            return someobj.ToString()+"\nВиртуальный метод";
        }
    }
    class A : Printer
    {
        public override string IAmPrinting(IKristian someobj)
        {
            return $"{someobj.GetType()}+\n+{someobj.ToString()}";
        }
    }
}
