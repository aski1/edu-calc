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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnResult = new Button();
            tbOut = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnReset = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            btnMult = new Button();
            btnDiv = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNum0 = new Button();
            btnSub = new Button();
            btNum3 = new Button();
            btnNum1 = new Button();
            btnAdd = new Button();
            btNum2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Gold;
            btnResult.FlatStyle = FlatStyle.Popup;
            btnResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResult.Location = new Point(49, 10);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 38);
            btnResult.TabIndex = 0;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // tbOut
            // 
            tbOut.Dock = DockStyle.Fill;
            tbOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbOut.Location = new Point(40, 14);
            tbOut.Multiline = true;
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(402, 35);
            tbOut.TabIndex = 1;
            tbOut.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(tbOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40, 14, 40, 14);
            panel1.Size = new Size(482, 63);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnResult);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 60);
            panel2.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Gold;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(140, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 38);
            btnReset.TabIndex = 1;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Beige;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 279);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(btnMult);
            panel4.Controls.Add(btnDiv);
            panel4.Controls.Add(btnNum4);
            panel4.Controls.Add(btnNum5);
            panel4.Controls.Add(btnNum6);
            panel4.Controls.Add(btnNum7);
            panel4.Controls.Add(btnNum8);
            panel4.Controls.Add(btnNum9);
            panel4.Controls.Add(btnNum0);
            panel4.Controls.Add(btnSub);
            panel4.Controls.Add(btNum3);
            panel4.Controls.Add(btnNum1);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btNum2);
            panel4.Location = new Point(73, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 267);
            panel4.TabIndex = 1;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Gold;
            btnMult.FlatStyle = FlatStyle.Popup;
            btnMult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(276, 193);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(34, 38);
            btnMult.TabIndex = 11;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Gold;
            btnDiv.FlatStyle = FlatStyle.Popup;
            btnDiv.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(276, 134);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(34, 38);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.Gold;
            btnNum4.FlatStyle = FlatStyle.Popup;
            btnNum4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum4.Location = new Point(26, 61);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(34, 38);
            btnNum4.TabIndex = 9;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.Gold;
            btnNum5.FlatStyle = FlatStyle.Popup;
            btnNum5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum5.Location = new Point(88, 61);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(34, 38);
            btnNum5.TabIndex = 8;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.Gold;
            btnNum6.FlatStyle = FlatStyle.Popup;
            btnNum6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum6.Location = new Point(149, 61);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(34, 38);
            btnNum6.TabIndex = 7;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.Gold;
            btnNum7.FlatStyle = FlatStyle.Popup;
            btnNum7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum7.Location = new Point(26, 114);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(34, 38);
            btnNum7.TabIndex = 6;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.Gold;
            btnNum8.FlatStyle = FlatStyle.Popup;
            btnNum8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum8.Location = new Point(88, 114);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(34, 38);
            btnNum8.TabIndex = 5;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.Gold;
            btnNum9.FlatStyle = FlatStyle.Popup;
            btnNum9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum9.Location = new Point(149, 114);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(34, 38);
            btnNum9.TabIndex = 4;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.Gold;
            btnNum0.FlatStyle = FlatStyle.Popup;
            btnNum0.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum0.Location = new Point(26, 158);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(34, 38);
            btnNum0.TabIndex = 3;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Gold;
            btnSub.FlatStyle = FlatStyle.Popup;
            btnSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(276, 75);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(34, 38);
            btnSub.TabIndex = 2;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btNum3
            // 
            btNum3.BackColor = Color.Gold;
            btNum3.FlatStyle = FlatStyle.Popup;
            btNum3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btNum3.Location = new Point(149, 17);
            btNum3.Name = "btNum3";
            btNum3.Size = new Size(34, 38);
            btNum3.TabIndex = 1;
            btNum3.Text = "3";
            btNum3.UseVisualStyleBackColor = false;
            btNum3.Click += btNum3_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.Gold;
            btnNum1.FlatStyle = FlatStyle.Popup;
            btnNum1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum1.Location = new Point(26, 17);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(34, 38);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(276, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btNum2
            // 
            btNum2.BackColor = Color.Gold;
            btNum2.FlatStyle = FlatStyle.Popup;
            btNum2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btNum2.Location = new Point(88, 17);
            btNum2.Name = "btNum2";
            btNum2.Size = new Size(34, 38);
            btNum2.TabIndex = 0;
            btNum2.Text = "2";
            btNum2.UseVisualStyleBackColor = false;
            btNum2.Click += btNum2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(482, 402);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Калькулятор";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnResult;
        private TextBox tbOut;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btNum2;
        private Button btnNum1;
        private Button btnAdd;
        private Panel panel4;
        private Button btNum3;
        private Button btnSub;
        private Button btnReset;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum0;
        private Button btnDiv;
        private Button btnMult;
    }
}