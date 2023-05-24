using Csharp_practical_6;

class Program
{
    public static void Main(string[] args)
    {
        ProcessBusinessLogic program = new();
        program.ProcessComplete += bl_ProcessCompleted;
        program.StartProcess();
    }

    public static void bl_ProcessCompleted(object sender , EventArgs e)
    {
        Console.WriteLine("Hurray! Process Completed !");
    }
}