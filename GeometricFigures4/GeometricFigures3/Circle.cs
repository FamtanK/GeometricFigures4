/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;

namespace GeometricFigures4
{
    [Serializable]
    class Circle : Figure
    {
        public int Radius;
        public StrokeData Stroke;

        public Circle(Point point, int radius) : base(point)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle at {basePoint}, Radius: {Radius}");
        }

        public override void Draw(TextBox tb)
        {
            tb.Text += $"Circle at {basePoint}, Radius: {Radius}" + "\r\n";
        }

        public override void Draw(Panel pnl)
        {
            Drawer.DrawCircle(pnl, this);
        }
    }
}
