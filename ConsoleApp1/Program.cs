using System;
using System.Linq;
using System.Threading;

namespace TP0
{
    internal class Program
    {

        public static void Count()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            return;
        }
        public static void CallAuntie()
        {
                Console.Write(" Appel en cours.");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.WriteLine(".");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.Write("Bip");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.Write(".");
                Thread.Sleep(400);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.Write("..Clic...");
                Thread.Sleep(1000);
                Console.Write("Allo?...");
                Thread.Sleep(1000);
                Console.Write("Allo?...");
                Thread.Sleep(1000);
                Console.WriteLine("Et non vous vous êtes fait avoir, je ne suis pas la, laissez moi un message après le bip ! ");
                Thread.Sleep(1000);
            return;
        }
        public static string GetFullName(string firstName, string name)
        {
            return firstName.ToLower() + " " + name.ToUpper();
        }
        public static float GetIMC(float weight, int size)
        {
            float sizeInMeters = size / 100f;
            return weight / (sizeInMeters * sizeInMeters);
        }

        public static string GetIMCComment(float yourImc)
        {
            const string VERY_LOW_IMC = "Attention à l’anorexie !";
            const string LOW_IMC = "Vous êtes un peu maigrichon!";
            const string NORMAL_IMC = "Vous êtes de corpulence normale !";
            const string BIG_IMC = "Vous êtes en surpoids !";
            const string VERY_BIG_IMC = "Obésité modérée !";
            const string VERY_VERY_BIG_IMC = "Obésité sévère";
            const string YOU_RE_DYING_MEN = "Obésité morbide !";


            if (yourImc < 16.5)
            {
                return VERY_LOW_IMC;
            }
            else if (yourImc >= 16.5 && yourImc < 18.5)
            {
                return LOW_IMC;
            }
            else if (yourImc >= 18.5 && yourImc < 25)
            {
                return NORMAL_IMC ;
            }
            else if (yourImc >= 25 && yourImc < 30)
            {
                return BIG_IMC;
            }
            else if (yourImc >= 30 && yourImc < 35)
            {
                return VERY_BIG_IMC;
            }
            else if (yourImc >= 35 && yourImc < 40)
            {
                return VERY_VERY_BIG_IMC;
            }
            else
            {
                return YOU_RE_DYING_MEN;
            }

        }

        static bool IsNameValid(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            int endProgram = 0;
            do { 
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Bienvenue sur mon programme, jeune étranger imberbe !");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("\n");


                string name = "";
                string firstName = "";
                while (string.IsNullOrWhiteSpace(name) || !IsNameValid(name))
                {
                   Console.Write("Donne moi ton nom, vil chenapan : ");
                   name = Console.ReadLine();
                   name = name.Trim();
                }

                while (string.IsNullOrWhiteSpace(firstName) || !IsNameValid(firstName))
                {
                   Console.Write("Et quel est ton prénom, petit galopin : ");
                   firstName = Console.ReadLine();
                   firstName = firstName.Trim();
                }

                Console.WriteLine($"Bonjour, {GetFullName(firstName, name)} !");

                int size;
                float weight;
                int age;

                do
                {
                    Console.Write("Ta taille en (cm) : ");
                } while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);

                do
                {
                    Console.Write("Ton poids (en kg) : ");
                } while (!float.TryParse(Console.ReadLine(), out weight) || weight <= 0);

                do
                {
                    Console.Write("Ton age : ");
                } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0);

                Console.WriteLine(age < 18 ? "Qu'est ce que tu fais ici? Allez hop un pipi et au lit!" : "Tu penses que tu as le temps pour ca ? Va payer tes impots !");

                float yourImc = GetIMC(weight, size);

                Console.WriteLine("\n Voilà ton IMC : " + yourImc.ToString("0.0"));
                Console.WriteLine("Commentaire : " + GetIMCComment(yourImc));

                Console.WriteLine("\n----------------------------------------------------");

                int hairMin = 100000;
                int hairMax = 150000;
                do
                {
                    Console.Write("Estimez le nombre de cheveux sur votre tête : ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int hairEstimation))
                    {
                        if (hairEstimation >= hairMin && hairEstimation <= hairMax)
                        {
                            Console.WriteLine("Estimation valide !");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("L'estimation doit être comprise entre " + hairMin + " et " + hairMax + ".");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer un nombre valide.");
                    }
                } while (true);


                int end = 0;

                do
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Vous avez fini, que voulez vous faire ? \n 1 - Quitter le programme \n 2 - Recommencer le programme \n 3 - Compter jusqu'à 10 \n 4 - Téléphoner à Tata Jacqueline");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("Quel est votre choix ? : ");
                    if (int.TryParse(Console.ReadLine(), out int choice)) { 
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Aurevoir petit sacripan (Oui j'ai des expressions de vieille)");
                                Thread.Sleep(3000);
                                    endProgram = 1;
                                    end = 1;
                                break;
                            case 2:
                                end = 1;
                                break;
                            case 3:
                                Count();
                                break;
                            case 4:
                                CallAuntie();
                            Thread.Sleep(1000);
                                break;
                            default:
                                Console.WriteLine("Veuillez choisir une valeur plausible");
                                break;
                        }
                    }
                    else
                    {

                        Console.WriteLine("\n Arrête de jouer au con !!! \n");

                    }
                }
                    while (end == 0);
            } while(endProgram == 0 );
            return;
        }
    }
}
