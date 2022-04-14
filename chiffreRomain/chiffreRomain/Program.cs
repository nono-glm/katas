using System;
using System.Collections.Generic;

namespace romain
{
    public class romain
    {
        public static void Main()
        {
            bool finApp = false;

            while (!finApp)
            {
                string saisie = "";
                int nombre = 0;

                while (!int.TryParse(saisie, out nombre))
                {
                    Console.Write("Tapez un nombre entier : ");
                    saisie = Console.ReadLine();
                }

                Console.Write("En chiffre romain : "+EnChiffreRomain(nombre));
                Console.WriteLine("\n");

                Console.Write("Tapez 'n' et Enter pour fermer la console, sinon taper autre chose pour continuer : ");
                if (Console.ReadLine() == "n") finApp = true;

                Console.WriteLine("\n");
                // je suis aprti pour pas faire faire des aller retour a flav. C est ta faute vu que t  as pas voulu me ramener.BSX
            }
        }

        public static string EnChiffreRomain(int chiffre)
        {
            string chiffreRomain = string.Empty;

            // Tableau des différentes numération
            int[] numeration = new int[4] { 1000, 100, 10, 1 };
            // Tableau milliers, centaines, dizaines, unité des caractére utilisé en chiffre romain pour former les chiffres
            char[,] chiffreRomainLettre = new char[4, 3]
            {
                { 'M', '\0', '\0' },
                { 'C', 'D', 'M'},
                { 'X', 'L', 'C'},
                { 'I', 'V', 'X'}
            };

            for (int i = 0; i < numeration.Length; i++)
            {
                if (chiffre >= numeration[i])
                {
                    // Prend le premier nombre du chiffre pour pouvoir le traiter
                    int firstChiffre = Convert.ToInt32(chiffre.ToString()[0].ToString());

                    // Ajoute les bon caractère romain en fonction du premier chiffre
                    switch (firstChiffre)
                    {
                        case 1:
                        case 2:
                        case 3:
                            // S'occupe des formats 1000: M, MM, MM; 100: C, CC, CCC; 10: X, XX, XXX; 1: I, II, III
                            for (int j = 0; j < firstChiffre; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 4:
                            // S'occupe des formats 100: CD; 10: XL; 1: IV
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 5:
                            // S'occupe des formats 100: D; 10: L; 1: V
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 6:
                        case 7:
                        case 8:
                            // S'occupe des formats 100: DC, DCC, DCCC; 10: LX, LXX, LXX; 1: VI, VII, VIII
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            for (int j = 0; j < firstChiffre - 5; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 9:
                            // S'occupe des formats 100: CM; 10: XC; 1: IX;
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 2];
                            break;
                    }
                }

                // Réduit à la numération inférieur
                chiffre %= numeration[i];
            }

            return chiffreRomain;
        }
    }
}