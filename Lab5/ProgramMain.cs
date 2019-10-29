using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab5
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            Human creator = new Human("Danil", 1, 18, 4, 1, 2001, 130);
            string[] someargs = { "diff args", "something" };
            Button butStart = new Button(false, 10, 3, "Start", "romb", "green", "solid", 1);
            Button butExit = new Button(false, 10, 2, "Exit", "circle", "black", "solid", 10);
            Button butNext = new Button(true, 15, 4, "Next", "Triangle", "gradient", "not", 0);
            IButton butIHello = new Button(false, 1, 1, "Hello", "square", "not", "not", 0);
            Decor decor;
            decor = butExit as Decor;
            Console.WriteLine("\t Part 1");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("================================================");
            Console.WriteLine("Вывод созданных объектов");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(butStart.ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(butExit.ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(butNext.ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(butIHello.ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(decor.ToString());
            Console.WriteLine("================================================");
            Console.WriteLine("\n================================================");
            Console.WriteLine("Абстрактный метод vs Интерфейсовый метод");
            Console.WriteLine("------------------------------------------------");
            butExit.onClickRightButton(creator, someargs);
            Console.WriteLine("------------------------------------------------");
            butIHello.onClickRightButton(creator, someargs);
            Console.WriteLine("================================================");
            Console.WriteLine("\n================================================");
            IButton buttonInterface;
            buttonInterface = butStart as IButton;
            Console.WriteLine("Что то что есть только в интерфейсе");
            Console.WriteLine("------------------------------------------------");
            buttonInterface.somethingOnlyInInterface();
            buttonInterface.GetMainInfo();
            butIHello.somethingOnlyInInterface();
            butIHello.GetMainInfo();
            Console.WriteLine("================================================");

            Console.WriteLine("\n\t Part 2");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("================================================");
            Console.WriteLine("Printer");
            Console.WriteLine("------------------------------------------------");
            IKristian manager1 = new Manager();
            INotKristian manager2 = new Manager();
            Printer printer = new Printer();
            Printer printerA = new A();
            Console.WriteLine(printer.IAmPrinting(manager1));
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(printerA.IAmPrinting(manager1));
            Console.WriteLine("------------------------------------------------");
            manager1.WriteManagedKristian();
            manager2.WriteManagedNoKristian();
            Console.WriteLine("================================================");
            Console.WriteLine("\n================================================");
            Console.WriteLine("Window");
            Console.WriteLine("------------------------------------------------");
            Window mywindow = new Window("ARCTICA", 100, 20);
            mywindow.ToString();
            mywindow.Add(butStart);
            mywindow.Add(butExit);
            mywindow.Add(butNext);
            mywindow.ToConsole();

            Console.WriteLine(mywindow.ListofElements[0].GetType());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(Window_controler.FreeSpace(mywindow));
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Поиск по имени : (Next)");
            Console.WriteLine(Window_controler.FindButton("Next", mywindow).ToString());
            Console.WriteLine("------------------------------------------------");

            try
            {
                Button buttonExeption = new Button(false, 10, -5, "Name", "romb", "green", "solid", 1); // отрицательный размер
            }
            catch (CreatingClassException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                Button buttonExeption = new Button(false, 10, 3,"", "romb", "green", "solid", 1); // нет имени
            }
            catch (CreatingClassException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                Button buttonExeption = new Button(false, 10, 3,"Ex", "", "green", "solid", 1); // нет формы
            }
            catch (CreatingClassException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                IButton[] arr = { butIHello, buttonInterface };
                int[] arr1 = { 1, 2, 3 };
                int i = 8;
                if (i > arr1.Length || i < 0)
                    throw new OutofRangeException(i, arr1.Length);
                else Console.WriteLine(arr[i].ToString());
            }
            catch (OutofRangeException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Вышло за пределы типа на значение: " + exception.OutValue.ToString());
                Console.WriteLine("Вышло за пределы массива на значение: " + exception.OutRange.ToString());
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                long i = 12;
                long x = i + int.MaxValue;
                if (x > int.MaxValue || x < int.MinValue)
                    throw new OutofRangeException(x);
            }
            catch (OutofRangeException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Вышло за пределы типа на значение: " + exception.OutValue.ToString());
                Console.WriteLine("Вышло за пределы массива на значение: " + exception.OutRange.ToString());
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                int x = 10;
                int y = 0;
                int result = (y == 0) ? throw new ArithmeticException() : x / y;
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                int x = 0;
                int y = 10 / x;
            }
            catch
            {
                Console.WriteLine("Вызвано исключение");
            }
            finally
            {
                Console.WriteLine("Обработка ошибок завершена");
            }
            Console.WriteLine("------------------------------------------------");
            int[] aa = null;
            Debug.Assert(aa != null, "Values array cannot be null");

            Console.ReadKey();
        }
    }
}
