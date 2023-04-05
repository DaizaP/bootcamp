using System;
using System.Diagnostics;
using static MySort;

Console.Clear();
bool show = !true;
int n = 10_000;
int max = 100_000;
int[] array = new int[n];

for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);
if (show) Console.WriteLine($"array: [{String.Join(',', array)}]");

int[] arr1 = array.GetArray();
int[] arr2 = array.GetArray();
int[] arr3 = array.GetArray();
int[] arr4 = array.GetArray();
int[] arr5 = array.GetArray();
Stopwatch sw = new Stopwatch();
 
sw.Start();
arr1.CountingSort();
sw.Stop();
System.Console.WriteLine($" CountingSort: {AscendingCheck(arr1.CountingSort())}| Time: {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($" CountingSort: [{String.Join(',', arr1.CountingSort())}]");

sw.Reset();
sw.Start();
arr4.SortQuick(0, n - 1);
sw.Stop();
System.Console.WriteLine($"    SortQuick: {AscendingCheck(arr4.SortQuick(0, n - 1))}| Time: {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"    SortQuick: [{String.Join(',', arr4.SortQuick(0, n - 1))}]");

sw.Reset();
sw.Start();
arr3.SelectionSort();
sw.Stop();
System.Console.WriteLine($"SelectionSort: {AscendingCheck(arr3.SelectionSort())}| Time: {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"SelectionSort: [{String.Join(',', arr3.SelectionSort())}]");

sw.Reset();
sw.Start();
arr2.BubbleSort();
sw.Stop();
System.Console.WriteLine($"   BubbleSort: {AscendingCheck(arr2.BubbleSort())}| Time: {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"   BubbleSort: [{String.Join(',', arr2.BubbleSort())}]");

sw.Reset();
sw.Start();
Array.Sort(arr5);
sw.Stop();
System.Console.WriteLine($"   DotNetSort: {AscendingCheck(arr5)}| Time: {sw.ElapsedMilliseconds}ms");
if (show) Console.WriteLine($"   DotNetSort: [{String.Join(',', arr5)}]");