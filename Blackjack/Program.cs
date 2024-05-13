using System;
using System.Collections.Generic;
using ClassLibrary;


class Program
{
    static void Main(string[] args)
    {
        
        // ====== just a temporary representation, using the hand and deck classes ======
        
        
        // create cards list for player
        List<ICard> playerCards = new List<ICard>
        {
            CardFactory.CreateBlackjackCard(CardFace.A, CardSuit.Spades),
            CardFactory.CreateBlackjackCard(CardFace._7, CardSuit.Hearts)
        };
        
        // create cards list for dealer
        List<ICard> dealerCards = new List<ICard>
        {
            CardFactory.CreateBlackjackCard(CardFace._10, CardSuit.Clubs),
            CardFactory.CreateBlackjackCard(CardFace.K, CardSuit.Diamonds)
        };

        // create hands for dealer and player
        BlackjackHand playerHand = new BlackjackHand();
        BlackjackHand dealerHand = new BlackjackHand(isDealer: true);

        // add card to dealer and player hands
        foreach (var card in playerCards)
        {
            playerHand.AddCard(card);
        }
        foreach (var card in dealerCards)
        {
            dealerHand.AddCard(card);
        }
        
        Console.WriteLine("=== Player's Hand ===");
        playerHand.Print(0, 2);


        Console.WriteLine("=== Dealer's Hand ===");
        dealerHand.Print(0, 15); 

        Console.ReadLine(); 
    }
}

