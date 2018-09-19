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
            int rSuitCount = rSuit.Next(0, 3);
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
            do
            {
                Console.WriteLine("Would you like to pull a card? (yes or no)");
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
                                suitName = "Hjärter";
                                break;
                            case 1:
                                suitName = "Ruter";
                                break;
                            case 2:
                                suitName = "Spader";
                                break;
                            case 3:
                                suitName = "Klöver";
                                break;

                        }
                        switch (value)
                        {
                            case 1:
                                valueName = "Ess";
                                break;
                            case 2:
                                valueName = "Två";
                                break;
                            case 3:
                                valueName = "Tre";
                                break;
                            case 4:
                                valueName = "Fyra";
                                break;
                            case 5:
                                valueName = "Fem";
                                break;
                            case 6:
                                valueName = "Sex";
                                break;
                            case 7:
                                valueName = "Sju";
                                break;
                            case 8:
                                valueName = "Åtta";
                                break;
                            case 9:
                                valueName = "Nio";
                                break;
                            case 10:
                                valueName = "Tio";
                                break;
                            case 11:
                                valueName = "Knäckt";
                                break;
                            case 12:
                                valueName = "Dam";
                                break;
                            case 13:
                                valueName = "Kung";
                                break;
                        }
                        Console.WriteLine("Du drog " + suitName + " " + valueName + " och din summa är " + sum);
                        switching = 1;
                        break;
                    case "no":
                        Console.WriteLine("Din totala summa är " + sum);
                        switching = 0;
                        break;
                    default:
                        Console.WriteLine("All you had to do was choose yes or no CJ");
                        switching = 1;
                        break;
                }

            } while (switching != 0);




        }
    }

}