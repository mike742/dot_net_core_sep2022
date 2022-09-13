using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using ConsoleApp_don_net_6;

// "Pa$$w0rd" 
// string password = Console.ReadLine();
// string enc_password = "3cc31cd246149aec68079241e71e98f6";
// Console.WriteLine(DataProtection.toMD5(password) == enc_password);


// Console.WriteLine(DataProtection.GenerateSecretKey());
string secret_key = @"d\_n;7pschw^NWKujm8BIRZCS0?Ft[5b";
string password = "Pa$$w0rd";

// Console.WriteLine(DataProtection.EncryptString(secret_key, password));
string enc_password = "pdCrlqUcxFA/AHzZcT/tNw==";

// Console.WriteLine( DataProtection.DecryptString(secret_key, enc_password) );
// Console.WriteLine( DataProtection.SaltAndHash(password) );



// string file_path = "data2.xml";
// string content = File.ReadAllText(file_path);

// Console.WriteLine(content);
var obj = FromJson<Top>("data.json");

// ToJson(obj, "test_file.json");
ToXml(obj, "data2.xml");


var obj_from_file = FromXml<Top>("data2.xml");

// obj_from_file.Print();

List<Employee> employees = new List<Employee> { 
    new Employee { Id = 101, FirstName = "Mark", LastName = "Smith", Salary = 1800},
    new Employee { Id = 102, FirstName = "Lucy", LastName = "Swanson", Salary = 1950},
    new Employee { Id = 103, FirstName = "Tracy", LastName = "Johnson", Salary = 2500},
    new Employee { Id = 104, FirstName = "John", LastName = "Doe", Salary = 2450},
};

string file = "employee2.dat";
ToBinary(employees, file);
List<Employee> employees1 = FromBinary<List<Employee>>(file);

foreach (Employee employee in employees1)
{
    Console.WriteLine($"{employee.Id} {employee.FirstName}");
}


static T FromBinary<T>(string filename)
{
    using (Stream st = File.Open("employee.dat", FileMode.Open))
    {
        BinaryFormatter bf = new BinaryFormatter();
        return (T)bf.Deserialize(st);
    }
}

static void ToBinary<T>(T data, string filename)
{
    using (Stream st = File.Open(filename, FileMode.Create))
    {
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(st, data);
    }
}

static T FromXml<T>(string file_path)
{
    using (StringReader sr = new StringReader(File.ReadAllText(file_path)))
    {
        XmlSerializer xmls = new XmlSerializer(typeof(T));
        return (T)xmls.Deserialize(sr);
    }
}

static void ToXml<T>(T obj, string file_path)
{
    using (StringWriter sw = new StringWriter(new StringBuilder()))
    {
        XmlSerializer xmlS = new XmlSerializer(typeof(T));
        xmlS.Serialize(sw, obj);
        File.WriteAllText(file_path, sw.ToString());
    }
}

static void ToJson<T>(T obj, string file_path)
{
    var options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = new LowerCaseNamingPolicy(),
        WriteIndented = true
    };
    string json = JsonSerializer.Serialize(obj, options);
    File.WriteAllText(file_path, json);
}

static T FromJson<T>(string file_path)
{
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };
    string json = File.ReadAllText(file_path);
    return JsonSerializer.Deserialize<T>(json, options);
}


