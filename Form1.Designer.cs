using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bPlusMinus = new Button();
            b0 = new Button();
            bPoint = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bMul = new Button();
            bSub = new Button();
            bAdd = new Button();
            bEqual = new Button();
            bBackspace = new Button();
            bDiv = new Button();
            bClearActive = new Button();
            bRoot = new Button();
            bPower = new Button();
            bReverse = new Button();
            textActive = new TextBox();
            textPrev = new TextBox();
            SuspendLayout();
            // 
            // bPlusMinus
            // 
            bPlusMinus.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bPlusMinus.Location = new Point(290, 387);
            bPlusMinus.Margin = new Padding(3, 4, 3, 4);
            bPlusMinus.Name = "bPlusMinus";
            bPlusMinus.Size = new Size(65, 63);
            bPlusMinus.TabIndex = 0;
            bPlusMinus.Text = "+ / -";
            bPlusMinus.UseVisualStyleBackColor = true;
            bPlusMinus.Click += b_special_click;
            // 
            // b0
            // 
            b0.BackColor = Color.PaleTurquoise;
            b0.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b0.Location = new Point(363, 387);
            b0.Margin = new Padding(3, 4, 3, 4);
            b0.Name = "b0";
            b0.Size = new Size(67, 63);
            b0.TabIndex = 1;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b_number_Click;
            // 
            // bPoint
            // 
            bPoint.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bPoint.Location = new Point(436, 387);
            bPoint.Margin = new Padding(3, 4, 3, 4);
            bPoint.Name = "bPoint";
            bPoint.Size = new Size(65, 63);
            bPoint.TabIndex = 2;
            bPoint.Text = ",";
            bPoint.UseVisualStyleBackColor = true;
            bPoint.Click += b_special_click;
            // 
            // b1
            // 
            b1.BackColor = Color.PaleTurquoise;
            b1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b1.ForeColor = SystemColors.ActiveCaptionText;
            b1.Location = new Point(290, 316);
            b1.Margin = new Padding(3, 4, 3, 4);
            b1.Name = "b1";
            b1.Size = new Size(67, 63);
            b1.TabIndex = 3;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b_number_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.PaleTurquoise;
            b2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b2.ForeColor = SystemColors.ActiveCaptionText;
            b2.Location = new Point(363, 316);
            b2.Margin = new Padding(3, 4, 3, 4);
            b2.Name = "b2";
            b2.Size = new Size(67, 63);
            b2.TabIndex = 4;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b_number_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.PaleTurquoise;
            b3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b3.ForeColor = SystemColors.ActiveCaptionText;
            b3.Location = new Point(436, 316);
            b3.Margin = new Padding(3, 4, 3, 4);
            b3.Name = "b3";
            b3.Size = new Size(65, 63);
            b3.TabIndex = 5;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b_number_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.PaleTurquoise;
            b4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b4.ForeColor = SystemColors.ActiveCaptionText;
            b4.Location = new Point(290, 245);
            b4.Margin = new Padding(3, 4, 3, 4);
            b4.Name = "b4";
            b4.Size = new Size(65, 63);
            b4.TabIndex = 6;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b_number_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.PaleTurquoise;
            b5.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b5.ForeColor = SystemColors.ActiveCaptionText;
            b5.Location = new Point(363, 245);
            b5.Margin = new Padding(3, 4, 3, 4);
            b5.Name = "b5";
            b5.Size = new Size(67, 63);
            b5.TabIndex = 7;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b_number_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.PaleTurquoise;
            b6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b6.ForeColor = SystemColors.ActiveCaptionText;
            b6.Location = new Point(436, 245);
            b6.Margin = new Padding(3, 4, 3, 4);
            b6.Name = "b6";
            b6.Size = new Size(65, 63);
            b6.TabIndex = 8;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b_number_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.PaleTurquoise;
            b7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b7.ForeColor = SystemColors.ActiveCaptionText;
            b7.Location = new Point(290, 173);
            b7.Margin = new Padding(3, 4, 3, 4);
            b7.Name = "b7";
            b7.Size = new Size(65, 64);
            b7.TabIndex = 9;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b_number_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.PaleTurquoise;
            b8.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b8.ForeColor = SystemColors.ActiveCaptionText;
            b8.Location = new Point(363, 173);
            b8.Margin = new Padding(3, 4, 3, 4);
            b8.Name = "b8";
            b8.Size = new Size(67, 64);
            b8.TabIndex = 10;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b_number_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.PaleTurquoise;
            b9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            b9.ForeColor = SystemColors.ActiveCaptionText;
            b9.Location = new Point(436, 174);
            b9.Margin = new Padding(3, 4, 3, 4);
            b9.Name = "b9";
            b9.Size = new Size(65, 63);
            b9.TabIndex = 11;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b_number_Click;
            // 
            // bMul
            // 
            bMul.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bMul.Location = new Point(507, 245);
            bMul.Margin = new Padding(3, 4, 3, 4);
            bMul.Name = "bMul";
            bMul.Size = new Size(65, 63);
            bMul.TabIndex = 15;
            bMul.Text = "*";
            bMul.UseVisualStyleBackColor = true;
            bMul.Click += b_operation_click;
            // 
            // bSub
            // 
            bSub.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bSub.Location = new Point(507, 316);
            bSub.Margin = new Padding(3, 4, 3, 4);
            bSub.Name = "bSub";
            bSub.Size = new Size(65, 63);
            bSub.TabIndex = 14;
            bSub.Text = "-";
            bSub.UseVisualStyleBackColor = true;
            bSub.Click += b_operation_click;
            // 
            // bAdd
            // 
            bAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bAdd.Location = new Point(507, 387);
            bAdd.Margin = new Padding(3, 4, 3, 4);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(65, 63);
            bAdd.TabIndex = 13;
            bAdd.Text = "+";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += b_operation_click;
            // 
            // bEqual
            // 
            bEqual.BackColor = Color.LightCyan;
            bEqual.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bEqual.Location = new Point(290, 458);
            bEqual.Margin = new Padding(3, 4, 3, 4);
            bEqual.Name = "bEqual";
            bEqual.Size = new Size(282, 63);
            bEqual.TabIndex = 12;
            bEqual.Text = "=";
            bEqual.UseVisualStyleBackColor = false;
            bEqual.Click += b_operation_click;
            // 
            // bBackspace
            // 
            bBackspace.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bBackspace.Location = new Point(578, 103);
            bBackspace.Margin = new Padding(3, 4, 3, 4);
            bBackspace.Name = "bBackspace";
            bBackspace.Size = new Size(65, 63);
            bBackspace.TabIndex = 23;
            bBackspace.Text = "->";
            bBackspace.UseVisualStyleBackColor = true;
            bBackspace.Click += b_erase_click;
            // 
            // bDiv
            // 
            bDiv.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bDiv.Location = new Point(507, 174);
            bDiv.Margin = new Padding(3, 4, 3, 4);
            bDiv.Name = "bDiv";
            bDiv.Size = new Size(65, 63);
            bDiv.TabIndex = 22;
            bDiv.Text = "/";
            bDiv.UseVisualStyleBackColor = true;
            bDiv.Click += b_operation_click;
            // 
            // bClearActive
            // 
            bClearActive.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bClearActive.Location = new Point(507, 101);
            bClearActive.Margin = new Padding(3, 4, 3, 4);
            bClearActive.Name = "bClearActive";
            bClearActive.Size = new Size(65, 64);
            bClearActive.TabIndex = 20;
            bClearActive.Text = "C";
            bClearActive.UseVisualStyleBackColor = true;
            bClearActive.Click += b_erase_click;
            // 
            // bRoot
            // 
            bRoot.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bRoot.Location = new Point(436, 102);
            bRoot.Margin = new Padding(3, 4, 3, 4);
            bRoot.Name = "bRoot";
            bRoot.Size = new Size(65, 63);
            bRoot.TabIndex = 18;
            bRoot.Text = "sqrt";
            bRoot.UseVisualStyleBackColor = true;
            bRoot.Click += b_operation_click;
            // 
            // bPower
            // 
            bPower.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bPower.Location = new Point(363, 101);
            bPower.Margin = new Padding(3, 4, 3, 4);
            bPower.Name = "bPower";
            bPower.Size = new Size(67, 64);
            bPower.TabIndex = 17;
            bPower.Text = "x^2";
            bPower.UseVisualStyleBackColor = true;
            bPower.Click += b_operation_click;
            // 
            // bReverse
            // 
            bReverse.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            bReverse.Location = new Point(290, 102);
            bReverse.Margin = new Padding(3, 4, 3, 4);
            bReverse.Name = "bReverse";
            bReverse.Size = new Size(65, 64);
            bReverse.TabIndex = 16;
            bReverse.Text = "1/x";
            bReverse.UseVisualStyleBackColor = true;
            bReverse.Click += b_operation_click;
            // 
            // textActive
            // 
            textActive.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textActive.Location = new Point(290, 51);
            textActive.Margin = new Padding(3, 4, 3, 4);
            textActive.Name = "textActive";
            textActive.Size = new Size(353, 34);
            textActive.TabIndex = 24;
            textActive.TextAlign = HorizontalAlignment.Right;
            // 
            // textPrev
            // 
            textPrev.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, FontStyle.Bold | FontStyle.Italic);
            textPrev.ForeColor = SystemColors.GrayText;
            textPrev.Location = new Point(290, 13);
            textPrev.Margin = new Padding(3, 4, 3, 4);
            textPrev.Name = "textPrev";
            textPrev.Size = new Size(353, 30);
            textPrev.TabIndex = 25;
            textPrev.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 534);
            Controls.Add(textPrev);
            Controls.Add(textActive);
            Controls.Add(bBackspace);
            Controls.Add(bDiv);
            Controls.Add(bClearActive);
            Controls.Add(bRoot);
            Controls.Add(bPower);
            Controls.Add(bReverse);
            Controls.Add(bMul);
            Controls.Add(bSub);
            Controls.Add(bAdd);
            Controls.Add(bEqual);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(bPoint);
            Controls.Add(b0);
            Controls.Add(bPlusMinus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bPlusMinus;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button bBackspace;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bClearActive;
        private System.Windows.Forms.Button bRoot;
        private System.Windows.Forms.Button bPower;
        private System.Windows.Forms.Button bReverse;
        private System.Windows.Forms.TextBox textActive;
        private System.Windows.Forms.TextBox textPrev;
    }
}

