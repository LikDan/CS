// int ToInt(string s) => Convert.ToInt32(s);
// void Print(string s) => Console.WriteLine(s);
// string Read() => Console.ReadLine()!;
//
// string EnterArrayViaSpaceText() => "Enter array (via space)";
// void WriteEnterArrayViaSpace() => Print(EnterArrayViaSpaceText());
//
// string GetSpaceText() => " ";
// IEnumerable<string> ReadLineAndSplitSpaces() => Read().Split(GetSpaceText());
// IEnumerable<int> ReadLineSplitSpacesAndConvertToInt() => ReadLineAndSplitSpaces().Select(ToInt);
// int[] ReadLineSplitSpacesAndConvertToIntArray() => ReadLineSplitSpacesAndConvertToInt().ToArray();
//
// int[] WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray()
// {
//     WriteEnterArrayViaSpace();
//     return ReadLineSplitSpacesAndConvertToIntArray();
// }
//
// int GetNumberToDivideToGetHalf() => 2;
// int GetHalf(int num) => num / GetNumberToDivideToGetHalf();
// int GetArrayLenght(int[] arr) => arr.Length;
// int GetHalfOfArrayLength(int[] arr) => GetHalf(GetArrayLenght(arr));
//
// int[] SliceArrayAfterHalf(int[] arr) => arr[GetHalfOfArrayLength(arr)..];
// int[] SliceArrayBeforeHalf(int[] arr) => arr[..GetHalfOfArrayLength(arr)];
//
// IEnumerable<int> ConcatArraysToEnumerable(int[] arr1, int[] arr2) => arr1.Concat(arr2);
//
// IEnumerable<int> ConcatBeforeHalfAndAfterHalfToEnumerable(int[] arr) =>
//     ConcatArraysToEnumerable(SliceArrayAfterHalf(arr), SliceArrayBeforeHalf(arr));
//
// IEnumerable<int>
//     WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayAndConcatBeforeHalfAndAfterHalfToEnumerable() =>
//     ConcatBeforeHalfAndAfterHalfToEnumerable(WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray());
//
// string JoinEnumerableThroughSpace(IEnumerable<int> arr) => string.Join(GetSpaceText(), arr);
//
// string
//     WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableAndJoinThroughSpace() =>
//     JoinEnumerableThroughSpace(
//         WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayAndConcatBeforeHalfAndAfterHalfToEnumerable());
//
// void
//     WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableJoinThroughSpaceAndPrint() =>
//     Print(
//         WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableAndJoinThroughSpace());
//
// void Task1() =>
//     WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableJoinThroughSpaceAndPrint();
//
//
// void Task2()
// {
//     var arr = WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray();
//     Array.Sort(arr);
//
//     Console.WriteLine(string.Join(" ", arr[3..].Reverse()));
// }
//
// void MinMax(ref int x, ref int y)
// {
//     if (x < y) return;
//     (x, y) = (y, x);
// }
//
// void Task3()
// {
//     Print("Enter 4 symbols (via space)");
//     var arr = ReadLineSplitSpacesAndConvertToIntArray();
//     var (n1, n2, n3, n4) = (arr[0], arr[1], arr[2], arr[3]);
//
//     MinMax(ref n1, ref n2);
//     MinMax(ref n3, ref n4);
//
//     MinMax(ref n1, ref n3);
//     MinMax(ref n2, ref n4);
//
//     Console.WriteLine($"{n1} {n4}");
// }
//
// double Arctg1(double x, double e)
// {
//     var sum = 0.0;
//     var temp = x;
//     var i = 1;
//     while (Math.Abs(temp) < e)
//     {
//         sum += temp;
//         temp = Math.Pow(-1, i) * Math.Pow(x, i * 2 + 1) / i * 2 + 1;
//         i++;
//     }
//
//     return sum;
// }
//
// void Task4()
// {
//     Console.WriteLine("Enter x and e(s)");
//     var x = Convert.ToDouble(Console.ReadLine());
//     var es = ReadLineSplitSpacesAndConvertToInt();
//     foreach (var e in es)
//     {
//         var res = Arctg1(x, e);
//         Console.WriteLine(res);
//     }
// }
//
// double Task5Bigger0(int n, double x)
// {
//     if (n == 0) return 1;
//
//     return Math.Pow(x, n) * Task5Bigger0(n - 1, x);
// }
//
// void Task5()
// {
//     Console.WriteLine("Enter x and n");
//     var x = Convert.ToDouble(Console.ReadLine());
//     var n = Convert.ToInt32(Console.ReadLine());
//
//     var result = n switch
//     {
//         < 0 => 1 / Math.Pow(x, -n),
//         0 => 1,
//         > 0 => Task5Bigger0(n, x),
//     };
//
//     Console.WriteLine(result);
// }
//
// while (true)
// {
//     Console.WriteLine("Enter task #");
//     var action = Console.ReadLine();
//     switch (action)
//     {
//         case "1":
//             Task1();
//             break;
//         case "2":
//             Task2();
//             break;
//         case "3":
//             Task3();
//             break;
//         case "4":
//             Task4();
//             break;
//         case "5":
//             Task5();
//             break;
//         default:
//             return;
//     }
// }