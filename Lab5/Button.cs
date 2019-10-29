using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public sealed partial class Button : Decor, IButton
    {
        private string type;
        public override string Type
        {
            get => type;
        }

        void IButton.onClickRightButton(Human sender, string[] args)       //явная реализация
        {
            Console.WriteLine("\nБыла нажата правильная кнопка и прога заработала(По интерфейсному)\n");
        }

        void IButton.onClickWrongButton(Human sender, string[] args)
        {
            Console.WriteLine("\nБыла нажата неправильная кнопка и прога сломалась(По интерфейсному)\n");
        }

        public override void onClickRightButton(Human sender, string[] args)
        {
            Console.WriteLine("\nБыла нажата правильная кнопка и прога заработала(По абстрактному)\n");
        }
        public override void onClickWrongButton(Human sender, string[] args)
        {
            Console.WriteLine("\nБыла нажата неправильная кнопка и прога сломалась(По абстрактному)\n");
        }


        public void GetMainInfo()
        {
            Console.WriteLine("Название: " + Name + "\nФорма: " + Form);
        }
        public override string ToString()
        {
            return "Тип:" + type + '\n' + ToConsoleFigure() +
                   "\nГрадиент: " + Gradient +
                   "\nВысота: " + Height +
                   "\nШирина: " + Width +
                   '\n';
        }
        public override int GetHashCode()
        {
            int sum = 137;
            sum += type.GetHashCode();
            sum += gradient.GetHashCode();
            sum += width.GetHashCode();
            sum += height.GetHashCode();
            return sum;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            if (obj.GetHashCode() != GetHashCode())
                return false;
            return true;
        }

        void IButton.somethingOnlyInInterface()
        {
            Console.WriteLine("It is only in interface");
        }
    }
}
