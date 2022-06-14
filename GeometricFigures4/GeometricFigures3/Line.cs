/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;

namespace GeometricFigures4
{
    [Serializable]
    class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public StrokeData Stroke;

        public Line(Point a, Point b) : base(a)
        {
            B = b;
        }

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
        }

        public override void Draw()
        {
            Console.WriteLine($"Line A {A} - B {B}");
        }

        public override void Draw(TextBox tb)
        {
            tb.Text += $"Line A: {A} - B {B}" + "\r\n";
        }

        public override void Draw(Panel pnl)
        {
            Drawer.DrawLine(pnl, this);
        }
    }
}
