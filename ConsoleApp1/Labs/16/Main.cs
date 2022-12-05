namespace ConsoleApp1.Labs._16;

public class Lab16
{
    public static IEnumerable<GroupInfo> ReadFile() =>
        File.ReadAllLines("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/16/GroupInfo.txt").Select(line =>
        {
            var segments = line.Split(" ");
            return new GroupInfo(segments[0], Convert.ToInt32(segments[1]), segments[2]);
        });

    public static void Launch()
    {
        var groups = ReadFile();
        
        Console.WriteLine("Enter group name to get info");
        var groupName = Console.ReadLine() ?? "";
        var group = groups.FirstOrDefault(g => g.GroupName == groupName);
        Console.WriteLine(group?.ToString() ?? "No such group");
    }
}