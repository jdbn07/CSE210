using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new()
    {
        "> Who are people that you appreciate?",
        "> What are personal strengths of yours?",
        "> Who are people that you have helped this week?",
        "> When have you felt the Holy Ghost this month?",
        "> Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("> We are going to start in 10 seconds, get ready: ");
        ShowCountDown(10); 
        Console.WriteLine(); 

        Console.WriteLine("Consider the following prompt");
        Console.WriteLine(" "); 
        Console.WriteLine($"  ------- {GetRandomPrompt()} -------  ");
        Console.WriteLine(" "); 

        Console.Write("Start writing in: ");
        ShowCountDown(10);
        Console.WriteLine(); 
        Console.WriteLine(); 
        
        _count = 0;
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write("> ");
            string key = Console.ReadLine();
            _count++;
        } while (DateTime.Now < stopTime);
        Console.WriteLine($"You listed {_count} items!.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int prompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[prompt];
    }
}