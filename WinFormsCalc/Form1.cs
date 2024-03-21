namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int number1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int number2 = int.Parse(tbOut.Text);
            tbOut.Text = (number1 + number2).ToString();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            tbOut.Text += "1";
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            tbOut.Text += "2";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(tbOut.Text);
            tbOut.Text = "";
        }
    }
}