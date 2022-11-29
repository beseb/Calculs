/**
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
            int reponse; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            bool correct = false;

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();

                // traitement des choix
                switch (choix)
                {
                    case 1:

                        // choix de l'addition
                        val1 = rand.Next(0, 10);
                        val2 = rand.Next(0, 10);
                        correct = false;
                        while (!correct):
                         { 
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un nombre entier");
                            }

                         }
                        // Comparaison avec la bonne réponse
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

                    case 2:
                        val1 = rand.Next(0, 10);
                        val2 = rand.Next(0, 10);
                        correct = false;
                        while (!correct):
                                { 
                                try
                                 {
                            Console.Write(val1 + " x " + val2 + " = ");
                            reponse = int.Parse(Console.ReadLine());
                            correct = true
                                 }
                                catch
                                {
                            Console.Write("Entrez un nombre entier");
                                }
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

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Entrez un chiffre valide pour choisir une opération");
                        break;


                    }
                }

            }
        }
    }