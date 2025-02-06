namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int recursiveFactorial(int number)
        {
            if (number == 0) return 1;
            return number * recursiveFactorial(number - 1);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inputTextBox.Text);
            int factorial = recursiveFactorial((int)number);
            labelResult.Text = factorial.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int recursionSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + recursionSum(numbers,n-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = textBoxArray.Text.Split(',').Select(int.Parse).ToArray();
            int result = recursionSum(numbers, numbers.Length-1);
            labelSum.Text = result.ToString();
        }
    }
}
