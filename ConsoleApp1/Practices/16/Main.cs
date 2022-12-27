using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1.Practices._16;

public class Practice16
{
    public static Worker[] workersArray =
        JsonConvert.DeserializeObject<Worker[]>(
            File.ReadAllText(@"/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/12/data.json"))!;

    static void Log(object o, WorkerEventArgs a)
    {
        Console.WriteLine(a.Message);
    }
    
    static void Binary()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/16/bin.bin",
                   FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, workersArray);
            Console.WriteLine("Serialized");
        }
    }

    static void Soap()
    {
        SoapFormatter formatter = new SoapFormatter();
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/16/soap.soap",
                   FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, workersArray);
            Console.WriteLine("Serialized");
        }
    }

    static void Xml()
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Worker[]));
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/16/xml.xml",
                   FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, workersArray);
            Console.WriteLine("Serialized");
        }
    }

    public static void Launch()
    {
        foreach (var worker in workersArray)
        {
            worker.Event += Log;
        }
        Binary();
        Soap();
        Xml();
    }
}