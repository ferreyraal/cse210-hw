using System;

class Program
{

    // Author: Alejandro Ferreyra 
    // Week3 - 
    // stretch challenge: It will choose to hide only words that aren't hidden. See HideRandomWords()
    static void Main(string[] args)
    {
        // Define scripture text and reference
        string txt_scripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them";
        Reference newReference = new Reference("1 Nefhi", 3, 7);
        Scripture scripture = new Scripture(newReference, txt_scripture);
        string user_entry = "";

        // Loop util user type quit 
        do {
            // Clear console and display Scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            // ask user an option 
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            user_entry = Console.ReadLine();
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                // Show scripture when all words are hidden and then quit.
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                user_entry= "quit";
            }

        } while (user_entry != "quit");


    }
    
}