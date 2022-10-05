// void Task1()
// {
//         Console.WriteLine("Enter n");
//         var n = Console.ReadLine();
//
//         Console.WriteLine(n?.ToCharArray().Length == n?.ToCharArray().Distinct().ToArray().Length ? "Yep" : "Nope");
//
//         var i = Convert.ToInt32(n);
//         var ii = 0;
//         while (i / Math.Pow(10, ii) >= 1)
//         {
//             var n1 = Convert.ToInt32(i / Math.Pow(10, ii)) % 10;
//             ii++;
//
//             var iii = 0;
//             while (i / Math.Pow(10, iii) >= 1)
//             {
//                 var n2 = Convert.ToInt32(i / Math.Pow(10, iii)) % 10;
//                 iii++;
//
//                 if (n1 != n2 || ii == iii) continue;
//                 Console.WriteLine("Nope");
//                 return;
//             }
//         }
//
//         Console.WriteLine("Yep");
// }
//
// void Task2()
// {
//     var x0 = 0.2;
//     var xn = 2;
//     var dx = 0.2;
//     var a = 0.2;
//
//     for (var x = x0; x < xn; x += dx)
//     {
//         var ax = a * x;
//         var q = ax switch
//         {
//             < 1.0 => ax - Math.Log(ax),
//             1.0 => 1,
//             > 1.0 => ax + Math.Log(ax),
//             double.NaN => 0
//         };
//
//         Console.WriteLine($"x: {x}, q: {q}");
//     }
// }
//
// //source: https://ru.stackoverflow.com/questions/1241867/%D0%9D%D0%B0%D0%B9%D1%82%D0%B8-%D0%B4%D0%B5%D0%BB%D0%B8%D1%82%D0%B5%D0%BB%D0%B8-%D1%87%D0%B8%D1%81%D0%BB%D0%B0
// int DivisorsSum(int n)
// {
//     var sum = 0;
//
//     for (var i = 2; i * i < n; i++)
//     {
//         if (n % i != 0) continue;
//
//         sum += i;
//         if (i * i != n)
//             sum += n / i;
//     }
//
//     return sum;
// }
//
// void Task3()
// {
//     Console.WriteLine("Enter n, m");
//     var n = Convert.ToInt32(Console.ReadLine());
//     var m = Convert.ToInt32(Console.ReadLine());
//
//     for (var i = n; i < m; i++)
//     for (var j = 0; j < i; j++)
//     {
//         if (DivisorsSum(i) != DivisorsSum(j)) continue;
//
//         Console.WriteLine($"Friendly numbers {i}, {j}");
//     }
// }
//
// void Task4()
// {
//     Console.WriteLine("Enter number, k, n");
//     var number = Console.ReadLine()!.Split(".")[1];
//     var k = Convert.ToInt32(Console.ReadLine());
//     var n = Convert.ToInt32(Console.ReadLine());
//
//     var partK = number[..k];
//     var partN = number[k..(k + n)];
//
//     var sumK = partK.Sum(ck => ck - 48);
//     var sumN = partN.Sum(cn => cn - 48);
//
//     Console.WriteLine(sumK == sumN ? "Yep" : "Nope");
// }
//
// void Task5()
// {
//     Console.WriteLine("Enter n");
//     var n = Convert.ToInt32(Console.ReadLine());
//
//     var sum = 0.0;
//     for (var k = 0; k < n; k++)
//     {
//         var uSum = 0.0;
//         for (var i = 0; i < n; i++)
//             uSum += Math.Sin(0.01 * k * i);
//
//         var f = 1;
//         for (var i = 2; i < k; i++)
//             f *= i;
//
//         sum += uSum / f;
//     }
//
//     Console.WriteLine($"Sum = {sum}");
// }
//
// //source: https://www.cyberforum.ru/csharp-beginners/thread1450160.html
// int GetDigit(int x, int digitNumber)
// {
//     var digitCount = (int)Math.Log10(x) + 1;
//     if (digitNumber > digitCount)
//         return -1;
//  
//     var pow = (int)Math.Pow(10, digitCount - digitNumber);
//     return x / pow % 10;
// }
//
// void Task6()
// {
//     Console.Write("Enter k");
//     var currNumber = 1;
//     var k = Convert.ToInt32(Console.ReadLine());
//     for (var i = 0; i < k; i++)
//     {
//         var ii = 1;
//         while (GetDigit(currNumber, ii) != -1)
//         {
//             if (ii > 1) i++;
//             if (i == k - 1)
//             {
//                 Console.WriteLine($"K = {GetDigit(currNumber, ii)}");
//                 return;
//             }
//
//             ii++;
//         }
//
//         currNumber++;
//     }
// }
//
// while (true)
// {
//     Console.WriteLine("Enter task #");
//     var action = Console.ReadLine();
//
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
//         case "6":
//             Task6();
//             break;
//         default:
//             return;
//     }
// }