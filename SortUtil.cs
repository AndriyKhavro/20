namespace AlgorithmBenchmark;

public class SortUtil
{
    public static int[] CountingSort(IReadOnlyList<int> arr)
    {
        int max = arr.Max();
        int min = arr.Min();

        int range = max - min + 1;
        int[] countArray = new int[range];
        int[] outputArray = new int[arr.Count];

        // Count the occurrences of each element
        for (int i = 0; i < arr.Count; i++)
        {
            countArray[arr[i] - min]++;
        }

        // Calculate the prefix sum
        for (int i = 1; i < range; i++)
        {
            countArray[i] += countArray[i - 1];
        }

        // Build the output array
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            outputArray[countArray[arr[i] - min] - 1] = arr[i];
            countArray[arr[i] - min]--;
        }

        return outputArray;
    }
}