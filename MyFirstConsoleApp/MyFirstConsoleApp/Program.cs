
OperatorExamples();
TrySomeLoops();

void OperatorExamples()
{
    int width = 3;
    width++;
    
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    while (area < 20)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area > 25);

    string result = "The area";
     result = result + " is " + area;
    Console.WriteLine(result);

    bool truthValue = true; 
    Console.WriteLine(truthValue);
}

void TrySomeLoops()
{
    int count = 0;
    while (count < 10)
    {
        count = count + 1;
    }
    for (int i = 0; i < 5; i++)
    {
        count = count - 1;
    }
    Console.WriteLine("The answer is " + count);
}