using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Mastery!");
        Console.WriteLine("What scripture mastery reference would you like to practice? ");
        userChoice = " "; 
        Console.ReadLine();
        
        while (userChoice != "3")
        {
            Console.WriteLine("Mastery Menu");
            Console.WriteLine("1. Display Scripture\n     Press Enter to continue Mastery");
            Console.WriteLine("2. New Scripture");
            Console.WriteLine("3. Quit");
            Console.WriteLine("Please select your option: ");
            userChoice = Console.ReadLine();
    }
}
// Program:
//Welcome Message
//User input for scripture reference
//Menu options
//If/ Else If

//Reference:
//Code for iterating through scripture list to provide scripture from user input in program.
//Needs ability to read multiple verses.

//Scripture:
//List of Scriptures
//Display Option for Word Disappearing
//Pull code from Word
//Code for hitting enter to make more words disappear

//Word:
//Random disappearing of words and display of new scripture.