/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;

namespace GeometricFigures4
{
    [Serializable]
    class Rectangle : Figure
    {
        public int Height;
        public int Width;
        public StrokeData Stroke;

        public Rectangle(Point point, int height, int width) : base(point)
        {
            Height = height;
            Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle at {basePoint}, Height: {Height}, Width: {Width}");
        }

        public override void Draw(TextBox tb)
        {
            tb.Text += $"Rectangle at {basePoint}, Height: {Height}, Width: {Width}" + "\r\n";
        }

        public override void Draw(Panel pnl)
        {
            Drawer.DrawRectangle(pnl, this);
        }
    }
}
