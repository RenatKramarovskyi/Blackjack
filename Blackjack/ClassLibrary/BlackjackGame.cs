using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BlackjackGame
    {
        private BlackjackHand _dealer;
        private BlackjackHand _player;
        private Deck _deck;

        public void PlayRound()
        {
            InitializeRound();
            while (RoundInProgress())
            {
                if (CheckForBlackjack())
                    break;
                PlayersTurn();
                DealersTurn();
                EndRound();
            }
            AskForNewRound();
        }

        private void InitializeRound()
        {
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand(false);
            _deck = new Deck();
            _deck.Shuffle();
            DealInitialCards();
            DrawTable();
        }

        private bool RoundInProgress()
        {
            return !(_dealer.Score == 21 || _player.Score == 21);
        }
        private bool CheckForBlackjack()
        {
            if (_dealer.Score == 21 || _player.Score == 21)
            {
                DrawTable();
                RevealCard(0, 0);
                return true;
            }
            return false;
        }

        private void EndRound()
        {
            _dealer.IsDealer = false;
            DeclareWinner();
            Console.SetCursorPosition(0, 25);
        }

        private void AskForNewRound()
        {
            int choice = ReadMethods.ReadInteger("Want to play again?\n(1) Yes   (2) No ", 1, 2);
            if (choice == 1)
            {
                PlayRound();
            }
        }

        private void DealInitialCards()
        {
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
            bool playerTurn = true;
            string prompt = "(1) Hit or (2) Stand ";

            while (playerTurn)
            {
                if (_player.Score >= 21 || userStands)
                {
                    playerTurn = false;
                }
                else
                {
                    Console.SetCursorPosition(0, 20);
                    _player.Print(0, 20);

                    int option = ReadMethods.ReadInteger(prompt, 1, 2);
                    if (option == 1)
                    {
                        _player.AddCard(_deck.Deal());
                        DrawTable();
                        userStands = false;
                    }
                    else
                    {
                        userStands = true;
                    }
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
            if (_player.Score > 21)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Dealer wins, Player went over 21");
            }
            else if (_dealer.Score > 21)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Player wins, Dealer went over 21");
            }
            else if (_player.Score > _dealer.Score)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Player wins, Player's score was higher");
            }
            else if (_dealer.Score > _player.Score)
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("Dealer wins, Dealer's score was higher");
            }
            else
            {
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("No winner, Player and Dealer tied");
            }
        }

        private void DrawTable()
        {
            Console.Clear();
            int x = 0;
            int y = 0;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("---- Dealer's Hand ----");

            Console.SetCursorPosition(x, y + 1);
            _dealer.Print(x, y + 1);

            y = _dealer.CountCards() * 6 + 3;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("---- Player's Hand ----");

            _player.Print(x, y + 1);
        }

        private void RevealCard(int x, int y)
        {
            Console.SetCursorPosition(x, y + 1);
            _dealer.Print(x, y + 1);
            _dealer.PrintReveal(x, y + 1);
        }
    }
} 