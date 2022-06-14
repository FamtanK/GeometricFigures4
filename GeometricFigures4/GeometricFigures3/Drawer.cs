/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometricFigures4
{
    static class Drawer
    {
        static public void DrawLine(Panel pnl, Line line)
        {
            Graphics paper = pnl.CreateGraphics();
            var pen = new Pen(line.Stroke.Color, line.Stroke.Width);
            var A = line.A;
            var B = line.B;
            paper.DrawLine(pen, A.X, A.Y, B.X, B.Y);
        }

        static public void DrawCircle(Panel pnl, Circle circle)
        {
            Graphics paper = pnl.CreateGraphics();
            var pen = new Pen(circle.Stroke.Color, circle.Stroke.Width);
            var point = circle.basePoint;
            var radius = circle.Radius;
            paper.DrawEllipse(pen, point.X, point.Y, radius, radius);
        }

        static public void DrawRectangle(Panel pnl, Rectangle rectangle)
        {
            Graphics paper = pnl.CreateGraphics();
            var pen = new Pen(rectangle.Stroke.Color, rectangle.Stroke.Width);
            var point = rectangle.basePoint;
            var height = rectangle.Height;
            var width = rectangle.Width;
            paper.DrawRectangle(pen, point.X, point.Y, width, height);
        }

        static public void DrawTriangle(Panel pnl, Triangle triangle)
        {
            var A = triangle.A;
            var B = triangle.B;
            var C = triangle.C;
            Graphics paper = pnl.CreateGraphics();
            var pen = new Pen(triangle.Stroke.Color, triangle.Stroke.Width);
            var APoint = new System.Drawing.Point(A.X, A.Y);
            var BPoint = new System.Drawing.Point(B.X, B.Y);
            var CPoint = new System.Drawing.Point(C.X, C.Y);
            paper.DrawPolygon(pen, new System.Drawing.Point[]{APoint, BPoint, CPoint});
        }

        static public void CleanTable(Panel pnl)
        {
            Graphics paper = pnl.CreateGraphics();
            paper.Clear(Color.White);
        }
    }
}
