using System;

class Program
{
    static void TesT()
    {
        int[] array1 = { 1, 3, 5, 7, 9, 0, 0, 0, 0, 0 };  // first array with enough space to hold second array
        int[] array2 = { 2, 4, 6, 8, 10 };
        int m = 5;  // initial number of elements in array1
        int n = array2.Length;  // number of elements in array2

        Merge(array1, m, array2, n);

        foreach (int i in array1)
        {
            Console.Write(i + " ");  // prints 1 2 3 4 5 6 7 8 9 10
        }
    }

    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1, j = n - 1, k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}
