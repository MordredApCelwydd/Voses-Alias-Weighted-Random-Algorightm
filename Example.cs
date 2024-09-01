public class Example
{
    static void Main(string[] args)
    {
        List<double> inputData = new List<double>() {0.1, 0.2, 0.1, 0.4, 0.125, 0.075};
        
        Console.Write("Chances: ");
        foreach (double num in inputData)
        {
            Console.Write(num + " ");
        }
        
        Algo algo = new Algo(new List<double>(inputData));
        
        Console.WriteLine("");
        for (int i = 0; i < 5; i++)
        {
            int val = algo.PickValue();
            Console.WriteLine("Number picked: " + val + "\n This number is the index of value " + inputData[val] + " ");
        }
    }
}

