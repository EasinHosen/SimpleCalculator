namespace SimpleCalculatorLab01
{
    public partial class Form1 : Form
    {

        private double n1;
        private double n2;
        private double res;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txtFirstNumber.Text.ToString());
            n2 = Double.Parse(txtSecondNumber.Text.ToString());

            res = n1 + n2;

            txtResult.Text = res.ToString("F2");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txtFirstNumber.Text.ToString());
            n2 = Double.Parse(txtSecondNumber.Text.ToString());

            res = n1 - n2;

            txtResult.Text = res.ToString("F2");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txtFirstNumber.Text.ToString());
            n2 = Double.Parse(txtSecondNumber.Text.ToString());

            res = n1 * n2;

            txtResult.Text = res.ToString("F2");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txtFirstNumber.Text.ToString());
            n2 = Double.Parse(txtSecondNumber.Text.ToString());

            res = n1 / n2;

            txtResult.Text = res.ToString("F2");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(txtFirstNumber.Text.ToString());
            n2 = Double.Parse(txtSecondNumber.Text.ToString());

            res = n1 % n2;

            txtResult.Text = res.ToString("F2");
        }
    }
}