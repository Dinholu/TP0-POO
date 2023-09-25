using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string GetFullName(string firstName, string name)
        {
            return firstName.ToLower() + " " + name.ToUpper();
        }
        public static float GetIMC(float weight, int size)
        {
            float sizeInMeters = size / 100f;
            return weight / (sizeInMeters * sizeInMeters);
        }

        public static void GetIMCComment(float yourImc)
        {
            const string VERY_LOW_IMC = "Attention à l’anorexie !";
            const string LOW_IMC = "Vous êtes un peu maigrichon!";
            const string NORMAL_IMC = "Vous êtes de corpulence normale !";
            const string BIG_IMC = "Vous êtes en surpoids !";
            const string VERY_BIG_IMC = "Obésité modérée !";
            const string YOU_RE_DYING_MEN = "Obésité morbide !";


            if (yourImc < 16.5)
            {
                Console.WriteLine(VERY_LOW_IMC);
            }
            else if (yourImc >= 16.5 && yourImc < 18.5)
            {
                Console.WriteLine(LOW_IMC);
            }
            else if (yourImc >= 18.5 && yourImc < 25)
            {
                Console.WriteLine(NORMAL_IMC);
            }
            else if (yourImc >= 25 && yourImc < 30)
            {
                Console.WriteLine(BIG_IMC);
            }
            else if (yourImc >= 30 && yourImc < 35)
            {
                Console.WriteLine();
            }
            else if (yourImc >= 35 && yourImc < 40)
            {
                Console.WriteLine(VERY_BIG_IMC);
            }
            else
            {
                Console.WriteLine(YOU_RE_DYING_MEN);
            }

        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("A. Au commencement");
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Bienvenue sur mon programme, jeune étranger imberbe");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");
            Console.Write("Donne moi ton nom, vil chenapan : ");

            string name = Console.ReadLine();
            Console.Write("Et quel est ton prénom, petit galopin :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Bonjour {0} {1} !", firstName, name);

            Console.Write("Ta taille en (cm) : ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Ton poids (en kg) : ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("ton age : ");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine(age < 18 ? "Tu n'es qu'une pauvre petite merde !" : "Va payer tes impots !");
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("B. La suite du commencement");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Voila ton nom et prenom formatés correctement : " + GetFullName(firstName, name));

            float yourImc = GetIMC(weight, size);

            Console.WriteLine("Voila ton imc : " + yourImc.ToString("0.0"));
            Console.WriteLine("\n");

            Console.WriteLine("----------------------------------------------------"); 
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("C. La continuité de la suite du début…");
            Console.WriteLine("\n");

            GetIMCComment(yourImc);

            int hairMin = 100000;
            int hairMax = 150000;
            int hairEstimation = 0;

            do
            {
                Console.Write("Estimez le nombre de cheveux sur votre tête : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out hairEstimation))
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




            Console.ReadLine();

        }





    }
}
