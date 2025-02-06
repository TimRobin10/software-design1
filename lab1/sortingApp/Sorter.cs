using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingApp
{
    internal class Sorter
    {
        public int[] Sort(int[] array, bool ascending = true)
        {
            int[] numbers = (int[])array.Clone(); // Work with a copy of the array
            int temp;
            bool swap;

            do
            {
                swap = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if ((ascending && numbers[i] > numbers[i + 1]) || (!ascending && numbers[i] < numbers[i + 1]))
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
    }
}
