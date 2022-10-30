// enum BillStatus
// {
//     Ready,
//     NotReady
// }
//
// struct Bill
// {
//     public string ID;
//     public string Name;
//     public DateTime Datetime;
//     public BillStatus Status;
//
//     public Bill(string id, string name, DateTime datetime, BillStatus status)
//     {
//         ID = id;
//         Name = name;
//         Datetime = datetime;
//         Status = status;
//     }
//
//     public string GetInfo() => $"({ID}) -> Name: {Name}, Date: {Datetime:g}, Status: {Status}";
// }