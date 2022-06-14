/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GeometricFigures4
{
    class Figures
    {
        List<Figure> figures;

        public Figures()
        {
            figures = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public int GetCount()
        {
            return figures.Count;
        }

        public void Save(string path)
        {
            var formatter = new BinaryFormatter();
            try
            {
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    formatter.Serialize(stream, figures);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void Load(string path)
        {
            var formatter = new BinaryFormatter();
            try
            {
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    figures = (List<Figure>)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void Draw()
        {
            foreach (var figure in figures)
            {
                figure.Draw();
            }
        }

        public void Draw(TextBox tb)
        {
            tb.Text = "";

            foreach (var figure in figures)
            {
                tb.Text += figure.ToString() + "\r\n";
            }
        }

        public void Draw(Panel pnl)
        {
            foreach(var figure in figures)
            {
                figure.Draw(pnl);
            }
        }
    }
}