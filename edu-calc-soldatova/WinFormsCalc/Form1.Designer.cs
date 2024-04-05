namespace WinFormsApp1
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
            this.btnResult = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(35, 6);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 38);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbOut
            // 
            this.tbOut.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOut.Location = new System.Drawing.Point(40, 14);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(240, 35);
            this.tbOut.TabIndex = 1;
            this.tbOut.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.tbOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 14, 40, 14);
            this.panel1.Size = new System.Drawing.Size(320, 63);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 54);
            this.panel2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(211, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 38);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 251);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.btnDiv);
            this.panel4.Controls.Add(this.btnMult);
            this.panel4.Controls.Add(this.btnNum0);
            this.panel4.Controls.Add(this.btnNum9);
            this.panel4.Controls.Add(this.btnNum8);
            this.panel4.Controls.Add(this.btnNum7);
            this.panel4.Controls.Add(this.btnNum6);
            this.panel4.Controls.Add(this.btnNum5);
            this.panel4.Controls.Add(this.btnNum4);
            this.panel4.Controls.Add(this.btnSub);
            this.panel4.Controls.Add(this.btnNum3);
            this.panel4.Controls.Add(this.btnNum1);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnNum2);
            this.panel4.Location = new System.Drawing.Point(35, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 239);
            this.panel4.TabIndex = 1;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(194, 18);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(38, 37);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnMult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(194, 75);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(38, 38);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum0.Location = new System.Drawing.Point(18, 184);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(154, 38);
            this.btnNum0.TabIndex = 8;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum9.Location = new System.Drawing.Point(134, 17);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(38, 38);
            this.btnNum9.TabIndex = 7;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum8.Location = new System.Drawing.Point(76, 17);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(38, 38);
            this.btnNum8.TabIndex = 6;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum7.Location = new System.Drawing.Point(18, 17);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(38, 38);
            this.btnNum7.TabIndex = 5;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum6.Location = new System.Drawing.Point(134, 75);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(38, 38);
            this.btnNum6.TabIndex = 4;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum5.Location = new System.Drawing.Point(76, 75);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(38, 38);
            this.btnNum5.TabIndex = 3;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum4.Location = new System.Drawing.Point(18, 75);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(38, 38);
            this.btnNum4.TabIndex = 0;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(194, 130);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(38, 38);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum3.Location = new System.Drawing.Point(134, 130);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(38, 38);
            this.btnNum3.TabIndex = 1;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnNum1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.btnNum1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.btnNum1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum1.Location = new System.Drawing.Point(18, 130);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(38, 38);
            this.btnNum1.TabIndex = 0;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(194, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNum2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum2.Location = new System.Drawing.Point(76, 130);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(38, 38);
            this.btnNum2.TabIndex = 0;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 368);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnResult;
        private TextBox tbOut;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnAdd;
        private Panel panel4;
        private Button btnNum3;
        private Button btnSub;
        private Button btnReset;
        private Button btnNum4;
        private Button btnNum0;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnDiv;
        private Button btnMult;
    }
}