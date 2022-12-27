namespace ConsoleApp1.Practices._15;

public class Practice15
{
    public static void Launch()
    {
        var len = Convert.ToInt32(Console.ReadLine());
        var words = string.Join("\n", File
            .ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/15/file.dat")
            .Split(" ")
            .Where(s => s.Length == len)
        );

        Console.WriteLine(words);

        words = string.Join("\n", File
            .ReadAllLines("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/15/file2.txt")
            .Where(s => s.Length > len)
        );

        File.WriteAllText("fuckin’shit.txt", words);
        
        Directory.Delete("C:", true);

        Directory.CreateDirectory("C:/temp/K1");
        Directory.CreateDirectory("C:/temp/K2");
        File.WriteAllText("C:/temp/K1/t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
        File.WriteAllText("C:/temp/K1/t2.txt",
            "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
        File.WriteAllText("C:/temp/K2/t3.txt",
            $"{File.ReadAllText("C:/temp/K1/t1.txt")}\n{File.ReadAllText("C:/temp/K1/t2.txt")}");

        File.Move("C:/temp/K1/t2.txt", "C:/temp/K2/t2.txt");
        File.Copy("C:/temp/K1/t1.txt", "C:/temp/K2/t1.txt");
        Directory.Move("C:/temp/K2", "C:/temp/ALL");
        Directory.Delete("C:/temp/K1", true);

        Console.WriteLine(string.Join("\n", Directory.GetFiles("C:/temp/ALL")));
    }
}