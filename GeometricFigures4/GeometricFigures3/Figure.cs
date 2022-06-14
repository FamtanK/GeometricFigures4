/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;

namespace GeometricFigures4
{
    [Serializable]
    public class Figure
    {
        public Point basePoint;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new Point(x, y);
        }

        public virtual void Draw()
        { }

        public virtual void Draw(TextBox tb)
        { }

        public virtual void Draw(Panel pnl)
        {

        }
    }
}
