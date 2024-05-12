using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture(new Reference("2 Nephi", 32, 8, 9), "And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.");
        
        
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine(scrip.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press the 'enter button' to start hiding words or type 'exit' to quit: ");
            choice = Console.ReadLine();
            if (choice == "exit")
                break;
            if (scrip.IsCompletelyHidden())
                break;

            scrip.HideRandomWords(3);
            
        } 
        while (true);
    }
}