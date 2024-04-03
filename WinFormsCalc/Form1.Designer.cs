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
            tbOut = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnDiv = new Button();
            btnMult = new Button();
            btnNum0 = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum7 = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnSub = new Button();
            btNum3 = new Button();
            btnNum1 = new Button();
            btnAdd = new Button();
            btNum2 = new Button();
            btnResult = new Button();
            btnReset = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbOut
            // 
            tbOut.BackColor = SystemColors.Control;
            tbOut.Dock = DockStyle.Fill;
            tbOut.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbOut.ForeColor = Color.Black;
            tbOut.ImeMode = ImeMode.NoControl;
            tbOut.Location = new Point(40, 14);
            tbOut.Multiline = true;
            tbOut.Name = "tbOut";
            tbOut.ReadOnly = true;
            tbOut.Size = new Size(256, 35);
            tbOut.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tbOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40, 14, 40, 14);
            panel1.Size = new Size(336, 63);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 229);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(btnDiv);
            panel4.Controls.Add(btnMult);
            panel4.Controls.Add(btnNum0);
            panel4.Controls.Add(btnNum9);
            panel4.Controls.Add(btnNum8);
            panel4.Controls.Add(btnNum7);
            panel4.Controls.Add(btnNum6);
            panel4.Controls.Add(btnNum5);
            panel4.Controls.Add(btnNum4);
            panel4.Controls.Add(btnSub);
            panel4.Controls.Add(btNum3);
            panel4.Controls.Add(btnNum1);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btNum2);
            panel4.Location = new Point(-9, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 218);
            panel4.TabIndex = 1;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(64, 64, 64);
            btnDiv.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.ForeColor = Color.FromArgb(0, 192, 0);
            btnDiv.Location = new Point(251, 170);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(52, 45);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(64, 64, 64);
            btnMult.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMult.ForeColor = Color.FromArgb(0, 192, 0);
            btnMult.Location = new Point(251, 119);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(52, 45);
            btnMult.TabIndex = 10;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.FromArgb(64, 64, 64);
            btnNum0.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum0.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum0.Location = new Point(48, 173);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(52, 45);
            btnNum0.TabIndex = 9;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.FromArgb(64, 64, 64);
            btnNum9.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum9.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum9.Location = new Point(164, 119);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(52, 45);
            btnNum9.TabIndex = 8;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.FromArgb(64, 64, 64);
            btnNum8.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum8.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum8.Location = new Point(106, 119);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(52, 45);
            btnNum8.TabIndex = 7;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.FromArgb(64, 64, 64);
            btnNum7.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum7.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum7.Location = new Point(48, 119);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(52, 45);
            btnNum7.TabIndex = 6;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.FromArgb(64, 64, 64);
            btnNum6.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum6.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum6.Location = new Point(164, 68);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(52, 45);
            btnNum6.TabIndex = 5;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.FromArgb(64, 64, 64);
            btnNum5.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum5.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum5.Location = new Point(106, 68);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(52, 45);
            btnNum5.TabIndex = 4;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.FromArgb(64, 64, 64);
            btnNum4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum4.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum4.Location = new Point(48, 68);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(52, 45);
            btnNum4.TabIndex = 3;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(64, 64, 64);
            btnSub.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.ForeColor = Color.FromArgb(0, 192, 0);
            btnSub.Location = new Point(251, 68);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(52, 45);
            btnSub.TabIndex = 2;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btNum3
            // 
            btNum3.BackColor = Color.FromArgb(64, 64, 64);
            btNum3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btNum3.ForeColor = Color.FromArgb(0, 192, 0);
            btNum3.Location = new Point(164, 17);
            btNum3.Name = "btNum3";
            btNum3.Size = new Size(52, 45);
            btNum3.TabIndex = 1;
            btNum3.Text = "3";
            btNum3.UseVisualStyleBackColor = false;
            btNum3.Click += btNum3_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.FromArgb(64, 64, 64);
            btnNum1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum1.ForeColor = Color.FromArgb(0, 192, 0);
            btnNum1.Location = new Point(48, 17);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(52, 45);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(0, 192, 0);
            btnAdd.Location = new Point(251, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btNum2
            // 
            btNum2.BackColor = Color.FromArgb(64, 64, 64);
            btNum2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btNum2.ForeColor = Color.FromArgb(0, 192, 0);
            btNum2.Location = new Point(106, 17);
            btNum2.Name = "btNum2";
            btNum2.Size = new Size(52, 45);
            btNum2.TabIndex = 0;
            btNum2.Text = "2";
            btNum2.UseVisualStyleBackColor = false;
            btNum2.Click += btNum2_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(64, 64, 64);
            btnResult.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.ForeColor = Color.FromArgb(0, 192, 0);
            btnResult.Location = new Point(38, 6);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(168, 45);
            btnResult.TabIndex = 0;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(64, 64, 64);
            btnReset.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.FromArgb(0, 192, 0);
            btnReset.Location = new Point(242, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(52, 45);
            btnReset.TabIndex = 1;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnResult);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 69);
            panel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(336, 361);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximumSize = new Size(352, 400);
            MinimumSize = new Size(352, 400);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbOut;
        private Panel panel1;
        private Panel panel3;
        private Button btNum2;
        private Button btnNum1;
        private Button btnAdd;
        private Panel panel4;
        private Button btNum3;
        private Button btnSub;
        private Button btnNum4;
        private Button btnNum0;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnMult;
        private Button btnResult;
        private Button btnReset;
        private Panel panel2;
        private Button btnDiv;
    }
}