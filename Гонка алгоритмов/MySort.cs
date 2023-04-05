public static class MySort
{
    /// <summary>
    /// Сортировка методом пузырька
    /// </summary>
    /// <param name="arr">Исходный массив</param>
    /// <param name="length">Длина массива</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] BubbleSort(this int[] arr)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            for (int i = 0; i < arr.Length - 1 - j; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }
        return arr;
    }
    /// <summary>
    /// Сортировка методом выбора
    /// </summary>
    /// <param name="arr">Исходный массив</param>
    /// <param name="length">Длина массива</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SelectionSort(this int[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[j] < arr[pos]) pos = j;
            }
            int temp = arr[i];
            arr[i] = arr[pos];
            arr[pos] = temp;
        }
        return arr;
    }
    /// <summary>
    /// Сортировка рекурсивным методом
    /// </summary>
    /// <param name="arr">Исходный массив</param>
    /// <param name="left">Левая граница массива</param>
    /// <param name="right">Правая граница массива</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortQuick(this int[] arr, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = arr[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;

            if (i <= j)
            {
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
                i++;
                j--;
            }
        }
        if (i < right) { arr.SortQuick(i, right); }
        if (left < j) { arr.SortQuick(left, j); }
        return arr;
    }
    /// <summary>
    /// Проверка массива на сортировку по возрастанию
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Отсортирован по возрастанию или нет</returns>
    public static bool AscendingCheck(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] > array[i + 1]) return false;
        }
        return true;
    }
    /// <summary>
    /// Сортировка подсчетом
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] CountingSort(this int[] array)
    {
        //поиск минимального и максимального значений
        int min = array[0];
        int max = array[0];
        foreach (int element in array)
        {
            if (element > max)
            {
                max = element;
            }
            else if (element < min)
            {
                min = element;
            }
        }
        //поправка
        int correctionFactor = min != 0 ? -min : 0;
        max += correctionFactor;

        int[] count = new int[max + 1];
        for (int i = 0; i < array.Length; i++)
        {
            count[array[i] + correctionFactor]++;
        }

        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            for (int j = 0; j < count[i]; j++)
            {
                array[index] = i - correctionFactor;
                index++;
            }
        }

        return array;
    }
    public static int[] GetArray(this int[] array)
    {
        int[] res = new int[array.Length];
        Array.Copy(array, res, array.Length);
        return res;
    }
}