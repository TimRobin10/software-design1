namespace RecursiveFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int recursiveFibonacciSequence(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return (recursiveFibonacciSequence(n - 1) + recursiveFibonacciSequence(n - 2));
        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            string sequence = null;
            int n = int.Parse(textBoxInput.Text);

            for (int i = 0; i < n; i++){
                sequence = sequence + recursiveFibonacciSequence((int)i).ToString();
                if (i != n-1)
                {
                    sequence = sequence + ", ";
                }
                labelResult.Text = sequence;
            }

        }
    }
}
