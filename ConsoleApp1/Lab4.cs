// using System.Text;
//
// int[,] FillMatrix(int x, int y)
// {
//     var m = new int[x, y];
//     for (var x1 = 0; x1 < x; x1++)
//     for (var y1 = 0; y1 < y; y1++)
//     {
//         Console.Write($"x: {x1}, y: {y1} = ");
//         m[x1, y1] = Convert.ToInt32(Console.ReadLine());
//     }
//
//     return m;
// }
//
// string PrintMatrix(int[,] m)
// {
//     var builder = new StringBuilder(); 
//     for (var x1 = 0; x1 < m.GetLength(0); x1++)
//     {
//         for (var y1 = 0; y1 < m.GetLength(1); y1++)
//             builder.Append($"{m[x1, y1]}\t");
//         builder.AppendLine();
//     }
//
//     return builder.ToString();
// }
//
// int[,] MapMatrix(int[,] m1, int[,] m2, Func<int, int, int> map)
// {
//     var x = m1.GetLength(0);
//     var y = m1.GetLength(1);
//
//     var m = new int[x, y];
//
//     for (var x1 = 0; x1 < x; x1++)
//     for (var y1 = 0; y1 < y; y1++)
//         m[x1, y1] = map(m1[x1, y1], m2[x1, y1]);
//
//     return m;
// }
//
// Console.WriteLine("Enter x and y");
//
// var x = Convert.ToInt32(Console.ReadLine());
// var y = Convert.ToInt32(Console.ReadLine());
//
// var m1 = FillMatrix(x, y);
// var m2 = FillMatrix(x, y);
//
// Console.Clear();
//
// Console.WriteLine($"\n\nMatrix 1\n {new string('-', 10)}\n{PrintMatrix(m1)}");
// Console.WriteLine($"\n\nMatrix 2\n {new string('-', 10)}\n{PrintMatrix(m2)}");
//
// var multipliedMatrix = MapMatrix(m1, m2, (v1, v2) => v1 * v2);
// Console.WriteLine($"\n\nMultiplied Matrix\n {new string('-', 10)}\n{PrintMatrix(multipliedMatrix)}");
//
// var summedMatrix = MapMatrix(m1, m2, (v1, v2) => v1 + v2);
// Console.WriteLine($"\n\nSummed Matrix\n {new string('-', 10)}\n{PrintMatrix(summedMatrix)}"); 
//
//
// int[] FillArray(int size)
// {
//     var m = new int[size];
//     for (var i = 0; i < size; i++)
//     {
//         Console.Write($"i: {i} = ");
//         m[i] = Convert.ToInt32(Console.ReadLine());
//     }
//
//     return m;
// }
//
// string PrintArray(IEnumerable<int> m)
// {
//     var builder = new StringBuilder(); 
//     foreach (var i in m) builder.Append($"{i}\t");
//
//     return builder.ToString();
// }
//
//
// Console.WriteLine("Enter size");
//
// x = Convert.ToInt32(Console.ReadLine());
// var arr = FillArray(x);
//
// Console.Clear();
//
// Console.WriteLine($"Array: {PrintArray(arr)}");
//
// var div = 0;
// var sum = 0.0;
// Array.ForEach(arr, (v) =>
// {
//     if (v < 0) return;
//
//     div++;
//     sum += v;
// });
//
// var result = sum / div;
// Console.WriteLine($"Result 1: {result}");
//
// div = 0;
// sum = 0.0;
// foreach (var v in arr)
// {
//     if (v < 0) continue;
//
//     div++;
//     sum += v;
// }
//
//
// result = sum / div;
// Console.WriteLine($"Result 2: {result}");