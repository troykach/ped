﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using библиотекаМетодовРоботаНаСтруктуреПоле;
using библиотекаФормированияСред;

namespace решениеЗадачиИспВизРобот
{
    static class Program
    {
        static инфоРобот робот;
        static построительСреды построитель = new построительСреды();
        static ситуацияНаПоле поле;
        /*
         *    Задача № 1 Операторы while и if
         *    Робот в замкнутом прямоугольнике, но вне «комнаты», находящейся в том же прямоугольнике.
         *    Робот вошел в «комнату».
         *      Робот - в первой клетке «комнаты», расположенной сразу у входа. (Она будет помечена на изображении буквой К.)
         *      
         *       Определение 1 : «Комната» - это прямоугольный огороженный со всех сторон участок поля, имеющий одну «дверь».
         *       
         *       Определение 2 : «Дверь» - это одноклеточный проход в горизонтальной или вертикальной стене.
         */

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            поле = построитель.построительСредыРобота("while", 6);
            //Application.Run(new средаРобота(поле));

            робот = new инфоРобот(поле);
            решениеЗадачи();
            поле = робот.результатРаботы;
            Application.Run(new средаРобота(поле));

        }
        // Пример решения задачи 1 из группы 2 
        static ситуацияНаПоле решениеЗадачи()
        {
            робот.вверх();
            while (робот.слеваСтена && робот.справаСтена)
            {
                робот.закрасить();
                робот.вверх();
            }
            робот.вниз();
            while (робот.клеткаЗакрашена)
            {
                робот.вниз();
            }
            while (робот.слеваСтена && робот.справаСтена)
            {
                робот.вниз();
            }
            while (!робот.клеткаЗакрашена)
            {
                робот.закрасить();
                робот.вверх();
            }
            робот.вниз();

            return робот.результатРаботы;
        }
    }
}
        