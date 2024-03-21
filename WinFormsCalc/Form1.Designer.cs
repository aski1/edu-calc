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
            btnAdd = new Button();
            btNum2 = new Button();
            btnNum1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            tbOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOut.Location = new Point(49, 12);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(328, 23);
            tbOut.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 52);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnResult);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 60);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btNum2);
            panel3.Controls.Add(btnNum1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 340);
            panel3.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(343, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btNum2
            // 
            btNum2.Location = new Point(93, 17);
            btNum2.Name = "btNum2";
            btNum2.Size = new Size(34, 38);
            btNum2.TabIndex = 0;
            btNum2.Text = "2";
            btNum2.UseVisualStyleBackColor = true;
            btNum2.Click += btNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(49, 17);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(34, 38);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 452);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
    }
}