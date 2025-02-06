namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] proceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = proceduralSort((int[])numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
