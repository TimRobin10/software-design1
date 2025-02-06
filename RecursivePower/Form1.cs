namespace RecursivePower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double recursivePower(double baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            if (exponent < 0) return -1;
            return baseNum * recursivePower(baseNum, exponent - 1);
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double baseNumber = int.Parse(textBoxBase.Text);
            int exponentNumber = int.Parse(textBoxPower.Text);
            double result = recursivePower(baseNumber, exponentNumber);
            if (result == -1)
            {
                labelResult.Text = "App Cannot Handle Negative Exponents";
            } else
            {
                labelResult.Text = result.ToString();
            }
            
        }
    }
}
