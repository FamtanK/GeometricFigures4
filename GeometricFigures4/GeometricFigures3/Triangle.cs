/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;

namespace GeometricFigures4
{
    [Serializable]
    class Triangle : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;
        public StrokeData Stroke;

        public Triangle(Point a, Point b, Point c) : base(a)
        {
            B = b;
            C = c;

            var firstSide = Math.Round(Math.Sqrt((B.X - A.X) * (B.X - A.X) +
                                               (B.Y - A.Y) * (B.Y - A.Y)), 3);
            var secondSide = Math.Round(Math.Sqrt((C.X - B.X) * (C.X - B.X) +
                                                (C.Y - B.Y) * (C.Y - B.Y)), 3);
            var thirdSide = Math.Round(Math.Sqrt((C.X - A.X) * (C.X - A.X) +
                                               (C.Y - A.Y) * (C.Y - A.Y)), 3);
            if (!((firstSide < secondSide + thirdSide) &&
                (secondSide < firstSide + thirdSide) &&
                (thirdSide < firstSide + secondSide)))
            {
                throw new Exception();
            }
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);

            var firstSide = Math.Round(Math.Sqrt((B.X - A.X) * (B.X - A.X) +
                                               (B.Y - A.Y) * (B.Y - A.Y)), 3);
            var secondSide = Math.Round(Math.Sqrt((C.X - B.X) * (C.X - B.X) +
                                                (C.Y - B.Y) * (C.Y - B.Y)), 3);
            var thirdSide = Math.Round(Math.Sqrt((C.X - A.X) * (C.X - A.X) + 
                                               (C.Y - A.Y) * (C.Y - A.Y)), 3);
            if (!((firstSide < secondSide + thirdSide) &&
                (secondSide < firstSide + thirdSide) &&
                (thirdSide < firstSide + secondSide)))
            {
                throw new Exception();
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle A {A} - B {B} - C {C}");
        }

        public override void Draw(TextBox tb)
        {
            tb.Text += $"Triangle A {A} - B {B} - C {C}" + "\r\n";
        }

        public override void Draw(Panel pnl)
        {
            Drawer.DrawTriangle(pnl, this);
        }
    }
}
