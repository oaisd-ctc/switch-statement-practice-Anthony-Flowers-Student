using System;

public class Program{
    public static void Main()
    {
        Console.WriteLine("Type a number between 1 - 10.");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input < 1 || input > 10 ) {
            Console.WriteLine("That number is not in range, please try again");
            Main();
        }
        else if (input <= 1 && input <= 10) 
        {
            switch (input) 
            {
                case 1:
                Console.WriteLine("Your number is 1, the loneliest number:(");
                break;
                case 2:
                Console.WriteLine("Your number is 2, known to show balance or harmony");
                break;
                case 3:
                Console.WriteLine("Your number is 3, it symbolizes optimism or enthusiasm");
                break;                                
                case 4:
                Console.WriteLine("Your number is 4, I didnt bother to look this up. Four is so lame. That means if you chose this, you're kinda lame also... I dont make the rules.");
                break;
                case 5:
                Console.WriteLine("Your number is 5, it shows freedom and curiosity");
                break;
                case 6:
                Console.WriteLine("Your number is 6, it symbolizes love and taking care of others");
                break;
                case 7:
                Console.WriteLine("Your number is 7, this number shows intuition, wisdom, and self-awareness");
                break;
                case 8:
                Console.WriteLine("Your number is 8, this is a sign for victory, prosperity, and overcoming");
                break;
                case 9:
                Console.WriteLine("Your number is 9, signifies completion. The end of a cycle.");
                break;
                case 10:
                Console.WriteLine("Your number is 10, SUPPOSEDLY shows perfection. I also think this choice was kinda lame. Its overrated. I dont make the rules (I do make the rules).");
                break;                                                                                                                
            }
        }
    }
}
