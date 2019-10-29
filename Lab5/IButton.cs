using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IButton
    {
        void onClickRightButton(Human sender , string[] args);
        void onClickWrongButton(Human sender , string[] args);
        void somethingOnlyInInterface();
        void GetMainInfo();
    }
}
