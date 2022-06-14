/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    public partial class frmMain : Form
    {
        static Figures figures = new Figures();

        static public void FiguresAdd(Figure figure)
        {
            figures.Add(figure);
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            var frmLine = new frmLine();
            frmLine.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (figures.GetCount() != 0)
            {
                figures.Draw(pnlFigures);
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            var frmRectangle = new frmRectangle();
            frmRectangle.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var frmCircle = new frmCircle();
            frmCircle.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var frmTriangle = new frmTriangle();
            frmTriangle.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save figures";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                figures.Save(saveDialog.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var loadDialog = new OpenFileDialog();
            loadDialog.Title = "Load figures";
            loadDialog.ShowDialog();

            if (loadDialog.FileName != "")
            {
                figures.Load(loadDialog.FileName);
                figures.Draw(pnlFigures);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            figures = new Figures();
            Drawer.CleanTable(pnlFigures);
        }
    }
}