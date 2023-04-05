using System.Diagnostics;
using static System.Console;

Clear();
int[] array = 1_000_000.Create()
                .Fill(1, 10);
// array.ConvertToString();
int m = 100_000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();

WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");
// WriteLine(array.ConvertToString());
