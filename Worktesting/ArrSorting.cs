namespace Worktesting;

using System;
using System.Diagnostics;

using System;

public class ArraySorting
{
    // 1) Сортировка массива методом выбора с обменом
    public static int[] SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // Обмен элементов
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
        return array;
    }

    // 2) Быстрая сортировка массива
    public static int[] QuickSort(int[] array)
    {
        QuickSortRecursive(array, 0, array.Length - 1);
        return array;
    }

    // Вспомогательный рекурсивный метод для быстрой сортировки
    private static void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);

            QuickSortRecursive(array, low, partitionIndex - 1);
            QuickSortRecursive(array, partitionIndex + 1, high);
        }
    }

    // Метод для разделения массива
    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                // Обмен элементов
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Обмен опорного элемента
        int tempPivot = array[i + 1];
        array[i + 1] = array[high];
        array[high] = tempPivot;

        return i + 1;
    }

    
}