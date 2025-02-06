namespace sortingApp
{
    public partial class Form1 : Form
    {
        public int[] unsortedArray = { 34, 12, 7, 45, 23, 89, 1, 56, 78, 2, 41, 90, 15, 67, 3 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxResult.DataSource = unsortedArray;
        }

        public int[] bubbleSortAlgorithm(int[] array)
        {
            int[] numbers = array;
            int temp;
            bool swap;

            do
            {
                swap = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap);

            return numbers;
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] numbers = (int[])unsortedArray.Clone();
            int[] sortedArray = bubbleSortAlgorithm(numbers);
            listBoxResult.DataSource = null;
            listBoxResult.DataSource = sortedArray;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBoxResult.DataSource = null;
            listBoxResult.DataSource = unsortedArray;
        }

        private void btnOOPSort_Click(object sender, EventArgs e)
        {
            Sorter sorter = new Sorter();
            int[] numbers = (int[])unsortedArray.Clone();
            int[] sortedArray = sorter.Sort(numbers, ascending: false); // Sort in Descending order
            listBoxResult.DataSource = null;
            listBoxResult.DataSource = sortedArray;
        }
    }
}
