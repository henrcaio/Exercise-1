using System;
using Exercise_1.Entities;
using Exercise_1.Entities.Enums;
using System.Collections.Generic;

namespace Exercise_1 {
    class Program {
        static void Main(string[] args) {
            List<Person> p = new List<Person>();
            int a = 0, b = 0, c = 0, d = 0;
            int totalPeople = 2;
            double avgAge = 0, perc;

            for (int i = 1; i <= totalPeople; i++) {
                Console.WriteLine($"Dados da pessoa {i}: ");

                Console.Write("Idade: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Peso: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                double height = double.Parse(Console.ReadLine());
                if (height > 1) {
                    height = height / 100;  //garantindo altura em cm
                }

                Console.WriteLine("Cor dos olhos:\n(1– Azul, 2- Preto, 3- Verde e 4- Castanho)");
                EyeColor eyeColor = Enum.Parse<EyeColor>(Console.ReadLine());

                Console.WriteLine("Cor do cabelo:\n(1 – Preto, 2- Castanho, 3– Louro e 4- Ruivo)");
                HairColor hairColor = Enum.Parse<HairColor>(Console.ReadLine());

                p.Add(new Person(age, weight, height, eyeColor, hairColor));
            }

            foreach (Person person in p) {
                if (person.Age > 50 && person.Weight < 60.00) {
                    a++;
                }
            }

            foreach (Person person in p) {
                if (person.Height < 1.50) {
                    b++;
                    avgAge += person.Age;
                }
            }

            avgAge = (avgAge / totalPeople);

            foreach (Person person in p) {
                if (person.EyeColor == EyeColor.Blue) {
                    c++;
                }
            }

            perc = c;
            perc = (perc / totalPeople) * 100;


            foreach (Person person in p) {
                if (person.EyeColor != EyeColor.Blue && person.HairColor == HairColor.Ginger) {
                    d++;
                }
            }

            Console.WriteLine($"1) A quantidade de pessoas com idade superior a 50 anos e peso inferior a 60 quilos: {a}");
            Console.WriteLine($"2) A média das idades das pessoas com altura inferior a 1,50: {avgAge.ToString("F2")}");
            Console.WriteLine($"3) A porcentagem de pessoas com olhos azuis entre as pessoas analisadas: {perc.ToString("F2")}");
            Console.WriteLine($"4) A quantidade de pessoas ruivas que não possuem olhos azuis: {d}");
        }
    }
}
