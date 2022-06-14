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
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        Color color = Color.White;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ACoords = tbACoords.Text.Split(',');
                var BCoords = tbBCoords.Text.Split(',');
                var CCoords = tbCCoords.Text.Split(',');
                int AX = int.Parse(ACoords[0]);
                int AY = int.Parse(ACoords[1]);
                int BX = int.Parse(BCoords[0]);
                int BY = int.Parse(BCoords[1]);
                int CX = int.Parse(CCoords[0]);
                int CY = int.Parse(CCoords[1]);
                var triangle = new Triangle(AX, AY, BX, BY, CX, CY);
                if (color != Color.White)
                {
                    triangle.Stroke.Color = color;
                }
                else
                {
                    throw new Exception();
                }
                triangle.Stroke.Width = int.Parse(tbWidth.Text);

                frmMain.FiguresAdd(triangle);
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
