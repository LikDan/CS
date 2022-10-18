// using System.Text.RegularExpressions;
//
// void Task1()
// {
//     Console.WriteLine("Enter phone number");
//     var number = Console.ReadLine() ?? "";
//     var regex = new Regex(@"^8-\(24|25|29|33|44|17\)\d{7}$");
//
//     Console.WriteLine(regex.Match(number).Success ? "Success" : "Wrong");
// }
//
// void Task2()
// {
//     Console.WriteLine("Enter text");
//     var text = Console.ReadLine() ?? "";
//     
//     var regex = new Regex(@"[a-zA-Z0-9]+");
//     var res = string.Join("\n", regex.Matches(text));
//     Console.WriteLine(res);
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
//         default:
//             return;
//     }
// }