using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public partial class Human:IHumanBehavoir
    {
        private string name;
        public string Name { get { return name; } }
        private int age;
        public int Age
        {
            get => age;
        }
        private int iq;
        public int IQ
        {
            get => iq;
        }
        struct Birthday
        {
            public int day;
            public int month;
            public int year;
            public Birthday(int _day, int _month, int _year)
            {

                day = _day;
                month = _month;
                year = _year;
            }
        }
        private enum HumanSex
        {
            Woman = 0,
            Man
        };

        private Birthday date;
        public int Day => date.day;
        public int Month => date.month;
        public int Year => date.year;

        private HumanSex sex;
        public string Sex
        {
            get
            {
                if (sex == HumanSex.Man)
                    return "Man";
                if (sex == HumanSex.Woman)
                    return "Woman";
                return "?";
            }
        }

        protected string BirthDate()
        {
            if ((date.day <= 0) || (date.day >= 32)||(date.month <= 0) || (date.month >= 13) || (date.year >=2020 ))
                return "Неверно указана дата";
            return date.day.ToString() + ':' + date.month.ToString() + ':' + date.year.ToString();
        }
        public override string ToString()
        {
            return "Человек:\n" +
                   "Возраст: " + age + " лет" +
                   "\nИмя: " + Name.ToString() +
                   "\nПол: " + Sex.ToString() +
                   "\nГод рождения: " + BirthDate()+
                   "\nIQ " +IQ;
        }

        public void Think()
        {
            Console.WriteLine("Кажется у меня работает мозг");
        }
        public void Do()
        {
            Console.WriteLine("Я сейчас что нибудь сделаю");
        }

    }
}
