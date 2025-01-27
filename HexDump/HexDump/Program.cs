if (args.Length != 1)
{
    Console.WriteLine("usage: HexDump filename");
    return;
}

string fileName = args[0];
if (!File.Exists(fileName))
{
    Console.WriteLine("File {0} does not exist.", fileName);
    return;
}
using (Stream input = File.OpenRead(fileName))
{
    int position = 0;
    byte[] buffer = new byte[16];
    while (true)
    {
        int bytesRead = input.Read(buffer, 0, buffer.Length);
        if (bytesRead == 0) return;

        Console.Write("{0:x4} ", position);
        position += bytesRead;

        for (int i = 0; i < 49; i++)
        {
            if (i < bytesRead)
                Console.Write("{0:x2} ", (byte)buffer[i]);
            else
                Console.Write("  ");
            if (i == 7) Console.Write("-- ");
        }

        for (int i = 0; i < bytesRead; i++)
        {
            //if (buffer[i] < 32)
            //    buffer[i] = (byte)'?';
            Console.Write((char)buffer[i]);
        }
            
        Console.WriteLine();
    }
}
