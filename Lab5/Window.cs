using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    sealed public class Window : Menu
    {
        private string _name;
        private int _width;
        private int _height;
        public string Name { get { return _name; } }
        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public Window(string name, int width, int height)
        {
            _name = name;
            _width = width;
            _height = height;
        }
    }
}
