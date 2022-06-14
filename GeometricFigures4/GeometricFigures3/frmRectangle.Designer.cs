/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    partial class frmRectangle
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
            this.tbBaseCoords = new System.Windows.Forms.TextBox();
            this.lblBasePointCoords = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblBorderWidth = new System.Windows.Forms.Label();
            this.tbBorderWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbBaseCoords
            // 
            this.tbBaseCoords.Location = new System.Drawing.Point(279, 40);
            this.tbBaseCoords.Name = "tbBaseCoords";
            this.tbBaseCoords.Size = new System.Drawing.Size(163, 27);
            this.tbBaseCoords.TabIndex = 0;
            // 
            // lblBasePointCoords
            // 
            this.lblBasePointCoords.AutoSize = true;
            this.lblBasePointCoords.Location = new System.Drawing.Point(44, 47);
            this.lblBasePointCoords.Name = "lblBasePointCoords";
            this.lblBasePointCoords.Size = new System.Drawing.Size(201, 20);
            this.lblBasePointCoords.TabIndex = 1;
            this.lblBasePointCoords.Text = "Enter base point coords (x, y)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(44, 102);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(89, 20);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Enter height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(44, 150);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(84, 20);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Enter width";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(279, 95);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(163, 27);
            this.tbHeight.TabIndex = 4;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(279, 143);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(163, 27);
            this.tbWidth.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Location = new System.Drawing.Point(44, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(334, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(179, 237);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(115, 40);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblBorderWidth
            // 
            this.lblBorderWidth.AutoSize = true;
            this.lblBorderWidth.Location = new System.Drawing.Point(44, 194);
            this.lblBorderWidth.Name = "lblBorderWidth";
            this.lblBorderWidth.Size = new System.Drawing.Size(133, 20);
            this.lblBorderWidth.TabIndex = 9;
            this.lblBorderWidth.Text = "Enter border width";
            // 
            // tbBorderWidth
            // 
            this.tbBorderWidth.Location = new System.Drawing.Point(279, 187);
            this.tbBorderWidth.Name = "tbBorderWidth";
            this.tbBorderWidth.Size = new System.Drawing.Size(163, 27);
            this.tbBorderWidth.TabIndex = 10;
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 299);
            this.Controls.Add(this.tbBorderWidth);
            this.Controls.Add(this.lblBorderWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBasePointCoords);
            this.Controls.Add(this.tbBaseCoords);
            this.Name = "frmRectangle";
            this.Text = "Rectangle form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBaseCoords;
        private Label lblBasePointCoords;
        private Label lblHeight;
        private Label lblWidth;
        private TextBox tbHeight;
        private TextBox tbWidth;
        private Button btnSave;
        private Button btnClose;
        private Button btnColor;
        private Label lblBorderWidth;
        private TextBox tbBorderWidth;
    }
}