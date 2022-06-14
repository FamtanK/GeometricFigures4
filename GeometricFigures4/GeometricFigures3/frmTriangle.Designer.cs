/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    partial class frmTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBCoords = new System.Windows.Forms.Label();
            this.lblCCoords = new System.Windows.Forms.Label();
            this.tbACoords = new System.Windows.Forms.TextBox();
            this.tbBCoords = new System.Windows.Forms.TextBox();
            this.tbCCoords = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A point coords(x, y)";
            // 
            // lblBCoords
            // 
            this.lblBCoords.AutoSize = true;
            this.lblBCoords.Location = new System.Drawing.Point(30, 76);
            this.lblBCoords.Name = "lblBCoords";
            this.lblBCoords.Size = new System.Drawing.Size(175, 20);
            this.lblBCoords.TabIndex = 1;
            this.lblBCoords.Text = "Enter B point coords(x, y)";
            // 
            // lblCCoords
            // 
            this.lblCCoords.AutoSize = true;
            this.lblCCoords.Location = new System.Drawing.Point(29, 124);
            this.lblCCoords.Name = "lblCCoords";
            this.lblCCoords.Size = new System.Drawing.Size(175, 20);
            this.lblCCoords.TabIndex = 2;
            this.lblCCoords.Text = "Enter C point coords(x, y)";
            // 
            // tbACoords
            // 
            this.tbACoords.Location = new System.Drawing.Point(253, 31);
            this.tbACoords.Name = "tbACoords";
            this.tbACoords.Size = new System.Drawing.Size(125, 27);
            this.tbACoords.TabIndex = 3;
            // 
            // tbBCoords
            // 
            this.tbBCoords.Location = new System.Drawing.Point(253, 76);
            this.tbBCoords.Name = "tbBCoords";
            this.tbBCoords.Size = new System.Drawing.Size(125, 27);
            this.tbBCoords.TabIndex = 4;
            // 
            // tbCCoords
            // 
            this.tbCCoords.Location = new System.Drawing.Point(253, 124);
            this.tbCCoords.Name = "tbCCoords";
            this.tbCCoords.Size = new System.Drawing.Size(125, 27);
            this.tbCCoords.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Location = new System.Drawing.Point(29, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(284, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(141, 215);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(123, 29);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(30, 174);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(133, 20);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Enter border width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(253, 171);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(125, 27);
            this.tbWidth.TabIndex = 10;
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCCoords);
            this.Controls.Add(this.tbBCoords);
            this.Controls.Add(this.tbACoords);
            this.Controls.Add(this.lblCCoords);
            this.Controls.Add(this.lblBCoords);
            this.Controls.Add(this.label1);
            this.Name = "frmTriangle";
            this.Text = "Triangle form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblBCoords;
        private Label lblCCoords;
        private TextBox tbACoords;
        private TextBox tbBCoords;
        private TextBox tbCCoords;
        private Button btnSave;
        private Button btnClose;
        private Button btnColor;
        private Label lblWidth;
        private TextBox tbWidth;
    }
}