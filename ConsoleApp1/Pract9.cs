// var persons = new List<Person>();
//
// Console.WriteLine("Enter person");
// while (true)
// {
//     var s = Console.ReadLine() ?? "";
//     if (s == "") break;
//
//     persons.Add(Person.Parse(s));
// }
//
// Console.WriteLine(string.Join("\n", persons.Select(p => p.GetInfo())));
//
// Console.WriteLine("---------------------------\nEnter zodiac sign");
//
// var sign = Console.ReadLine();
//
// persons = persons.Where(p => p.Sign == sign).ToList();
// if (persons.Count == 0)
// {
//     Console.WriteLine("No elements");
//     return;
// }
//
// Console.WriteLine(string.Join("\n", persons.Select(p => p.GetInfo())));
