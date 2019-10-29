using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public sealed partial class Button
    {
        public Button() : base()
        {
            type = "Кнопка обыкновенная";
        }
        public Button(bool _gradient, int _width, int _height, string name, string form, string color, string border, int border_size)
            : base(_gradient , _width,_height,name, form, color, border, border_size)
        {
            if (_width<0) throw new CreatingClassException(this, _width.GetType());
            if (_height <0) throw new CreatingClassException(this, _height.GetType());
            type = "Кнопка но с параметрами";
        }
    }
}
