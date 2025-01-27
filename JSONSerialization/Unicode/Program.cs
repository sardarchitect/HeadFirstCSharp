int intValue = 48769414;
string stringValue = "Hello!";
byte[] byteArray = { 47, 129, 0, 116 };
float floatValue = 491.695F;
char charValue = 'E';

using(var output = File.Create("binarydata.txt"))
using(var writer = new BinaryWriter(output))
{
    writer.Write(intValue);
    writer.Write(stringValue);
    writer.Write(byteArray);
    writer.Write(floatValue);
    writer.Write(charValue);
}

byte[] bytedata = File.ReadAllBytes("binarydata.txt");
foreach(byte b in bytedata)
{
    Console.WriteLine("{0:x2} ",b);
}
Console.WriteLine(" - {0} bytes", bytedata.Length);

using (var input = File.OpenRead("binarydata.txt"))
using (var reader = new BinaryReader(input))
{
    int intRead = reader.ReadInt32();
    string stringRead = reader.ReadString();
    byte[] byteArrayRead = reader.ReadBytes(4);
    float floatRead = reader.ReadSingle();
    char charRead = reader.ReadChar();

    Console.Write("int: {0} string: {1} bytes: ", intRead, stringRead);
    foreach(byte b in byteArrayRead)
        Console.Write("{0} ", b);
    Console.Write(" float: {0} char: {1} ", floatRead, charRead);

}
