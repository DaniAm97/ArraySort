using System;
class MergeSort

/* Merge Sort is a sorting algorithm that uses the divide and conquer method.
 * It divides the array into two parts and then calls itself for each of these two parts. 
 * This process is continued until the array is sorted
 * 
 * time complexity : dividing the input into two parts which gives us complexity of log(N) where N is the number of elements.
 * 
 * merging back the array into a single array, so if we observe it in all the number of elements to be merged N,
 * and to merge back we use a loop which runs on the N elements giving a time complexity of O(N).
 * In conclusion we get a time complexity of o(N*log(N)) in the best and worst cases. 
 * 
 * 
 * */
{

    // Merges two subarrays of []arr.
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two
        // subarrays to be merged
        int arr_left = m - l + 1;
        int arr_right = r - m;

        // Create temp arrays
        int[] L = new int[arr_left];
        int[] R = new int[arr_right];
        int i, j;

        // Copy data to temp arrays
        for (i = 0; i < arr_left; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < arr_right; ++j)
            R[j] = arr[m + 1 + j];

        // Merge the temp arrays

        // indexes of first
        // and second subarrays
        i = 0;
        j = 0;

        //index of merged
        // subarray array
        int k = l;
        while (i < arr_left && j < arr_right)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements
        // of L[] if any
        while (i < arr_left)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        // Copy remaining elements
        // of R[] if any
        while (j < arr_right)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    
    // sorts arr[l..r] using
    // merge()
    void sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            // Find the middle
            // point
            int m = l + (r - l) / 2;

            // Sort first and
            // second halves
            sort(arr, l, m);
            sort(arr, m + 1, r);

            // Merge the sorted halves
            merge(arr, l, m, r);
        }
    }

    
    // print array of size n */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    
    public static void Main(String[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7, -3, 42, 0 };
        Console.WriteLine("Given Array");
        printArray(arr);
        MergeSort ob = new MergeSort();
        ob.sort(arr, 0, arr.Length - 1);
        Console.WriteLine("\nSorted array");
        printArray(arr);
    }
}

