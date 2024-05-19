public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
    };
    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("> We are going to start in 10 seconds, get ready: ");
        ShowCountDown(10);
        Console.WriteLine(" "); 

        Console.WriteLine("Consider the following prompt");
        Console.WriteLine(" "); 
        Console.WriteLine($"  ------- {GetRandomPrompt()} -------  ");
        Console.WriteLine(" ");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("> Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine(" "); 
        Console.Write("You will start in: ");
        ShowCountDown(10);
        Console.WriteLine(); 

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        } while (DateTime.Now < stopTime);
        
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int prompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[prompt];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int question = randomGenerator.Next(0, _questions.Count);
        return _questions[question];
    }

}