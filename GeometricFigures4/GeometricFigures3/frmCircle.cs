/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures4
{
    public partial class frmCircle : Form
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        Color color = Color.White;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var baseCoords = tbBaseCoords.Text.Split(',');
                int baseX = int.Parse(baseCoords[0]);
                int baseY = int.Parse(baseCoords[1]);
                var basePoint = new Point(baseX, baseY);
                int radius = int.Parse(tbRadius.Text);
                var circle = new Circle(basePoint, radius);
                if (color != Color.White)
                {
                    circle.Stroke.Color = color;
                }
                else
                {
                    throw new Exception();
                }
                circle.Stroke.Width = int.Parse(tbWidth.Text);
                frmMain.FiguresAdd(circle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect coords format");
                return;
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            color = colorDialog.Color;
        }
    }
}
