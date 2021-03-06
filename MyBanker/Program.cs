﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of menu
            Console.WriteLine("Welcome to this fancy bank");
            Console.Write("Press Enter:");
            Console.ReadLine();

            //Ask for a name for the card
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();

            //instances
            Card withdrawalCard = new WithdrawalCard(name);
            Account account = new Account(name);

            //START of GUI


            //user input to navigate the menu
            int userInput;
            string age;
            int userAge;
            do
            {
                //Menu after your name is inputted
                Console.Clear();
                Console.WriteLine("Press (1) to make a Mastercard\n" +
                                  "Press (2) to make a VISA Dancard\n" +
                                  "Press (3) to make a Maestro card\n" +
                                  "Press (4) to make a VISA Electron card\n" +
                                  "Press (5) to exit");

                string input = Console.ReadLine();
                userInput = int.Parse(input);
                switch (userInput)
                {
                    //If Mastercard is chosen
                    case 1:
                        Card mastercard = new Mastercard(name);
                        Console.Clear();
                        Console.WriteLine("Welcome " + name + "\nHere is your new card:\n");
                        Console.WriteLine("------------------------");
                        Console.WriteLine(mastercard.GetType().Name);
                        Console.WriteLine("Belongs to: " + name);
                        Console.WriteLine("Card number: " + mastercard.CardNumber);
                        Console.WriteLine("Expiration date: " + mastercard.ExpireDate);
                        Console.WriteLine("Account number: " + account.AccountNumber);
                        Console.WriteLine("------------------------\n");
                        Console.Write("Press enter to continue: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //If VISA Dancard is chosen
                    case 2:
                        Card visaDankort = new VISADankort(name);
                        Console.Clear();
                        Console.WriteLine("How old are you?");
                        age = Console.ReadLine();
                        userAge = int.Parse(age);
                        if (visaDankort.MinAge <= userAge)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome " + name + "\nHere is your new card:\n");
                            Console.WriteLine("------------------------");
                            Console.WriteLine(visaDankort.GetType().Name);
                            Console.WriteLine("Belongs to: " + name);
                            Console.WriteLine("Card number: " + visaDankort.CardNumber);
                            Console.WriteLine("Expiration date: " + visaDankort.ExpireDate);
                            Console.WriteLine("Account number: " + account.AccountNumber);
                            Console.WriteLine("------------------------\n");
                            Console.Write("Press enter to continue: ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, we cannot make a {visaDankort.GetType().Name} card because you are too young.\n" +
                  $"Would you like to get a {withdrawalCard.GetType().Name} instead? ( yes / no )");
                            string withdrawCard = Console.ReadLine();
                            if (withdrawCard == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Here is your new card:" + name + "\n");
                                Console.WriteLine("------------------------");
                                Console.WriteLine(withdrawalCard.GetType().Name);
                                Console.WriteLine("Belongs to: " + name);
                                Console.WriteLine("Card number: " + withdrawalCard.CardNumber);
                                Console.WriteLine("Expiration date: " + withdrawalCard.ExpireDate);
                                Console.WriteLine("Account number: " + account.AccountNumber);
                                Console.WriteLine("------------------------\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else if (withdrawCard == "no")
                            {
                                Console.Clear();
                                Console.WriteLine("Have a nice day\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There seemed to have been a wrong input\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                        }
                        break;
                    //If Maestro card is chosen
                    case 3:
                        Card maestro = new Maestro(name);
                        Console.Clear();
                        Console.WriteLine("How old are you?");
                        age = Console.ReadLine();
                        userAge = int.Parse(age);
                        if (maestro.MinAge <= userAge)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome " + name + "\nHere is your new card:\n");
                            Console.WriteLine("------------------------");
                            Console.WriteLine(maestro.GetType().Name);
                            Console.WriteLine("Belongs to: " + name);
                            Console.WriteLine("Card number: " + maestro.CardNumber);
                            Console.WriteLine("Expiration date: " + maestro.ExpireDate);
                            Console.WriteLine("Account number: " + account.AccountNumber);
                            Console.WriteLine("------------------------\n");
                            Console.Write("Press enter to continue: ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, we cannot make a {maestro.GetType().Name} card because you are too young.\n" +
                                              $"Would you like to get a {withdrawalCard.GetType().Name} instead? ( yes / no )");
                            string withdrawCard = Console.ReadLine();
                            if (withdrawCard == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Here is your new card:" + name + "\n");
                                Console.WriteLine("------------------------");
                                Console.WriteLine(withdrawalCard.GetType().Name);
                                Console.WriteLine("Belongs to: " + name);
                                Console.WriteLine("Card number: " + withdrawalCard.CardNumber);
                                Console.WriteLine("Expiration date: " + withdrawalCard.ExpireDate);
                                Console.WriteLine("Account number: " + account.AccountNumber);
                                Console.WriteLine("------------------------\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else if (withdrawCard == "no")
                            {
                                Console.Clear();
                                Console.WriteLine("Have a nice day\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There seemed to have been a wrong input\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                        }
                        break;
                    //If VISA Electron is chosen
                    case 4:
                        Card visaElectron = new VISAElectron(name);
                        Console.Clear();
                        Console.WriteLine("How old are you?");
                        age = Console.ReadLine();
                        userAge = int.Parse(age);
                        if (visaElectron.MinAge <= userAge)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome " + name + "\nHere is your new card:\n");
                            Console.WriteLine("------------------------");
                            Console.WriteLine(visaElectron.GetType().Name);
                            Console.WriteLine("Belongs to: " + name);
                            Console.WriteLine("Card number: " + visaElectron.CardNumber);
                            Console.WriteLine("Expiration date: " + visaElectron.ExpireDate);
                            Console.WriteLine("Account number: " + account.AccountNumber);
                            Console.WriteLine("------------------------\n");
                            Console.Write("Press enter to continue: ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, we cannot make a {visaElectron.GetType().Name} card because you are too young.\n" +
                                              $"Would you like to get a {withdrawalCard.GetType().Name} instead? ( yes / no )");
                            string withdrawCard = Console.ReadLine();
                            if (withdrawCard == "yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Here is your new card:" + name + "\n");
                                Console.WriteLine("------------------------");
                                Console.WriteLine(withdrawalCard.GetType().Name);
                                Console.WriteLine("Belongs to: " + name);
                                Console.WriteLine("Card number: " + withdrawalCard.CardNumber);
                                Console.WriteLine("Expiration date: " + withdrawalCard.ExpireDate);
                                Console.WriteLine("Account number: " + account.AccountNumber);
                                Console.WriteLine("------------------------\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else if (withdrawCard == "no")
                            {
                                Console.Clear();
                                Console.WriteLine("Have a nice day\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There seemed to have been a wrong input\n");
                                Console.Write("Press enter to continue: ");
                                Console.ReadLine();
                            }
                        }
                        break;
                    default:
                        break;
                }
            //If the number 5 is pressed, the program closes
            } while (userInput != 5);
        }

    }
}
