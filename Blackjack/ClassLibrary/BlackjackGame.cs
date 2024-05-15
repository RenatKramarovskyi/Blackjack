using System;

namespace ClassLibrary
{
    public class BlackjackGame
    {
        private const int DealerInitialPositionY = 0;
        private const int PlayerInitialPositionY = 20;
        private const int ResultPositionY = 23;
        private const int PlayAgainPositionY = 25;

        private BlackjackHand _dealer;
        private BlackjackHand _player;
        private Deck _deck;

        public void PlayRound()
        {
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand(false);
            _deck = new Deck();

            DealInitialCards();
            if (_dealer.Score == 21 || _player.Score == 21)
            {
                DrawTable();
                RevealCard();
            }
            else
            {
                PlayersTurn();
                DealersTurn();
            }

            DeclareWinner();
            AskForNewRound();
        }

        private void DealInitialCards()
        {
            _deck.InitializeDeck();
            _deck.Shuffle();
            for (int i = 0; i < 2; i++)
            {
                _player.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
            }
            DrawTable();
        }

        private void PlayersTurn()
        {
            bool userStands = false;
            while (_player.Score < 21 && !userStands)
            {
                Console.SetCursorPosition(0, PlayerInitialPositionY);
                _player.Print(0, PlayerInitialPositionY); 

                int option = ReadMethods.ReadInteger("(1) Hit or (2) Stand ", 1, 2);
                if (option == 1)
                {
                    _player.AddCard(_deck.Deal());
                    DrawTable(); 
                }
                else
                {
                    userStands = true;
                }
            }
        }

        private void DealersTurn()
        {
            DrawTable();
            while (_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            } 
        }

        private void DeclareWinner()
        {
            DrawTable();
            Console.SetCursorPosition(0, ResultPositionY);
            if (_player.Score > 21)
            {
                Console.WriteLine("Dealer wins, Player went over 21");
            }
            else if (_dealer.Score > 21)
            {
                Console.WriteLine("Player wins, Dealer went over 21");
            }
            else if (_player.Score > _dealer.Score)
            {
                Console.WriteLine("Player wins, Player's score was higher");
            }
            else if (_dealer.Score > _player.Score)
            {
                Console.WriteLine("Dealer wins, Dealer's score was higher");
            }
            else
            {
                Console.WriteLine("No winner, Player and Dealer tied");
            }
        }

        private void DrawTable()
        {
            Console.Clear();
            Console.SetCursorPosition(0, DealerInitialPositionY);
            Console.WriteLine("---- Dealer's Hand ----");
            _dealer.Print(0, DealerInitialPositionY + 1);
            
            int y = _dealer.CountCards() * 6 + 3; 
            Console.SetCursorPosition(0, y);
            Console.WriteLine("---- Player's Hand ----");
            _player.Print(0, y + 1);
        }

        private void RevealCard()
        {
            _dealer.PrintReveal(0, DealerInitialPositionY + 1);
        }

        private void AskForNewRound()
        {
            int choice = ReadMethods.ReadInteger("Want to play again?\n(1) Yes   (2) No ", 1, 2);
            if (choice == 1)
            {
                PlayRound(); 
            }
        }
    } 
}
