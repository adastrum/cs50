using System.Collections.Generic;

namespace cs50
{
    public class Sorter
    {
        public void BubbleSort(IList<int> numbers)
        {
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        Swap(numbers, i, j);
                    }
                }
            }
        }

        public void InsertionSort(IList<int> numbers)
        {
            for (var i = 1; i < numbers.Count; i++)
            {
                var temp = numbers[i];
                int j;
                for (j = i - 1; j >= 0 && numbers[j] > temp; j--)
                {
                    numbers[j + 1] = numbers[j];
                }
                numbers[j + 1] = temp;
            }
        }

        public void SelectionSort(IList<int> numbers)
        {
            for (var i = 0; i < numbers.Count - 1; i++)
            {
                var min = numbers[i];
                var k = i;
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        k = j;
                    }
                }
                Swap(numbers, i, k);
            }
        }

        public int[] MergeSort(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers;
            }

            var median = numbers.Length / 2;

            var left = new int[median];
            for (var i = 0; i < left.Length; i++)
            {
                left[i] = numbers[i];
            }

            var right = new int[numbers.Length - median];
            for (var i = 0; i < right.Length; i++)
            {
                right[i] = numbers[median + i];
            }

            return Merge(MergeSort(left), MergeSort(right));
        }

        private int[] Merge(int[] left, int[] right)
        {
            var result = new int[left.Length + right.Length];

            var i = 0;
            var j = 0;
            var k = 0;

            while (i + j < result.Length)
            {
                if (i == left.Length)
                {
                    result[k++] = right[j++];
                    continue;
                }
                if (j == right.Length)
                {
                    result[k++] = left[i++];
                    continue;
                }
                if (left[i] < right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            return result;
        }

        private void Swap(IList<int> numbers, int i, int j)
        {
            var temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
