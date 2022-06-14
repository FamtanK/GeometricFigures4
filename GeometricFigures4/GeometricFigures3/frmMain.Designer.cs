/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblPnlFigures = new System.Windows.Forms.TableLayoutPanel();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.pnlFigures = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPnlFigures.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPnlFigures
            // 
            this.tblPnlFigures.ColumnCount = 1;
            this.tblPnlFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPnlFigures.Controls.Add(this.btnTriangle, 0, 3);
            this.tblPnlFigures.Controls.Add(this.btnRectangle, 0, 1);
            this.tblPnlFigures.Controls.Add(this.btnCircle, 0, 0);
            this.tblPnlFigures.Controls.Add(this.btnLine, 0, 2);
            this.tblPnlFigures.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblPnlFigures.Location = new System.Drawing.Point(0, 28);
            this.tblPnlFigures.Name = "tblPnlFigures";
            this.tblPnlFigures.RowCount = 4;
            this.tblPnlFigures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlFigures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlFigures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlFigures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPnlFigures.Size = new System.Drawing.Size(129, 422);
            this.tblPnlFigures.TabIndex = 0;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTriangle.Location = new System.Drawing.Point(3, 318);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(123, 101);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRectangle.Location = new System.Drawing.Point(3, 108);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(123, 99);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCircle.Location = new System.Drawing.Point(3, 3);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(123, 99);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLine.Location = new System.Drawing.Point(3, 213);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(123, 99);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // pnlFigures
            // 
            this.pnlFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFigures.Location = new System.Drawing.Point(129, 28);
            this.pnlFigures.Name = "pnlFigures";
            this.pnlFigures.Size = new System.Drawing.Size(671, 422);
            this.pnlFigures.TabIndex = 3;
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 28);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "Menu strip";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiLoad,
            this.tsmiClean});
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(46, 24);
            this.tsmiMenu.Text = "File";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(224, 26);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(224, 26);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tsmiClean
            // 
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(224, 26);
            this.tsmiClean.Text = "Clean";
            this.tsmiClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFigures);
            this.Controls.Add(this.tblPnlFigures);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMain";
            this.Text = "Geometric Figures";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.tblPnlFigures.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblPnlFigures;
        private Button btnLine;
        private Button btnCircle;
        private Button btnTriangle;
        private Button btnRectangle;
        private Panel pnlFigures;
        private MenuStrip msMenu;
        private ToolStripMenuItem tsmiMenu;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiLoad;
        private ToolStripMenuItem tsmiClean;
    }
}