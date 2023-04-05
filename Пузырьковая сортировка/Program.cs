using System.Diagnostics;
using System.Linq;
using static Sorting;
Console.Clear();
bool show = !true;
int n = 10000;
int max = 1000;
int[] array = new int[n];
bool Check(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }
    return true;
}

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
// for (int i = 0; i < n; i++) array[i] = n-i;
if (show) Console.WriteLine($"array: [{String.Join(',', array)}]");
int[] arr1 = new int[n];
int[] arr2 = new int[n];
int[] arr3 = new int[n];

Array.Copy(array, arr1, n);
Array.Copy(array, arr2, n);
Array.Copy(array, arr3, n);

if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");

Stopwatch sw = new Stopwatch();
sw.Start();
for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (arr1[i] > arr1[i + 1])
        {
            int temp = arr1[i];
            arr1[i] = arr1[i + 1];
            arr1[i + 1] = temp;
        }
    }
}
sw.Stop();

System.Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"arr1: [{String.Join(',', arr1)}]");
// Console.ReadLine();
if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");
sw.Reset();
sw.Start();

for (int k = 0; k < n - 1; k++)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (arr3[i] > arr3[i + 1])
        {
            int temp = arr3[i];
            arr3[i] = arr3[i + 1];
            arr3[i + 1] = temp;
        }
    }
}
sw.Stop();
System.Console.WriteLine($"arr2 - {Check(arr3)} {sw.ElapsedMilliseconds}ms");


sw = new Stopwatch();
sw.Start();
arr2 = arr2.SortQuick(0,n-1);
sw.Stop();
System.Console.WriteLine($"arr3 - {Check(arr2)} {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"arr3: [{String.Join(',', arr2)}]");

// if (show) Console.WriteLine($"arr2: [{String.Join(',', arr2)}]");
// string str = "";
// int y = 1;
// while (y <= n)
// {
//     str = str.Insert(str.Length, " sheep...");
//     str = str.Insert(str.Length - 9, $"{y}");
//     y++;
// }
// Console.WriteLine(str);

// //  + new string('*', repCount) + s.Substring(index + repCount); // index - индекс, с которого менять; repCount - количество звездочек
// string gtr = "+_____+++@#@#$$asdfghj#$%^&*()_";
// int h = 0;
// int end = gtr.Length-1;
// for (int i = 0; !Char.IsLetter(gtr, h); i++)
// {
// h++; 
// }
// for (int i = gtr.Length; !Char.IsLetter(gtr, end); i--)
// {
// end--;
// }
// System.Console.WriteLine(gtr[h]);
// System.Console.WriteLine(gtr[end]);
// System.Console.WriteLine(Char.IsLetter('a'));
