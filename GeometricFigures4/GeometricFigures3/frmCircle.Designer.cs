/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    partial class frmCircle
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
            this.lblBaseCoords = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.tbBaseCoords = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblBorderWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBaseCoords
            // 
            this.lblBaseCoords.AutoSize = true;
            this.lblBaseCoords.Location = new System.Drawing.Point(50, 42);
            this.lblBaseCoords.Name = "lblBaseCoords";
            this.lblBaseCoords.Size = new System.Drawing.Size(197, 20);
            this.lblBaseCoords.TabIndex = 0;
            this.lblBaseCoords.Text = "Enter base point coords(x, y)";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(52, 97);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(87, 20);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Enter radius";
            // 
            // tbBaseCoords
            // 
            this.tbBaseCoords.Location = new System.Drawing.Point(280, 41);
            this.tbBaseCoords.Name = "tbBaseCoords";
            this.tbBaseCoords.Size = new System.Drawing.Size(125, 27);
            this.tbBaseCoords.TabIndex = 2;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(280, 90);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(125, 27);
            this.tbRadius.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Location = new System.Drawing.Point(43, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(311, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(154, 201);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(134, 29);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblBorderWidth
            // 
            this.lblBorderWidth.AutoSize = true;
            this.lblBorderWidth.Location = new System.Drawing.Point(52, 143);
            this.lblBorderWidth.Name = "lblBorderWidth";
            this.lblBorderWidth.Size = new System.Drawing.Size(133, 20);
            this.lblBorderWidth.TabIndex = 7;
            this.lblBorderWidth.Text = "Enter border width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(280, 140);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(125, 27);
            this.tbWidth.TabIndex = 8;
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 242);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lblBorderWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.tbBaseCoords);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblBaseCoords);
            this.Name = "frmCircle";
            this.Text = "Circle form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBaseCoords;
        private Label lblRadius;
        private TextBox tbBaseCoords;
        private TextBox tbRadius;
        private Button btnSave;
        private Button btnClose;
        private SaveFileDialog saveFileDialog1;
        private Button btnColor;
        private Label lblBorderWidth;
        private TextBox tbWidth;
    }
}