using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your qualification? ");
        string userqua  = Console.ReadLine();
        int qua = int.Parse(userqua);
        string letter="";

        if (qua >= 90)
        {
            letter = "A"; 
        }
        else if (qua <= 89 && qua>=80)
        {
           letter = "B"; 
        }
        else if (qua <= 79 && qua>=70)
        {
           letter = "C";
        }
        else if (qua <= 69 && qua>=60)
        {
           letter = "D";
        }
        else
        {
           letter = "f";
        }
        Console.WriteLine ("Your Grade is: "+letter);
        if ( qua >=70)
        {
            Console. WriteLine ("Congratulations, you passed");
        }
        else
        {
            Console.WriteLine ("Good Luck Next Time, Try Again");
        }
    }
}