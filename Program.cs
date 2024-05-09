// Starter Code from Starter Modules
using System;
using System.Threading.Tasks.Sources;

public class Program
{
    public static void Main(string[] args)
    {
        // Intro Message to be displayed on the applications start
        Console.WriteLine("Welcome to the Coin Flip Challenge, inspired by 'No Country for Old Men'.");
        // Prompt the user to enter their name
        Console.WriteLine("What is your name frendo?");
        // Read the user's input and store it in a variable
        string name = Console.ReadLine();
        // Initialize a variable to keep track of the user's score and sets its value to zero
        int score = 0;

        // Display a message to the user asking if they want to play the game - with some not Country for Old Men Flair
        Console.WriteLine($"\n{name}, What's the most you have ever lost on a coin toss?");
        Console.WriteLine("Do you dare to challenge fate today? Yes/No");
        // Read the user's response and store it for later use
        string response = Console.ReadLine().Trim().ToLower();

        //Evaluate the user's response and display a message based on their answer
        if (response == "no")
        {
            // Display a message to the user and end the program
            Console.WriteLine($"Then you are a coward, {name}.");
            // End the program
            return;
        }
        // Display a message to the user and start the game - with some not Country for Old Men Flair
        Console.WriteLine("\nVery well, you have been challenging fate your whole life, you just didnt know it.");
        Console.WriteLine("If you win, you stand to gain an understanding of what fate holds for you and you can keep your life, If you lose, you face the uncertanty that death brings!");
        Console.WriteLine("There are 5 rounds, if you can best me more than half the rounds, fate may smile upon you Frendo");
        // Create a new instance of the Random class
        Random randomFlip = new Random();

        // Loop through 5 rounds of the game using a for loop
        for (int i = 0; i < 5; i++)
        {
            // Display a message to the user to prompt them to call the coin flip
            Console.WriteLine("\nCall it. Yes, just call it. Heads or Tails?");
            // Generate a random number to represent the coin flip
            int flip = randomFlip.Next(0, 2);
            // Read the user's input and store it in a variable
            string guess = Console.ReadLine().Trim().ToLower();
            // Evaluate the user's guess and the coin flip and display a message based on the result
            int coinFlip = (guess == "heads") ? 0 : 1;

            // Display the result of the round to the user
            if (flip == coinFlip)
            {
                // Display a message to the user and increment their score if it is correct
                Console.WriteLine("Well done. You've read fate correctly this round.");
                // Increment the user's score by adding 1 to the score variable
                score++;
            }
            else
            {
                // Display a message to the user and decrement their score if it is incorrect
                Console.WriteLine($"Wrong. Fate decrees otherwise; the coin shows {(coinFlip == 0 ? "heads." : "tails.")}");
                // Decrement the user's score by subtracting 1 from the score variable
                score--;
            }
        }
        // Display the user's final score and a message based on their score
        Console.WriteLine($"\n{name}, the game is over. Your Score {score} out of 5. ");
        // Evaluate the user's score and display a message if score is greate than 2
        if (score > 2) {
            // Display a message to the user
            Console.WriteLine("Fate has smiled on you today!");
            Console.WriteLine("This coin... it's your lucky quarter. Keep it where you won't mix it with others.");
            Console.WriteLine("It's more than just a coin now. It's a symbol of your brush with fate.");
        }
        else
        {
            // Display a message to the user
            Console.WriteLine("Fate has not smiled on you today.");
            Console.WriteLine("You have faced the uncertanty that death brings.");
            Console.WriteLine("You have lost the game, and now you must pay the price.");
        }

    }
}