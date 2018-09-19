using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rSuit = new Random();
            List<int> deck = new List<int>();
            Random shuffle = new Random();

            for (int i = 0; i < 4; i++)
            {
                deck.Add(1);
                deck.Add(2);
                deck.Add(3);
                deck.Add(4);
                deck.Add(5);
                deck.Add(6);
                deck.Add(7);
                deck.Add(8);
                deck.Add(9);
                deck.Add(10);
                deck.Add(11);
                deck.Add(12);
                deck.Add(13);

            }
            deck = deck.OrderBy(item => shuffle.Next()).ToList();
            int sum = 0;
            int switching = 1;
            int value = 0;
            string answer = "";
            string suitName = "";
            string valueName = "";
            int lineChange = 0;
            int rSuitCount = rSuit.Next(0, 3);
            do
            {

                if(lineChange == 1)
                {
                    Console.WriteLine("Draw another one? (yes or no)");
                    lineChange = 1;
                }
                else
                {
                    Console.WriteLine("Let's play blackjack! Get 21 points in\ntotal and you win but get over that and lose. " +
                    "Would you like to pull a card? (yes or no)");
                }
                lineChange = 1;
                answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "yes":
                        value = deck[0];
                        sum += value;

                        deck.RemoveAt(0);
                        switch (rSuitCount)
                        {
                            case 0:
                                suitName = "Hearts";
                                rSuitCount = rSuit.Next(0, 3);
                                break;
                            case 1:
                                suitName = "Diamonds";
                                rSuitCount = rSuit.Next(0, 3);
                                break;
                            case 2:
                                suitName = "Spades";
                                rSuitCount = rSuit.Next(0, 3);
                                break;
                            case 3:
                                suitName = "Clubs";
                                rSuitCount = rSuit.Next(0, 3);
                                break;

                        }
                        switch (value)
                        {
                            case 1:
                                valueName = "Ace";
                                break;
                            case 2:
                                valueName = "Two";
                                break;
                            case 3:
                                valueName = "Three";
                                break;
                            case 4:
                                valueName = "Four";
                                break;
                            case 5:
                                valueName = "Five";
                                break;
                            case 6:
                                valueName = "Six";
                                break;
                            case 7:
                                valueName = "Seven";
                                break;
                            case 8:
                                valueName = "Eight";
                                break;
                            case 9:
                                valueName = "Nine";
                                break;
                            case 10:
                                valueName = "Ten";
                                break;
                            case 11:
                                valueName = "Jack";
                                break;
                            case 12:
                                valueName = "Queen";
                                break;
                            case 13:
                                valueName = "King";
                                break;
                        }
                        Console.WriteLine("You pulled " + valueName + " of " + suitName + " and your sum is " + sum);
                        switching = 1;
                        break;
                    case "no":
                        Console.WriteLine("Your total sum is " + sum);
                        if (sum == 21)
                        {
                            Console.WriteLine("Good job you won CJ");
                            switching = 0;
                        }
                        else if(sum < 21)
                        {
                            Console.WriteLine("All you had to do was draw more cards CJ!");
                            switching = 1;
                        }
                        else
                        {
                            Console.WriteLine("You lost CJ");
                            switching = 0;
                        }

                        switching = 0;
                        break;
                    default:
                        Console.WriteLine("All you had to do was choose yes or no CJ!");
                        switching = 1;
                        break;
                }

            } while (switching != 0);




        }
    }

}