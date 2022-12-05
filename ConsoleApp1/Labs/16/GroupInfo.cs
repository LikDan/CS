namespace ConsoleApp1.Labs._16;

public class GroupInfo
{
    public string GroupName { get; set; }
    public int StudentsAmount { get; set; }
    public string TutorName { get; set; }

    public GroupInfo(string groupName, int studentsAmount, string tutorName)
    {
        GroupName = groupName;
        StudentsAmount = studentsAmount;
        TutorName = tutorName;
    }

    public override string ToString() => $"{GroupName} ({StudentsAmount} people) -> {TutorName}";
}