using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricFigures.Figures
{
    /// <summary>
    /// Класс Треугольник. Экзземпляр класса описывается тремя точками на плоскости.
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// Первая точка
        /// </summary>
        private Point? A { get; set; }
        /// <summary>
        /// Вторая точка
        /// </summary>
        private Point? B { get; set; }
        /// <summary>
        /// Третья точка
        /// </summary>
        private Point? C { get; set; }

        public Triangle()
        {
            A = new Point(150, 150);
            B = new Point(200, 200);
            C = new Point(250, 150);
        }

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;

        }

        /// <summary>
        /// Отрисовка объекта Треугольник
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="pen"></param>
        public void DrawTriangle (Graphics graph, Pen pen)
        {
            if (A == null || B == null || C == null)
            {
                throw new Exception("Не определены точки треугольника");
            }
            Point[] points = new Point[4] { (Point)A, (Point)B, (Point)C, (Point)A };           
            graph.DrawLines(pen, points);
        }
    }
}
