namespace ConsoleApp1.Practices._1;

public class Practice1
{
    public static void Launch()
    {
        Console.WriteLine("Task1");

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Yellow;

        Console.WriteLine(@"Но если самым неприятным и пугающим было изображение отпечатка на
        земле, то наиболее любопытным оказался снимок большого черного камня,
        найденного в лесах возле Круглого холма. Эйкели фотографировал камень, по
        всей вероятности, на столе в своем кабинете, поскольку я смог разглядеть ряд
        книжных полок, а на заднем плане бюст Мильтона. Камень был заснят в
        вертикальном положении и представлял собой изрезанную поверхность,
        размером один на два фута, но у меня не хватает слов, чтобы сказать что-либо
        определенное об этих узорах или хотя бы об общей конфигурации всего камня.
        Какие геометрические принципы легли в основу его огранки - ибо эго
        несомненно была искусственная огранка, - я могу только догадываться; но скажу
        без колебаний, что никогда я не видел предмета столь странного и чуждого
        нашему миру.
        Из иероглифов, начертанных на поверхности, очень немногие был различимы, но
        один-два вызвали у меня просто шок. Конечно, это могла быть и фальсификация,
        ибо есть и кроме меня люди, читавшие чудовищный ""Некрономикон"" безумного
        араба Абдула Альхазреда; но тем не менее я испытал нервную дрожь, узнав
        определенные идеограммы, которые, как я знал по своим исследованиям,
        связаны с наиболее святотатственными и леденящими кровь историями о
        существах, которые вели безумное полусуществование задолго до того,
        как были сотворены Земля и другие внутренние миры солнечной системы.");

        Console.ResetColor();

        Console.WriteLine("Task2");
        var side = 10;
        var sin = Convert.ToDouble(Console.ReadLine());

        var square = side * side * sin;
        Console.WriteLine($"Square is:{square}");

        Console.WriteLine("Task3");
        var dm = 100_000_000_000_000_000;
        var he = (dm / 10_000_00);

        Console.WriteLine($"Hectare: {he}");

        Console.WriteLine("Task 4");
        var tDays = 12.0;
        var resDays = tDays / (2 + 3) * 2;

        Console.WriteLine($"One worker will finish work in {resDays}");

        Console.WriteLine("Task 5");

        var num = 12;
        var isCond = num % 100 == num && num % 2 == 0;
        Console.WriteLine($"Is num 2-digit number and even: {isCond}");

        Console.WriteLine("Task 6");

        var s = Convert.ToDouble(Console.ReadLine());
        var x = Convert.ToDouble(Console.ReadLine());
        var t = Convert.ToDouble(Console.ReadLine());

        var y = (1 + Math.Sqrt(s * x)) / Math.Pow(1 + Math.Pow(x, 3), 1 / t);

        Console.WriteLine($"y eq {y}");

        Console.WriteLine("Task 7");

        var a = true;
        var b = true;

        var answer = a && b;
        Console.WriteLine($"Answer: {answer}");

        Console.WriteLine("Task 8");
        var a1 = 0.25;

        var z1 = (1 - 2 * Math.Pow(Math.Sin(a1), 2)) / (1 + Math.Sin(2 * a1));
        var z2 = (1 - Math.Tan(a1)) / (1 + Math.Tan(a1));

        Console.WriteLine($"Res 1: {z1}, 2: {z2}");
    }
}