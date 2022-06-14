/*
Ismagilov Ilgam, 220 group
Task "Geometric figures - 4"
08.06.2022
*/

namespace GeometricFigures4
{
    partial class frmLine
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
            this.btnSave = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblBCoords = new System.Windows.Forms.Label();
            this.lblACoords = new System.Windows.Forms.Label();
            this.tbACoords = new System.Windows.Forms.TextBox();
            this.tbBCoords = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Location = new System.Drawing.Point(44, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(491, 142);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // lblBCoords
            // 
            this.lblBCoords.AutoSize = true;
            this.lblBCoords.Location = new System.Drawing.Point(44, 74);
            this.lblBCoords.Name = "lblBCoords";
            this.lblBCoords.Size = new System.Drawing.Size(179, 20);
            this.lblBCoords.TabIndex = 6;
            this.lblBCoords.Text = "Enter B point coords (x, y)";
            // 
            // lblACoords
            // 
            this.lblACoords.AutoSize = true;
            this.lblACoords.Location = new System.Drawing.Point(44, 32);
            this.lblACoords.Name = "lblACoords";
            this.lblACoords.Size = new System.Drawing.Size(180, 20);
            this.lblACoords.TabIndex = 7;
            this.lblACoords.Text = "Enter A point coords (x, y)";
            // 
            // tbACoords
            // 
            this.tbACoords.Location = new System.Drawing.Point(261, 29);
            this.tbACoords.Name = "tbACoords";
            this.tbACoords.Size = new System.Drawing.Size(179, 27);
            this.tbACoords.TabIndex = 8;
            // 
            // tbBCoords
            // 
            this.tbBCoords.Location = new System.Drawing.Point(261, 74);
            this.tbBCoords.Name = "tbBCoords";
            this.tbBCoords.Size = new System.Drawing.Size(179, 27);
            this.tbBCoords.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(325, 172);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(181, 172);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(124, 38);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(44, 124);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(133, 20);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "Enter border width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(260, 121);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(180, 27);
            this.tbWidth.TabIndex = 13;
            // 
            // frmLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbBCoords);
            this.Controls.Add(this.tbACoords);
            this.Controls.Add(this.lblACoords);
            this.Controls.Add(this.lblBCoords);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmLine";
            this.Text = "Line form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSave;
        private MaskedTextBox maskedTextBox1;
        private Label lblBCoords;
        private Label lblACoords;
        private TextBox tbACoords;
        private TextBox tbBCoords;
        private Button btnClose;
        private Button btnColor;
        private Label lblWidth;
        private TextBox tbWidth;
    }
}