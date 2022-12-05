using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;


namespace ConsoleApp1.Labs._17;

public class Lab17
{
    public static Flat[] apartments = {
        new("", 0, 0),
        new("Address", 0, 1),
        new("adadasdsa", 123, 123),
        new("aswdfdsfdswfewfewf", 12325.132, 0),
        new("asdsdadsadasdsadsa", 438, 123),
    };

    static void Binary()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/17/bin.bat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, apartments);
            Console.WriteLine("Serialized");
        }
    }

    static void Soap()
    {
        SoapFormatter formatter = new SoapFormatter();
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/17/soap.soap", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, apartments);
            Console.WriteLine("Serialized");
        }
    }

    static void Xml()
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Flat[]));
        using (FileStream fs = new FileStream("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/17/xml.xml", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, apartments);
            Console.WriteLine("Serialized");
        }
    }

    public static void Launch()
    {
        Binary();
        Soap();
        Xml();
    }
}