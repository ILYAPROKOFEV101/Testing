using Worktesting;

namespace TestClass;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

[TestClass]
public sealed class SortingTests
{
    // Тест для сортировки методом выбора
    [TestMethod]
    public void TestSelectionSort()
    {
        int[] sizes = { 1000, 5000, 500000 };

        foreach (int size in sizes)
        {
            int[] array = GenerateRandomArray(size);
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Вызов метода сортировки
            ArraySorting.SelectionSort((int[])array.Clone());

            stopwatch.Stop();
            Console.WriteLine($"SelectionSort - Размер массива: {size}, Время: {stopwatch.ElapsedMilliseconds} мс");
        }
    }

    // Тест для быстрой сортировки
    [TestMethod]
    public void TestQuickSort()
    {
        int[] sizes = { 1000, 5000, 500000 };

        foreach (int size in sizes)
        {
            int[] array = GenerateRandomArray(size);
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Вызов метода сортировки
            ArraySorting.QuickSort((int[])array.Clone());

            stopwatch.Stop();
            Console.WriteLine($"QuickSort - Размер массива: {size}, Время: {stopwatch.ElapsedMilliseconds} мс");
        }
    }

    // Метод для генерации случайного массива
    private int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 1000000); // Значения от 1 до 1,000,000
        }
        return array;
    }
}