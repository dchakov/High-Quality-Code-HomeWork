namespace CompareMathsAndAlgorithms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SortingAlgorithms
    {
        public static void InsertionSort<T>(T[] collection) where T : IComparable
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                int index = i + 1;
                while (index > 0)
                {
                    if (collection[index - 1].CompareTo(collection[index]) > 0)
                    {
                        T temp = collection[index - 1];
                        collection[index - 1] = collection[index];
                        collection[index] = temp;
                    }

                    index--;
                }
            }
        }

        public static void SelectionSort<T>(T[] collection) where T : IComparable
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[i].CompareTo(collection[j]) > 0)
                    {
                        minIndex = j;
                    }

                    T temp = collection[i];
                    collection[i] = collection[minIndex];
                    collection[minIndex] = temp;
                }
            }
        }

        public static void QuickSort<T>(T[] collection, int lo, int hi) where T : IComparable
        {
            if (lo < hi)
            {
                int p = Partition(collection, lo, hi);
                QuickSort(collection, lo, p - 1);
                QuickSort(collection, p + 1, hi);
            }
        }

        public static int Partition<T>(T[] collection, int lo, int hi) where T : IComparable
        {
            int pivotIndex = (lo + hi) / 2;
            T pivotValue = collection[pivotIndex];
            collection[pivotIndex] = collection[hi];
            collection[hi] = pivotValue;

            int storeIndex = lo;
            T temp;
            for (int i = lo; i <= hi - 1; i++)
            {
                if (collection[i].CompareTo(pivotValue) < 0)
                {
                    temp = collection[i];
                    collection[i] = collection[storeIndex];
                    collection[storeIndex] = temp;
                    storeIndex++;
                }
            }

            temp = collection[storeIndex];
            collection[storeIndex] = collection[hi];
            collection[hi] = temp;

            return storeIndex;
        }
    }
}
