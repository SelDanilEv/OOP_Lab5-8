using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Decor : Figure
    {
        protected Decor() : base()
        {
            gradient = false;
            width = 0;
            height = 0;
        }
        protected Decor(bool _gradient,int _width , int _height, string name, string form, string color, string border, int border_size)
            : base( name, form, color,border,border_size)
        {
            if (_width < 0) throw new CreatingClassException(this, _width.GetType());
            if (_height < 0) throw new CreatingClassException(this, _height.GetType());
            height = _height;
            width = _width;
            gradient = _gradient;
        }
        protected int height;  //высота
        public int Height
        {
            get => height;
            set => height = value;
        }
        protected int width;      //ширина
        public int Width
        {
            get => width;
            set => width = value;
        }
        protected bool gradient;
        public bool Gradient
        {
            get => gradient;
            set => gradient = value;
        }
        abstract public string Type { get; }

        abstract public void onClickRightButton(Human sender, string[] args);
        abstract public void onClickWrongButton(Human sender, string[] args);
    }
}
