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
    public partial class frmRectangle : Form
    {
        public frmRectangle()
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
                int height = int.Parse(tbHeight.Text);
                int width = int.Parse(tbWidth.Text);
                var rectangle = new Rectangle(basePoint, height, width);
                rectangle.Stroke.Width = int.Parse(tbBorderWidth.Text);
                if (color != Color.White)
                {
                    rectangle.Stroke.Color = color;
                }
                else
                {
                    throw new Exception();
                }

                frmMain.FiguresAdd(rectangle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input format");
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
