using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// Класс Круг. Экземпляр класса описывается радиусом и центром окружности.
    /// </summary>
    class Circle
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private int radius { get; set; }    
        /// <summary>
        /// Центр окружности
        /// </summary>
        private Point? O { get; set; }

        public Circle ()
        {
            O = new Point(150, 150);
            radius = 100;
        }

        public Circle(Point O, int radius) {
            this.O = O;
            this.radius = radius;
        }
        /// <summary>
        /// Отрисовка объекта Круг
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="pen"></param>
        public void DrawCircle(Graphics graph, Pen pen) {
            if (O == null)
            {
                throw new Exception("Не определена точка центра окружности");
            }
            if (radius <= 0)
            {
                throw new Exception("Радиус окружности меньше либо равен нулю");
            }
            graph.DrawEllipse(pen, O.Value.X, O.Value.Y, radius, radius);
        }


    }
}
