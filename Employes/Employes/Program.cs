using System;
using System.Collections.Generic;

namespace employe
{
    public class Employe
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            //TASK 1

            List<Employe> listeEmployes = new List<Employe>();

            listeEmployes.Add(new Employe() { Name = "Max", Age = 17 });
            listeEmployes.Add(new Employe() { Name = "Sepp", Age = 18 });
            listeEmployes.Add(new Employe() { Name = "Nina", Age = 15 });
            listeEmployes.Add(new Employe() { Name = "Mike", Age = 51 });

            Console.WriteLine("Employés autorisés à travailler le dimanche : ");
            foreach (Employe c in listeEmployes)
            { 
                if (c.Age >= 18 )
                    Console.WriteLine(c.Name+" "+c.Age);
            }

            //TASK 2

            Console.WriteLine("Liste employé en ordre alphabétique : ");

            List<Employe> listeASC = listeEmployes.OrderBy(obj => obj.Name).ToList();

            foreach (Employe c in listeASC)
                Console.WriteLine(c.Name + " " + c.Age);

            //TASK 3

            Console.WriteLine("Liste employé en majuscule : ");

            foreach (Employe c in listeEmployes)
                Console.WriteLine(c.Name.ToUpper() + " " + c.Age);

            //TASK 4

            Console.WriteLine("Liste employé en ordre décroissant : ");

            List<Employe> listeDESC = listeEmployes.OrderByDescending(obj => obj.Name).ToList();

            foreach (Employe c in listeDESC)
                Console.WriteLine(c.Name + " " + c.Age);

        }
    }
}


        
