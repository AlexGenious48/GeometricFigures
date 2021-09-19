using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricFigures.Figures;

namespace GeometricFigures
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;

        private Graphics graph;

        private Pen pen = new Pen(Color.Green);
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            graph = Graphics.FromImage(bmp);
            comboBox1.SelectedItem = "Треугольник";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            string selectedState = comboBox1.SelectedItem.ToString();
            graph.Clear(Color.Transparent);
            switch (selectedState)
            {
                case "Треугольник":                    
                    Triangle triangle = new Triangle();                    
                    triangle.DrawTriangle(graph, pen);
                    PictureBox.Image = bmp;
                    break;
                case "Прямоугольник":
                    Rectangle rect = new Rectangle(150, 150, 100, 150);
                    graph.DrawRectangle(pen, rect);
                    PictureBox.Image = bmp;
                    break;
                case "Круг":
                    Circle circle = new Circle();
                    circle.DrawCircle(graph, pen);
                    PictureBox.Image = bmp;
                    break;
                case "Квадрат":
                    Square square = new Square();
                    square.DrawSquare(graph,pen);
                    PictureBox.Image = bmp;
                    break;
                default:
                    break;
            }
            
        }
    }
}
