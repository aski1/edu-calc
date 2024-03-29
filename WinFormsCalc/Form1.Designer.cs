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
            btnResult = new Button();
            tbOut = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
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
            btnResult.Location = new Point(49, 10);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 38);
            btnResult.TabIndex = 0;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // tbOut
            // 
            tbOut.Dock = DockStyle.Fill;
            tbOut.Location = new Point(40, 14);
            tbOut.Multiline = true;
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(402, 35);
            tbOut.TabIndex = 1;
            // 
            // panel1
            // 
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
            panel2.Controls.Add(btnResult);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 60);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
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
            // btnSub
            // 
            btnSub.Location = new Point(276, 75);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(34, 38);
            btnSub.TabIndex = 2;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btNum3
            // 
            btNum3.Location = new Point(116, 17);
            btNum3.Name = "btNum3";
            btNum3.Size = new Size(34, 38);
            btNum3.TabIndex = 1;
            btNum3.Text = "3";
            btNum3.UseVisualStyleBackColor = true;
            btNum3.Click += btNum3_Click;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(18, 17);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(34, 38);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(276, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btNum2
            // 
            btNum2.Location = new Point(67, 17);
            btNum2.Name = "btNum2";
            btNum2.Size = new Size(34, 38);
            btNum2.TabIndex = 0;
            btNum2.Text = "2";
            btNum2.UseVisualStyleBackColor = true;
            btNum2.Click += btNum2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 402);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
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
    }
}