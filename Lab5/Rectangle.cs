using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Rectangle : Decor
    {
        private string type;
        public override string Type
        {
            get => type;
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

        public Rectangle() : base()
        {
            type = "Прямоугольник обыкновенный";
        }
        public Rectangle(bool _gradient, int _width, int _height, string name, string form, string color, string border, int border_size)
            : base(_gradient, _width, _height, name, form, color, border, border_size)
        {
            form = "Rectangle";
            type = "Прямоугольник но с параметрами";
        }



        public override void onClickRightButton(Human sender, string[] args) { }
        public override void onClickWrongButton(Human sender, string[] args) { }

    }
}
