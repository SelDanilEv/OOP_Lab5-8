using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Menu
    {
        private List<Button> elements = new List<Button>();
        public List<Button> ListofElements
        {
            get => elements;
            set => elements = value;
        }
        public void Add(Button button)
        {
            elements.Add(button);
        }
        public void Remove(Button button)
        {
            elements.Remove(button);
        }
        public void ToConsole()
        {
            object[] arr = elements.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ' ' + arr[i].ToString() + '\n');
            }
        }
        public int Count => elements.Count;
    }
}
