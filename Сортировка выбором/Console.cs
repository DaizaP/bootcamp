using static Sorting;
using System.Diagnostics;
using static System.Console;
using System;
using System.Collections;

int[] array = new int[] {1,2};
WriteLine("Пример_1");
WriteLine(string.Join(' ', array));
array.SortSelection();
WriteLine(string.Join(' ', array));

Array.Sort(array);