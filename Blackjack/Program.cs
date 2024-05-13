using System;
using System.Collections.Generic;
using ClassLibrary;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        Console.Title = "♣ ♠ Blackjack ♥ ♦";
            
        bool runProgram = true;
        string prompt = "What would you like to do? ";
        string[] menuOptions = new string[] { "(1) Play Blackjack", "(2) Shuffle and Show Deck", "(3) Exit" };
        int menuSelection;
    
        while (runProgram)
        {
            Console.Clear();
            ReadMethods.ReadChoice(prompt, menuOptions, out menuSelection);
        
            switch (menuSelection)
            {
                case 1:
                    Console.Clear();
                    BlackjackGame gameInstance = new BlackjackGame();
                    bool playBlackjack = true;
                    int choice;
                
                    while (playBlackjack)
                    {
                        gameInstance.PlayRound();
                        choice = ReadMethods.ReadInteger("Want to play again?\n(1) Yes   (2) No ", 1, 2);
                    
                        if (choice == 1)
                            playBlackjack = true;
                        else
                            playBlackjack = false;
                    }
                    break;
                
                case 2:
                    Console.Clear();
                    Deck showdeck = new Deck(); 
                    showdeck.DeckMethod(); 
                    showdeck.Shuffle(); 
                    showdeck.Print(0, 6);
                    Console.WriteLine("\nPress any key to return to the main menu...");
                    Console.ReadKey();
                    break;
                
                case 3:
                    runProgram = false;
                    break;
            } 
        } 
    }

    
}

