using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// Класс Квадрат. Экземлпяр класса описывается длиной стороны и точкой начала отрисовки 
    /// </summary>
    class Square
    {
        /// <summary>
        /// Длина стороны квадрата
        /// </summary>
        private int sideWidth { get; set; }
        /// <summary>
        /// Точка начала отрисовки
        /// </summary>
        private Point? startPoint { get; set; }

        public Square()
        {
            startPoint = new Point(150, 150);
            sideWidth = 100;
        }

        public Square(Point startPoint, int sideWidth)
        {
            this.startPoint = startPoint;
            this.sideWidth = sideWidth;
        }
        /// <summary>
        /// Отрисовка объекта Квадрат
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="pen"></param>
        public void DrawSquare(Graphics graph, Pen pen)
        {
            if (startPoint == null)
            {
                throw new Exception("Не определена точка начала отрисовки");
            }
            if (sideWidth <= 0)
            {
                throw new Exception("Сторона квадрата меньше либо равна нулю");
            }
            graph.DrawRectangle(pen, startPoint.Value.X, startPoint.Value.Y, sideWidth, sideWidth);
        }

    }
}
