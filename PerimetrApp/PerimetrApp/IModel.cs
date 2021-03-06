﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    /// <summary>
    /// Протокол для разработки подсчета периметра прямоугольника
    /// </summary>
    interface IModel
    {
        /// <summary>
        /// Метод, возвращаюший периметр прямоугольника по двум сторонам
        /// </summary>
        /// <param name="a">Одна сторона прямоугольника</param>
        /// <param name="b">Другая сторона прямоугольника</param>
        /// <returns></returns>
        int GetP(int a, int b);
    }
}
