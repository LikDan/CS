// using System.Text.RegularExpressions;
//
// void Task1()
// {
//     Console.WriteLine("Enter str and n");
//     var s = Console.ReadLine()!;
//     var n = Convert.ToInt32(Console.ReadLine());
//
//     if (s.Length > n)
//     {
//         Console.WriteLine(s[..n]);
//         return;
//     }
//
//     if (s.Length < n)
//     {
//         Console.WriteLine(new string('.', n - s.Length) + s);
//         return;
//     }
//     
//     Console.WriteLine(s);
// }
//
//
// void Task2()
// {
//     Console.WriteLine("Enter str");
//     var s = Console.ReadLine()!.Trim();
//     var regex = new Regex(@"\ .*\ ");
//     var match = regex.Match(s).Value[1..];
//     Console.WriteLine(match);
// }
//
// void Task3()
// {
//     Console.WriteLine("Enter str and k");
//     var s = Console.ReadLine()!.Trim();
//     var k = Convert.ToInt32(Console.ReadLine());
//     var res = string.Concat(s.Select(c => char.IsLetter(c) ? (char)(c + k) : c));
//     Console.WriteLine(res);
// }
//
// void Task4()
// {
//     Console.WriteLine("Enter str and k");
//     var s = Console.ReadLine()!.Trim();
//     var regex = new Regex(@"[^a-zA-Z ]+");
//     var res = regex.Matches(s).MaxBy(v => v.Value.Length)!.Value;
//     Console.WriteLine(res);
// }
//
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
//         default:
//             return;
//     }
// }