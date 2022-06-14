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
using System.IO;

namespace GeometricFigures4
{
    public partial class frmLine : Form
    {
        public frmLine()
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
                int AX = int.Parse(ACoords[0]);
                int AY = int.Parse(ACoords[1]);
                int BX = int.Parse(BCoords[0]);
                int BY = int.Parse(BCoords[1]);
                var line = new Line(AX, AY, BX, BY);
                if (color != Color.White)
                {
                    line.Stroke.Color = color;
                }
                else
                {
                    throw new Exception();
                }
                line.Stroke.Width = int.Parse(tbWidth.Text);
                frmMain.FiguresAdd(line);
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
