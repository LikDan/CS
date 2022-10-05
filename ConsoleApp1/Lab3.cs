// var xn = 0.1;
// var xk = 1;
//
// var h = (xk - xn) / 10;
//
// Console.WriteLine($"Xn: {xn}, Xk: {xk}, h: {h}");
// for (var x = xn; x < xk; x += h)
// {
//     var p1 = x * Math.Cos(Math.PI / 4);
//     var p2 = Math.Cos(x * Math.Sin(Math.PI / 4));
//
//     var y = Math.Pow(Math.E, p1) * p2;
//     Console.WriteLine($"Y for x {x} = {y}");
// }
//
// Console.WriteLine("Enter n");
// var n = Convert.ToInt32(Console.ReadLine());
//
// var s = 0.0;
// for (var i = 1; i < n; i++)
// {
//     s += 1.0 / i;
// }
//
// Console.WriteLine($"S = {s}");
//
// Console.WriteLine("Enter num");
// var num = Convert.ToInt32(Console.ReadLine());
//
// var result = 0;
//
// //source: https://stackoverflow.com/questions/2040702/how-to-reverse-a-number-as-an-integer-and-not-as-a-string
// while (num > 0)
// {
//     result = result * 10 + num % 10;
//     num /= 10;
// }
//
// Console.WriteLine($"Result = {result}");