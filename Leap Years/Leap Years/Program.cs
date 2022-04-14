using System;

namespace leapYear
{
    class Program
    {
        public static void Main()
        {
            bool endApp = false;

            while (!endApp)
            {

                string saisie = "";
                int annee = 0;
                string vrai = "It's a leap year";
                string faux = "It's not a leap year";

                while (!int.TryParse(saisie, out annee))
                {
                    Console.Write("Please enter an integer value: ");
                    saisie = Console.ReadLine();
                }

                if ( annee % 400 == 0)
                    Console.WriteLine(vrai);
                else if (annee % 100 == 0)
                    Console.WriteLine(faux);
                else if (annee % 4 == 0)
                    Console.WriteLine(vrai);
                else
                    Console.WriteLine(faux);


                if (DateTime.IsLeapYear(annee))
                    Console.WriteLine(annee + " is a leap year");
                else
                    Console.WriteLine(annee + " isn't a leap year");


                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }

        }
    }
}
