using System;
using System.Reflection.Metadata;

// Extra is the ability for the user to choose a scripture from the library and work on specific scripture masteries. 
//Would love to expand more on this with random option, quizes options where you fill in the blank , and other ideas. 
//Unfortunately life doesn't allow for excessive time at the moment but plan to come back to this. Thank you!
public partial class Program
{
    static void Main(string [] args)
    {
        // Creation of a dictionary to house scriptures. 
        var scriptures = new Dictionary<string, Scripture>
        {
            {
                "John 3:16", 
                new Scripture(new Reference("John", 3, 16), "16 For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
            },
            {
                "1 Nephi 3:7",
                new Scripture(new Reference("1 Nephi", 3, 7), "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")
            },
            {
                "2 Nephi 2:25",
                new Scripture(new Reference("2 Nephi", 2, 25), "25 Adam fell that men might be; and men are, that they might have joy.")
            },
            {
                "2 Nephi 9:28-29",
                new Scripture(new Reference("2 Nephi", 9, 28, 29), "28 O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. 29 But to be learned is good if they hearken unto the counsels of God.")
            },
            {
                "2 Nephi 28:7-9",
                new Scripture(new Reference("2 Nephi", 28, 7, 9), "7 Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. 8 And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. 9 Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark.")
            },
            {
                "Moroni 10:4-5",
                new Scripture(new Reference("Moroni", 10, 4, 5), "4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things.")
            }            
        };
        
        // Prints the keys that were made in the dictionary that corresponds to the references of each scripture
        Console.WriteLine("Available Scriptures:");
        foreach (var key in scriptures.Keys)
        {
            Console.WriteLine(key);
        }

        // Asking user for input of what scripture they'd like to work on
        Console.WriteLine("\nEnter the reference of the desired scripture to memorize: ");
        string selectedReference = Console.ReadLine();

        // Checks the user input for reference key that is in the dictionary 
        if (scriptures.TryGetValue(selectedReference, out Scripture selectedScripture))
        {
            // If the reference key matches enters loop for the word dissapearing 
            while (!selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("\nScripture to Memorize: ");
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide 3 additional words, or type 'quit' to exit."); 
                string userInput = Console.ReadLine();

                // Code to read user input to exit program early
                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                // Code to select how many random words to hide
                selectedScripture.HideRandomWords(3);
            }

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nCongratulations, You have memorized your scripture!");
            }
        }

        // Error message given to user if reference is not in the dictionary
        else
        {
            Console.WriteLine("\nSorry this scripture reference is not available at this time.");
        }
    }
}