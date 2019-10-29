using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public partial class Human
    {
        public Human()
        {
            age = 18;
            sex = 0;
            date = new Birthday(0, 0, 0);
            iq = 75;
            name = "";
        }
        public Human(string _name, int _sex, int _age, int _day, int _month, int _year, int _iq)
        {
            age = _age;
            if (_sex == 1)
                sex = HumanSex.Man;
            else if (_sex == 0)
                sex = HumanSex.Woman;
            else throw new CreatingClassException(this, sex.GetType()); ;
            iq = _iq;
            name = _name ?? throw new CreatingClassException(this);
            if (_day <= 0 || _day >= 32) throw new CreatingClassException(this, _day.GetType());
            if (_month <= 0 || _month >= 13) throw new CreatingClassException(this, _month.GetType());
            if (_year >= 2020) throw new CreatingClassException(this, _year.GetType());
            date = new Birthday(_day, _month, _year);
        }
    }
}
