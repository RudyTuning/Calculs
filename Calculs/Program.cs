﻿/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            bool correct;

            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // oui bonjour j'écris n'importe nawak
                // création des 2 nombres aléatoires
                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10);
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();
                // traitement des choix
                switch (choix)
                {
                    // choix de l'addition
                    case "1":
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    // choix de la multiplication
                    case "2":
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    // demande de fin de programme
                    case "0":
                        break;
                    // erreur de saisie
                    default:
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
        }
    }
}
