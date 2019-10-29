using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    static class Window_controler
    {

        public static Button SearchSize(Window wind, int width , int height)
        {
            Console.WriteLine($"Searching element with size  {width} x {height}");
            foreach(Button button in wind.ListofElements)
            {
                if (button.Height == height && button.Width == width)
                    return button;
            }
            Console.WriteLine("\nNothing");
            return null;
        }

        public static Button SearchByColor(Window wind, string color)
        {
            Console.WriteLine("Searching element by color  " + color);
            bool flag = false;
            foreach (Button button in wind.ListofElements)
            {
                if (button.Color == color)
                {
                    return button;
                }
            }
            if (flag == false)
                Console.WriteLine("\nNothing");
            return null;
        }



        public static string FreeSpace(Window wind)
        {
            int allSpace = wind.Width * wind.Height;
            int busySpace = 0;
            foreach (Button button in wind.ListofElements)
            {
                busySpace += button.Height * button.Width;
            }
            if (allSpace - busySpace < 0) return ""; //прописать ошибку
            return $"Осталось свободного места: {allSpace - busySpace} px";
        }

        public static void PrintAllButtons(Window wind)
        {
            Console.WriteLine("Вывод всех кнопок");
            foreach (Button button in wind.ListofElements)
            {
                Console.WriteLine(button.Name);
            }
        }

        public static Button FindButton(string name, Window wind)
        {
            Button rc;
            Console.WriteLine("Поиск кнопки по имени");
            foreach (Button button in wind.ListofElements)
            {
                if (button.Name == name) return rc = button;
            }
            Console.WriteLine("Что то не нашли");
            return null;
        }

        public static int Counts(Window wind)
        {
            return wind.Count;
        }

    }
}
