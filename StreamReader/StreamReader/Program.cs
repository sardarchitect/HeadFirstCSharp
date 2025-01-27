var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
Console.WriteLine($"Reading and writing files in this folder: {folder}");

StreamReader reader = new(Path.Combine(folder, "secret_plan.txt"));
StreamWriter writer = new(Path.Combine(folder, "emailToCaptainA.txt"));

writer.WriteLine("To: captainamazing@objectville.net");
writer.WriteLine("From: commissioner@objectville.net");
writer.WriteLine();
writer.WriteLine("We have discovered Swindler's terrible plan.");

while (!reader.EndOfStream)
{
    var lineFromThePlan = reader.ReadLine();
    writer.WriteLine($"The plan -> {lineFromThePlan}");
}
writer.WriteLine();
writer.WriteLine("Can you help us?");

writer.Close();
reader.Close();