public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("> We are going to start in 10 seconds, get ready: ");
        ShowCountDown(10);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write(">>> Breathe In <<< : ");
            ShowCountDown(10);
            Console.WriteLine(" "); 
            Console.WriteLine();
            Console.Write(">>> Breathe Out <<< : ");
            ShowCountDown(5);
            Console.WriteLine(" ");
            Console.WriteLine();
        } while (DateTime.Now < stopTime);

        DisplayEndingMessage();
        Console.Clear();
    }
}